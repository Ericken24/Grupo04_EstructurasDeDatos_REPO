using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Stock de la sucursal con búsqueda, filtros y ajuste manual.
    /// Estructuras: ListaSimple (catálogos y stock de la sucursal) y Pila (deshacer el último ajuste: LIFO).
    /// </summary>
    public partial class UC_Inventario : UserControl
    {
        private class AjusteStock
        {
            public int ProductoId;
            public string Nombre = "";
            public decimal Anterior;
            public decimal Nuevo;
        }

        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private ListaSimple<Producto> productos = new ListaSimple<Producto>();
        private ListaSimple<Categoria> categorias = new ListaSimple<Categoria>();
        private ListaSimple<Proveedor> proveedores = new ListaSimple<Proveedor>();
        private ListaSimple<Inventario> stockSucursal = new ListaSimple<Inventario>();
        private readonly Pila<AjusteStock> ajustes = new Pila<AjusteStock>();
        private bool cargando;

        public UC_Inventario()
        {
            InitializeComponent();
            txtBuscar.TextChanged += (s, e) => Refrescar();
            cmbCategoria.SelectedIndexChanged += (s, e) => Refrescar();
            chkSoloBajo.CheckedChanged += (s, e) => Refrescar();
            btnLimpiar.Click += (s, e) => { txtBuscar.Clear(); chkSoloBajo.Checked = false; cmbCategoria.SelectedIndex = 0; };
            dgvInventario.SelectionChanged += (s, e) => { if (!cargando) MostrarSeleccion(); };
            btnAplicar.Click += (s, e) => AplicarAjuste();
            btnDeshacer.Click += (s, e) => DeshacerAjuste();
            Load += (s, e) => { if (!DesignMode) Iniciar(); };
        }

        private static void Avisar(string mensaje, MessageBoxIcon icono = MessageBoxIcon.Information)
            => MessageBox.Show(mensaje, "Inventario", MessageBoxButtons.OK, icono);

        private void Iniciar()
        {
            lblSubtitulo.Text = Sesion.Actual?.NombreSucursal ?? "";
            productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar());
            categorias = ListaSimple<Categoria>.Desde(Almacen.Categorias.Cargar());
            proveedores = ListaSimple<Proveedor>.Desde(Almacen.Proveedores.Cargar());

            cargando = true;
            cmbCategoria.Items.Add("Todas las categorías");
            foreach (Categoria c in categorias) if (c.Activa) cmbCategoria.Items.Add(c);
            cmbCategoria.SelectedIndex = 0;
            cargando = false;

            CargarGrilla();
            ActualizarPila();
        }

        private void Refrescar() { if (!cargando) CargarGrilla(); }

        private decimal StockDe(int productoId)
            => stockSucursal.Buscar(i => i.ProductoId == productoId)?.StockActual ?? 0;

        private static string EstadoStock(Producto p, decimal stock)
        {
            if (!p.ControlaStock) return "N/A";
            if (stock <= 0) return "AGOTADO";
            return stock <= p.StockMinimo ? "BAJO" : "OK";
        }

        private void CargarGrilla()
        {
            cargando = true;
            stockSucursal = ListaSimple<Inventario>.Desde(Almacen.Inventario.Cargar()).Filtrar(i => i.SucursalId == sucursalId);

            string texto = txtBuscar.Text.Trim();
            int? categoriaId = (cmbCategoria.SelectedItem as Categoria)?.CategoriaId;
            int? seleccionado = (dgvInventario.CurrentRow?.Tag as Producto)?.ProductoId;
            int filaSeleccionada = -1, bajos = 0;

            dgvInventario.Rows.Clear();
            foreach (Producto p in productos)
            {
                if (!p.Activo) continue;
                if (categoriaId != null && p.CategoriaId != categoriaId) continue;
                if (texto.Length > 0 && !p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)
                                     && !p.SKU.Contains(texto, StringComparison.OrdinalIgnoreCase)) continue;

                decimal stock = StockDe(p.ProductoId);
                string estado = EstadoStock(p, stock);
                bool critico = estado == "BAJO" || estado == "AGOTADO";
                if (chkSoloBajo.Checked && !critico) continue;
                if (critico) bajos++;

                int fila = dgvInventario.Rows.Add(p.SKU, p.Nombre,
                    categorias.Buscar(c => c.CategoriaId == p.CategoriaId)?.Nombre ?? "-",
                    proveedores.Buscar(x => x.ProveedorId == p.ProveedorId)?.RazonSocial ?? "-",
                    p.UnidadMedida, stock, p.StockMinimo, p.PrecioVenta, estado);
                dgvInventario.Rows[fila].Tag = p;
                if (estado == "AGOTADO") dgvInventario.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
                else if (estado == "BAJO") dgvInventario.Rows[fila].DefaultCellStyle.ForeColor = Color.DarkOrange;
                if (p.ProductoId == seleccionado) filaSeleccionada = fila;
            }

            if (dgvInventario.Rows.Count > 0)
                dgvInventario.CurrentCell = dgvInventario.Rows[filaSeleccionada >= 0 ? filaSeleccionada : 0].Cells[0];
            lblConteo.Text = $"{dgvInventario.Rows.Count} productos · {bajos} críticos";
            cargando = false;
            MostrarSeleccion();
        }

        private void MostrarSeleccion()
        {
            if (dgvInventario.CurrentRow?.Tag is Producto p)
            {
                lblProductoSel.Text = $"{p.SKU} · {p.Nombre}";
                nudNuevoStock.Value = Math.Clamp(StockDe(p.ProductoId), nudNuevoStock.Minimum, nudNuevoStock.Maximum);
                nudNuevoStock.Enabled = btnAplicar.Enabled = p.ControlaStock;
            }
            else
            {
                lblProductoSel.Text = "Seleccione un producto de la tabla";
                nudNuevoStock.Value = 0;
                nudNuevoStock.Enabled = btnAplicar.Enabled = false;
            }
        }

        private void AplicarAjuste()
        {
            if (dgvInventario.CurrentRow?.Tag is not Producto p) { Avisar("Seleccione un producto de la tabla.", MessageBoxIcon.Warning); return; }
            string motivo = txtMotivo.Text.Trim();
            if (motivo.Length < 3) { Avisar("Indique el motivo del ajuste.", MessageBoxIcon.Warning); txtMotivo.Focus(); return; }

            decimal nuevo = nudNuevoStock.Value;
            decimal anterior = FijarStock(p.ProductoId, nuevo);
            if (anterior == nuevo) { Avisar("El stock ya tiene ese valor."); return; }

            ajustes.Apilar(new AjusteStock { ProductoId = p.ProductoId, Nombre = p.Nombre, Anterior = anterior, Nuevo = nuevo });   // Pila: el último ajuste queda en el tope
            Auditar("AJUSTE_STOCK", $"{p.SKU}: {anterior:0.##} -> {nuevo:0.##}. Motivo: {motivo}");
            txtMotivo.Clear();
            CargarGrilla();
            ActualizarPila();
        }

        private void DeshacerAjuste()
        {
            AjusteStock? ultimo = ajustes.Desapilar();        // LIFO: sale el ajuste más reciente
            if (ultimo == null) { Avisar("No hay ajustes para deshacer en esta sesión."); return; }

            FijarStock(ultimo.ProductoId, ultimo.Anterior);
            Auditar("REVERTIR_AJUSTE", $"{ultimo.Nombre}: {ultimo.Nuevo:0.##} -> {ultimo.Anterior:0.##}");
            CargarGrilla();
            ActualizarPila();
        }

        /// <summary>Escribe el stock en el JSON (leyendo primero lo más reciente) y devuelve el valor anterior.</summary>
        private decimal FijarStock(int productoId, decimal nuevo)
        {
            List<Inventario> todos = Almacen.Inventario.Cargar();
            Inventario? registro = todos.FirstOrDefault(i => i.SucursalId == sucursalId && i.ProductoId == productoId);
            decimal anterior = registro?.StockActual ?? 0;
            if (registro == null) todos.Add(new Inventario { SucursalId = sucursalId, ProductoId = productoId, StockActual = nuevo });
            else registro.StockActual = nuevo;
            Almacen.Inventario.Guardar(todos);
            return anterior;
        }

        private void ActualizarPila()
        {
            AjusteStock? cima = ajustes.Cima();
            lblPila.Text = cima == null
                ? "Ajustes en pila: 0"
                : $"Ajustes en pila: {ajustes.Cantidad} · último: {cima.Nombre} ({cima.Anterior:0.##} -> {cima.Nuevo:0.##})";
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
