using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Auditoría de eventos y sincronización entre sucursales (solo rol Administrador general).
    /// Estructuras: ListaSimple (cargar y filtrar eventos y enlaces),
    /// ListaCircular (rotar el turno de sincronización entre las sucursales, volviendo al inicio al terminar)
    /// y Cola (las sucursales sin conectividad esperan su reintento en orden de llegada).
    /// </summary>
    public partial class UC_AuditoriaSincronizacion : UserControl
    {
        private const int MaximoEventos = 500;

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

            rotacion = new ListaCircular<string>();
            foreach (EnlaceSync enlace in Almacen.Enlaces.Cargar())
                rotacion.Agregar(enlace.Origen);

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

            // ListaSimple: del evento más reciente al más antiguo, filtrado por texto
            ListaSimple<Auditoria> eventos = ListaSimple<Auditoria>.Desde(
                Almacen.Auditoria.Cargar().OrderByDescending(a => a.FechaEvento));
            if (texto.Length > 0)
            {
                eventos = eventos.Filtrar(a =>
                    a.Accion.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    a.Detalle.Contains(texto, StringComparison.OrdinalIgnoreCase));
            }

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

            lblEstadoSync.Text = $"Enlaces disponibles: {disponibles} de {enlaces.Cantidad}";
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
                    ? $"{codigo} se sincronizó correctamente."
                    : $"{codigo} no tiene conectividad. Quedó en la cola de reintento.",
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
                    ? $"El reintento de {codigo} fue exitoso."
                    : $"{codigo} sigue sin conectividad. Volvió al final de la cola.",
                "Reintento", MessageBoxButtons.OK, correcta ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private bool IntentarSincronizar(string codigo, bool esReintento)
        {
            EnlaceSync? enlace = Almacen.Enlaces.Cargar().FirstOrDefault(x => x.Origen == codigo);
            string tipo = esReintento ? "Reintento" : "Sincronización";

            if (enlace != null && enlace.Disponible)
            {
                ServicioAdminGeneral.RegistrarAuditoria("SYNC_OK",
                    $"{tipo}: {enlace.Origen} → {enlace.Destino} sincronizado (costo {enlace.Costo:0.##})");
                return true;
            }

            if (!pendientes.Contains(codigo)) pendientes.Encolar(codigo);
            ServicioAdminGeneral.RegistrarAuditoria("SYNC_FALLIDA",
                $"{tipo}: {codigo} sin conectividad; queda en la cola de reintento");
            return false;
        }
    }
}
