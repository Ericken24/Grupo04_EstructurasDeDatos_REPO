using System.Globalization;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Catálogo de categorías y productos de toda la red (solo rol Administrador general).
    /// Estructura: ListaSimple (cargar el catálogo, buscar la selección y filtrar los productos de una categoría).
    /// Cada cambio se guarda en el JSON y queda registrado en la auditoría.
    /// </summary>
    public partial class UC_ProductosCategorias : UserControl
    {
        private ListaSimple<Categoria> categorias = new ListaSimple<Categoria>();
        private ListaSimple<Producto> productos = new ListaSimple<Producto>();
        private Categoria? categoriaSeleccionada;
        private Producto? productoSeleccionado;
        private bool sincronizando;       // evita que los grids se llamen entre sí en bucle

        public UC_ProductosCategorias()
        {
            InitializeComponent();
        }

        private void UC_ProductosCategorias_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            CargarCatalogo();
        }

        // ------------------------------------------------------------ Carga

        private void CargarCatalogo(int categoriaId = 0, int productoId = 0)
        {
            categorias = ListaSimple<Categoria>.Desde(Almacen.Categorias.Cargar());
            productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar());

            sincronizando = true;
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (Categoria c in categorias)
                {
                    int fila = dgvCategorias.Rows.Add(c.Nombre, c.Activa ? "Sí" : "No");
                    dgvCategorias.Rows[fila].Tag = c;
                    if (!c.Activa) dgvCategorias.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
                }
                SeleccionarPorTag(dgvCategorias, tag => tag is Categoria actual && actual.CategoriaId == categoriaId);
            }
            finally
            {
                sincronizando = false;
            }

            categoriaSeleccionada = ObtenerCategoriaSeleccionada();
            MostrarCategoria();
            CargarProductos(productoId);
        }

        private void CargarProductos(int productoId = 0)
        {
            sincronizando = true;
            try
            {
                dgvProductos.Rows.Clear();
                if (categoriaSeleccionada != null)
                {
                    int categoriaId = categoriaSeleccionada.CategoriaId;
                    foreach (Producto p in productos.Filtrar(x => x.CategoriaId == categoriaId))
                    {
                        int fila = dgvProductos.Rows.Add(p.SKU, p.Nombre, p.PrecioCompra.ToString("N2"),
                                                         p.PrecioVenta.ToString("N2"), p.StockMinimo.ToString("0.##"),
                                                         p.Activo ? "Sí" : "No");
                        dgvProductos.Rows[fila].Tag = p;
                        if (!p.Activo) dgvProductos.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;
                    }
                }
                SeleccionarPorTag(dgvProductos, tag => tag is Producto actual && actual.ProductoId == productoId);
            }
            finally
            {
                sincronizando = false;
            }

            productoSeleccionado = ObtenerProductoSeleccionado();
            MostrarProducto();
        }

        /// <summary>Selecciona la fila cuyo Tag cumple la condición; si no hay, la primera.</summary>
        private static void SeleccionarPorTag(DataGridView grid, Func<object?, bool> coincide)
        {
            grid.ClearSelection();
            if (grid.Rows.Count == 0) return;

            DataGridViewRow destino = grid.Rows.Cast<DataGridViewRow>().FirstOrDefault(f => coincide(f.Tag)) ?? grid.Rows[0];
            destino.Selected = true;
            grid.CurrentCell = destino.Cells[0];
        }

        private Categoria? ObtenerCategoriaSeleccionada() =>
            dgvCategorias.SelectedRows.Count > 0 ? dgvCategorias.SelectedRows[0].Tag as Categoria : null;

        private Producto? ObtenerProductoSeleccionado() =>
            dgvProductos.SelectedRows.Count > 0 ? dgvProductos.SelectedRows[0].Tag as Producto : null;

        // ------------------------------------------------------------ Selección

        private void dgvCategorias_SelectionChanged(object? sender, EventArgs e)
        {
            if (sincronizando) return;

            categoriaSeleccionada = ObtenerCategoriaSeleccionada();
            MostrarCategoria();
            CargarProductos();
        }

        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            if (sincronizando) return;

            productoSeleccionado = ObtenerProductoSeleccionado();
            MostrarProducto();
        }

        private void MostrarCategoria()
        {
            if (categoriaSeleccionada == null)
            {
                txtCatNombre.Clear();
                txtCatDescripcion.Clear();
                chkCatActiva.Checked = true;
                return;
            }

            txtCatNombre.Text = categoriaSeleccionada.Nombre;
            txtCatDescripcion.Text = categoriaSeleccionada.Descripcion;
            chkCatActiva.Checked = categoriaSeleccionada.Activa;
        }

        private void MostrarProducto()
        {
            bool hay = productoSeleccionado != null;
            btnGuardarProducto.Enabled = hay;
            txtPrecioCompra.Enabled = txtPrecioVenta.Enabled = txtStockMinimo.Enabled = chkProdActivo.Enabled = hay;

            if (productoSeleccionado == null)
            {
                lblProductoSel.Text = "Seleccione un producto";
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
                txtStockMinimo.Clear();
                chkProdActivo.Checked = false;
                lblMargen.Text = "Margen bruto: -";
                return;
            }

            Producto p = productoSeleccionado;
            lblProductoSel.Text = $"{p.SKU}  ·  {p.Nombre}";
            txtPrecioCompra.Text = p.PrecioCompra.ToString("0.00");
            txtPrecioVenta.Text = p.PrecioVenta.ToString("0.00");
            txtStockMinimo.Text = p.StockMinimo.ToString("0.##");
            chkProdActivo.Checked = p.Activo;
            lblMargen.Text = p.PrecioVenta > 0
                ? $"Margen bruto: {(p.PrecioVenta - p.PrecioCompra) / p.PrecioVenta:P1}   (el precio de venta incluye IGV 18%)"
                : "Margen bruto: -";
        }

        // ------------------------------------------------------------ Categorías

        private void btnNuevaCategoria_Click(object? sender, EventArgs e)
        {
            sincronizando = true;
            try
            {
                dgvCategorias.ClearSelection();
                dgvProductos.Rows.Clear();
            }
            finally
            {
                sincronizando = false;
            }

            categoriaSeleccionada = null;
            productoSeleccionado = null;
            MostrarCategoria();
            MostrarProducto();
            txtCatNombre.Focus();
        }

        private void btnGuardarCategoria_Click(object? sender, EventArgs e)
        {
            string nombre = txtCatNombre.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Ingrese el nombre de la categoría.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCatNombre.Focus();
                return;
            }

            List<Categoria> todas = Almacen.Categorias.Cargar();
            int idActual = categoriaSeleccionada?.CategoriaId ?? 0;

            if (todas.Any(c => c.CategoriaId != idActual && c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Ya existe una categoría llamada \"{nombre}\".", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatNombre.Focus();
                return;
            }

            Categoria? registro;
            string accion;
            if (idActual == 0)
            {
                registro = new Categoria { CategoriaId = RepositorioJson<Categoria>.SiguienteId(todas.Select(c => c.CategoriaId)) };
                todas.Add(registro);
                accion = "CATEGORIA_CREADA";
            }
            else
            {
                registro = todas.FirstOrDefault(c => c.CategoriaId == idActual);
                accion = "CATEGORIA_EDITADA";
            }
            if (registro == null) return;

            registro.Nombre = nombre;
            registro.Descripcion = txtCatDescripcion.Text.Trim();
            registro.Activa = chkCatActiva.Checked;
            Almacen.Categorias.Guardar(todas);

            ServicioAdminGeneral.RegistrarAuditoria(accion,
                $"{registro.Nombre} (activa: {(registro.Activa ? "sí" : "no")})");

            CargarCatalogo(registro.CategoriaId);
            MessageBox.Show("Categoría guardada correctamente.", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ------------------------------------------------------------ Productos

        private static bool TryDecimal(string texto, out decimal valor) =>
            decimal.TryParse(texto.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out valor) && valor >= 0;

        private void btnGuardarProducto_Click(object? sender, EventArgs e)
        {
            if (productoSeleccionado == null) return;
            int productoId = productoSeleccionado.ProductoId;

            if (!TryDecimal(txtPrecioCompra.Text, out decimal precioCompra) ||
                !TryDecimal(txtPrecioVenta.Text, out decimal precioVenta) ||
                !TryDecimal(txtStockMinimo.Text, out decimal stockMinimo))
            {
                MessageBox.Show("Ingrese valores numéricos válidos (mayores o iguales a 0).", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (precioVenta < precioCompra &&
                MessageBox.Show("El precio de venta es menor que el precio de compra.\n¿Guardar de todos modos?",
                    "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            List<Producto> todos = Almacen.Productos.Cargar();
            Producto? registro = todos.FirstOrDefault(p => p.ProductoId == productoId);
            if (registro == null) return;

            registro.PrecioCompra = precioCompra;
            registro.PrecioVenta = precioVenta;
            registro.StockMinimo = stockMinimo;
            registro.Activo = chkProdActivo.Checked;
            Almacen.Productos.Guardar(todos);

            ServicioAdminGeneral.RegistrarAuditoria("PRODUCTO_EDITADO",
                $"{registro.SKU} · {registro.Nombre}: compra S/ {precioCompra:N2}, venta S/ {precioVenta:N2}, " +
                $"mínimo {stockMinimo:0.##}, activo: {(registro.Activo ? "sí" : "no")}");

            CargarCatalogo(registro.CategoriaId, registro.ProductoId);
            MessageBox.Show("Producto guardado correctamente.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
