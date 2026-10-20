using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Registro y control de gastos operativos de la sucursal.
    /// Estructuras: ListaSimple (filtrar por fechas/categoría), ListaDoble (lo más reciente primero)
    /// y Pila (deshacer el último gasto registrado: LIFO).
    /// </summary>
    public partial class UC_Gastos : UserControl
    {
        private static readonly string[] Categorias =
        {
            "Alquiler", "Servicios (luz, agua, internet)", "Sueldos y planilla", "Mantenimiento",
            "Limpieza", "Transporte y delivery", "Publicidad", "Impuestos", "Otros"
        };

        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private readonly Pila<Gasto> recientes = new Pila<Gasto>();     // gastos registrados en esta sesión
        private bool cargando = true;

        public UC_Gastos()
        {
            InitializeComponent();
            cmbCategoria.Items.AddRange(Categorias);
            cmbCategoria.SelectedIndex = 0;
            cmbFiltroCategoria.Items.Add("Todas las categorías");
            cmbFiltroCategoria.Items.AddRange(Categorias);
            cmbFiltroCategoria.SelectedIndex = 0;
            DateTime hoy = DateTime.Today;
            dtpDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpHasta.Value = hoy;

            btnRegistrar.Click += (s, e) => RegistrarGasto();
            btnDeshacer.Click += (s, e) => DeshacerUltimo();
            btnAnular.Click += (s, e) => AnularSeleccionado();
            dtpDesde.ValueChanged += (s, e) => Refrescar();
            dtpHasta.ValueChanged += (s, e) => Refrescar();
            cmbFiltroCategoria.SelectedIndexChanged += (s, e) => Refrescar();
            chkAnulados.CheckedChanged += (s, e) => Refrescar();
            Load += (s, e) => { if (DesignMode) return; lblSubtitulo.Text = Sesion.Actual?.NombreSucursal ?? ""; cargando = false; Refrescar(); ActualizarUltimo(); };
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");
        private static void Avisar(string mensaje, MessageBoxIcon icono = MessageBoxIcon.Information)
            => MessageBox.Show(mensaje, "Gastos", MessageBoxButtons.OK, icono);

        private void RegistrarGasto()
        {
            string descripcion = txtDescripcion.Text.Trim();
            if (descripcion.Length < 3) { Avisar("Escriba una descripción para el gasto.", MessageBoxIcon.Warning); txtDescripcion.Focus(); return; }
            if (nudMonto.Value <= 0) { Avisar("El monto debe ser mayor que 0.", MessageBoxIcon.Warning); nudMonto.Focus(); return; }

            List<Gasto> todos = Almacen.Gastos.Cargar();
            Gasto gasto = new Gasto
            {
                GastoId = RepositorioJson<Gasto>.SiguienteId(todos.Select(g => g.GastoId)),
                SucursalId = sucursalId,
                UsuarioId = Sesion.Actual?.UsuarioId ?? 0,
                CategoriaGasto = (string)cmbCategoria.SelectedItem!,
                Descripcion = descripcion,
                Monto = nudMonto.Value,
                FechaGasto = dtpFecha.Value.Date.Add(DateTime.Now.TimeOfDay),
                Estado = "REGISTRADO"
            };
            todos.Add(gasto);
            Almacen.Gastos.Guardar(todos);
            recientes.Apilar(gasto);                 // Pila: el último gasto queda en el tope
            Auditar("REGISTRAR_GASTO", $"{gasto.CategoriaGasto}: {gasto.Descripcion} ({Soles(gasto.Monto)})");

            txtDescripcion.Clear();
            nudMonto.Value = 0;
            Refrescar();
            ActualizarUltimo();
        }

        private void DeshacerUltimo()
        {
            Gasto? ultimo = recientes.Desapilar();   // LIFO: sale el último registrado
            if (ultimo == null) { Avisar("No hay gastos registrados en esta sesión para deshacer."); return; }
            if (!CambiarEstado(ultimo.GastoId, "ANULADO")) Avisar("Ese gasto ya estaba anulado.");
            Refrescar();
            ActualizarUltimo();
        }

        private void AnularSeleccionado()
        {
            if (dgvGastos.CurrentRow?.Tag is not Gasto sel) { Avisar("Seleccione un gasto de la tabla.", MessageBoxIcon.Warning); return; }
            if (sel.Estado == "ANULADO") { Avisar("Ese gasto ya está anulado."); return; }
            if (MessageBox.Show($"¿Anular el gasto \"{sel.Descripcion}\" por {Soles(sel.Monto)}?", "Anular gasto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            CambiarEstado(sel.GastoId, "ANULADO");
            Refrescar();
        }

        /// <summary>Cambia el estado en el JSON. Devuelve false si el gasto no existe o ya tenía ese estado.</summary>
        private bool CambiarEstado(int gastoId, string estado)
        {
            List<Gasto> todos = Almacen.Gastos.Cargar();
            Gasto? gasto = todos.FirstOrDefault(g => g.GastoId == gastoId);
            if (gasto == null || gasto.Estado == estado) return false;
            gasto.Estado = estado;
            Almacen.Gastos.Guardar(todos);
            Auditar("ANULAR_GASTO", $"{gasto.CategoriaGasto}: {gasto.Descripcion} ({Soles(gasto.Monto)})");
            return true;
        }

        private void Refrescar()
        {
            if (cargando) return;
            ListaSimple<Gasto> gastos = ListaSimple<Gasto>.Desde(Almacen.Gastos.Cargar()).Filtrar(g => g.SucursalId == sucursalId);

            DateTime desde = dtpDesde.Value.Date, hasta = dtpHasta.Value.Date.AddDays(1);
            string? categoria = cmbFiltroCategoria.SelectedIndex > 0 ? (string?)cmbFiltroCategoria.SelectedItem : null;
            bool verAnulados = chkAnulados.Checked;

            ListaSimple<Gasto> filtrados = gastos.Filtrar(g => g.FechaGasto >= desde && g.FechaGasto < hasta
                && (categoria == null || g.CategoriaGasto == categoria)
                && (verAnulados || g.Estado == "REGISTRADO"));

            decimal total = 0;
            Dictionary<string, decimal> porCategoria = new Dictionary<string, decimal>();
            dgvGastos.Rows.Clear();
            foreach (Gasto g in ListaDoble<Gasto>.Desde(filtrados).RecorrerAlReves())      // lo más reciente primero
            {
                int fila = dgvGastos.Rows.Add(g.FechaGasto.ToString("dd/MM/yyyy"), g.CategoriaGasto, g.Descripcion, g.Monto, g.Estado);
                dgvGastos.Rows[fila].Tag = g;
                if (g.Estado == "ANULADO") { dgvGastos.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray; continue; }
                total += g.Monto;
                porCategoria[g.CategoriaGasto] = porCategoria.GetValueOrDefault(g.CategoriaGasto) + g.Monto;
            }

            dgvPorCategoria.Rows.Clear();
            foreach (KeyValuePair<string, decimal> par in porCategoria.OrderByDescending(p => p.Value))
                dgvPorCategoria.Rows.Add(par.Key, par.Value);
            lblTotal.Text = "Total: " + Soles(total);
        }

        private void ActualizarUltimo()
        {
            Gasto? cima = recientes.Cima();
            lblUltimo.Text = cima == null
                ? "Ningún gasto registrado en esta sesión"
                : $"Último registrado: {cima.CategoriaGasto} · {Soles(cima.Monto)} (en pila: {recientes.Cantidad})";
            btnDeshacer.Enabled = cima != null;
        }

        private void Auditar(string accion, string detalle)
        {
            List<Auditoria> log = Almacen.Auditoria.Cargar();
            log.Add(new Auditoria
            {
                AuditoriaId = RepositorioJson<Auditoria>.SiguienteId(log.Select(a => a.AuditoriaId)),
                UsuarioId = Sesion.Actual?.UsuarioId,
                SucursalId = sucursalId,
                Accion = accion,
                Detalle = detalle
            });
            Almacen.Auditoria.Guardar(log);
        }
    }
}
