using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Auditoría de eventos y sincronización entre sucursales (solo rol Administrador general).
    /// Estructuras: ListaSimple (cargar y filtrar eventos y enlaces),
    /// ListaCircular (rotar el turno de sincronización entre las sucursales, volviendo al inicio al terminar),
    /// Cola (las sucursales sin conectividad esperan su reintento en orden de llegada),
    /// Árbol binario de búsqueda (índice del buscador de eventos) y
    /// Grafo (simula la red de sucursales: Floyd-Warshall busca la ruta más barata hasta la central
    /// y Prim calcula la red de menor costo; todo con los pesos de enlaces_sync.json).
    /// </summary>
    public partial class UC_AuditoriaSincronizacion : UserControl
    {
        private const int MaximoEventos = 500;
        private const string CodigoCentral = "ADM-01";                           // sede a la que llegan los datos

        private IndiceBusqueda<Auditoria> indice = new IndiceBusqueda<Auditoria>();   // ABB: busca por acción o detalle
        private string ultimaRuta = "";                                          // ruta usada en la última sincronización

        private ListaCircular<string> rotacion = new ListaCircular<string>();   // códigos de sucursal (Origen) por turnos
        private Cola<string> pendientes = new Cola<string>();                   // sucursales que fallaron y esperan reintento
        private bool listo;                                                      // evita cargar datos antes de tiempo

        public UC_AuditoriaSincronizacion()
        {
            InitializeComponent();
        }

        private void UC_AuditoriaSincronizacion_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            // Cada tienda tiene un turno en la rotación (la sede administrativa es el destino, no tiene turno)
            rotacion = new ListaCircular<string>();
            foreach (Sucursal sucursal in Almacen.Sucursales.Cargar())
            {
                if (sucursal.Tipo == "TIENDA") rotacion.Agregar(sucursal.Codigo);
            }

            listo = true;
            CargarEnlaces();
            CargarAuditoria();
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            CargarEnlaces();
            CargarAuditoria();
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            if (listo) CargarAuditoria();
        }

        // ------------------------------------------------------------ Auditoría

        private void CargarAuditoria()
        {
            string texto = txtBuscar.Text.Trim();
            Dictionary<int, Sucursal> sucursales = Almacen.Sucursales.Cargar().ToDictionary(s => s.SucursalId);

            // El índice se vuelve a armar solo cuando hay eventos nuevos (la auditoría solo agrega eventos)
            List<Auditoria> registros = Almacen.Auditoria.Cargar();
            if (registros.Count != indice.Cantidad) ArmarIndice(registros);

            // ListaSimple: sin texto salen todos; con texto, el índice (ABB) devuelve los que coinciden.
            // En ambos casos se muestra del evento más reciente al más antiguo.
            ListaSimple<Auditoria> eventos;
            if (texto.Length == 0)
                eventos = ListaSimple<Auditoria>.Desde(registros.OrderByDescending(a => a.FechaEvento));
            else
                eventos = ListaSimple<Auditoria>.Desde(indice.Buscar(texto).OrderByDescending(a => a.FechaEvento));

            dgvAuditoria.Rows.Clear();
            int mostrados = 0;
            foreach (Auditoria evento in eventos)
            {
                if (mostrados++ >= MaximoEventos) break;

                string codigoSucursal = "-";
                if (evento.SucursalId != null && sucursales.TryGetValue(evento.SucursalId.Value, out Sucursal? sucursal))
                    codigoSucursal = sucursal.Codigo;

                int fila = dgvAuditoria.Rows.Add(evento.FechaEvento.ToString("dd/MM/yyyy HH:mm"),
                                                 evento.UsuarioId?.ToString() ?? "-", codigoSucursal,
                                                 evento.Accion, evento.Detalle);
                if (evento.Accion == "SYNC_FALLIDA")
                    dgvAuditoria.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
            }

            lblTotalAuditoria.Text = eventos.Cantidad > MaximoEventos
                ? $"Eventos: {eventos.Cantidad}  (se muestran los {MaximoEventos} más recientes)"
                : $"Eventos: {eventos.Cantidad}";
        }

        /// <summary>Guarda cada evento en el índice con su acción y su detalle.</summary>
        private void ArmarIndice(List<Auditoria> registros)
        {
            indice = new IndiceBusqueda<Auditoria>();
            foreach (Auditoria evento in registros)
                indice.Agregar(evento, new string?[] { evento.Accion, evento.Detalle });
        }

        // ------------------------------------------------------------ Enlaces

        private void CargarEnlaces(string? origenSeleccionado = null, string? destinoSeleccionado = null)
        {
            ListaSimple<EnlaceSync> enlaces = ListaSimple<EnlaceSync>.Desde(Almacen.Enlaces.Cargar());
            int disponibles = enlaces.Filtrar(x => x.Disponible).Cantidad;

            dgvEnlaces.Rows.Clear();
            foreach (EnlaceSync enlace in enlaces)
            {
                int fila = dgvEnlaces.Rows.Add(enlace.Origen, enlace.Destino, enlace.Costo.ToString("0.##"),
                                               enlace.Disponible ? "Disponible" : "Caído");
                dgvEnlaces.Rows[fila].Tag = enlace;
                if (!enlace.Disponible) dgvEnlaces.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
            }

            // Vuelve a marcar el enlace que estaba elegido
            if (origenSeleccionado != null)
            {
                foreach (DataGridViewRow fila in dgvEnlaces.Rows)
                {
                    if (fila.Tag is EnlaceSync actual && actual.Origen == origenSeleccionado && actual.Destino == destinoSeleccionado)
                    {
                        dgvEnlaces.ClearSelection();
                        fila.Selected = true;
                        dgvEnlaces.CurrentCell = fila.Cells[0];
                        break;
                    }
                }
            }

            // Prim: red de menor costo que conecta las sedes a partir de la central (solo con enlaces disponibles)
            GrafoSucursales grafo = GrafoSucursales.Desde(enlaces);
            ListaSimple<Arista> redMinima = grafo.CalcularPrim(CodigoCentral);
            decimal costoRed = 0;
            foreach (Arista arista in redMinima) costoRed = costoRed + arista.Costo;   // con +=: costoRed += arista.Costo;

            lblEstadoSync.Text = $"Enlaces disponibles: {disponibles} de {enlaces.Cantidad}  ·  Prim: costo {costoRed:0.##} ({redMinima.Cantidad + 1} de {grafo.CantidadNodos} sedes)";
            ActualizarPendientes();
        }

        private void ActualizarPendientes()
        {
            lblPendientes.Text = $"En cola de reintento: {pendientes.Cantidad}";
            lblSiguientePendiente.Text = $"Siguiente reintento: {pendientes.Frente() ?? "-"}";
            btnReintentar.Enabled = !pendientes.EstaVacia;
        }

        /// <summary>Simula una caída o el restablecimiento de la conectividad del enlace elegido.</summary>
        private void btnAlternarEnlace_Click(object? sender, EventArgs e)
        {
            if (dgvEnlaces.SelectedRows.Count == 0 || dgvEnlaces.SelectedRows[0].Tag is not EnlaceSync elegido)
            {
                MessageBox.Show("Seleccione un enlace de la tabla.", "Sincronización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<EnlaceSync> todos = Almacen.Enlaces.Cargar();
            EnlaceSync? registro = todos.FirstOrDefault(x => x.Origen == elegido.Origen && x.Destino == elegido.Destino);
            if (registro == null) return;

            registro.Disponible = !registro.Disponible;
            Almacen.Enlaces.Guardar(todos);

            ServicioAdminGeneral.RegistrarAuditoria("ENLACE_ESTADO",
                $"{registro.Origen} → {registro.Destino}: {(registro.Disponible ? "conectividad restablecida" : "conectividad caída")}");

            CargarEnlaces(registro.Origen, registro.Destino);
            CargarAuditoria();
        }

        // ------------------------------------------------------------ Sincronización (ListaCircular + Cola)

        /// <summary>Le toca el turno a la siguiente sucursal de la rotación.</summary>
        private void btnSincronizar_Click(object? sender, EventArgs e)
        {
            string? codigo = rotacion.SiguienteTurno();
            if (codigo == null)
            {
                MessageBox.Show("No hay enlaces de sincronización configurados.", "Sincronización",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblTurno.Text = $"Último turno: {codigo}";
            bool correcta = IntentarSincronizar(codigo, false);

            CargarEnlaces();
            CargarAuditoria();

            MessageBox.Show(correcta
                    ? $"{codigo} se sincronizó correctamente.\nRuta: {ultimaRuta}"
                    : $"{codigo} no tiene ruta hacia la central. Quedó en la cola de reintento.",
                "Sincronización", MessageBoxButtons.OK, correcta ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        /// <summary>Saca al que está al frente de la cola y lo vuelve a intentar (si falla, va al final).</summary>
        private void btnReintentar_Click(object? sender, EventArgs e)
        {
            string? codigo = pendientes.Desencolar();
            if (codigo == null) return;

            bool correcta = IntentarSincronizar(codigo, true);

            CargarEnlaces();
            CargarAuditoria();

            MessageBox.Show(correcta
                    ? $"El reintento de {codigo} fue exitoso.\nRuta: {ultimaRuta}"
                    : $"{codigo} sigue sin ruta hacia la central. Volvió al final de la cola.",
                "Reintento", MessageBoxButtons.OK, correcta ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Simula el envío de datos de una sucursal a la central.
        /// Con el grafo se busca la ruta más barata usando solo los enlaces disponibles (Floyd-Warshall):
        /// si existe, el envío es exitoso; si no hay ninguna ruta, la sucursal entra a la cola de reintento.
        /// </summary>
        private bool IntentarSincronizar(string codigo, bool esReintento)
        {
            string tipo = esReintento ? "Reintento" : "Sincronización";

            GrafoSucursales grafo = GrafoSucursales.Desde(Almacen.Enlaces.Cargar());
            grafo.CalcularFloydWarshall();
            ListaSimple<string> ruta = grafo.ObtenerRuta(codigo, CodigoCentral);

            if (!ruta.EstaVacia)
            {
                decimal costo = grafo.CostoRuta(codigo, CodigoCentral);
                ultimaRuta = TextoDeRuta(ruta);
                ServicioAdminGeneral.RegistrarAuditoria("SYNC_OK",
                    $"{tipo}: {codigo} → {CodigoCentral} por la ruta {ultimaRuta} (costo {costo:0.##})");
                return true;
            }

            ultimaRuta = "";
            if (!pendientes.Contains(codigo)) pendientes.Encolar(codigo);
            ServicioAdminGeneral.RegistrarAuditoria("SYNC_FALLIDA",
                $"{tipo}: {codigo} sin ruta disponible hacia {CodigoCentral}; queda en la cola de reintento");
            return false;
        }

        /// <summary>Convierte la ruta en un texto como "SUC-04 → SUC-02 → ADM-01".</summary>
        private static string TextoDeRuta(ListaSimple<string> ruta)
        {
            string texto = "";
            foreach (string codigo in ruta)
            {
                if (texto.Length > 0) texto = texto + " → ";
                texto = texto + codigo;
            }
            return texto;
        }
    }
}
