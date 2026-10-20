using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Inventario de todas las sucursales (solo rol Administrador general, solo lectura).
    /// Estructura: ListaSimple (filtrar por sucursal, categoría, texto y stock crítico).
    /// </summary>
    public partial class UC_InventarioGlobal : UserControl
    {
        /// <summary>Una fila de la tabla: el stock de un producto en una sucursal.</summary>
        private sealed class FilaInventario
        {
            public int SucursalId;
            public string Sucursal = "";
            public string Sku = "";
            public string Producto = "";
            public int CategoriaId;
            public string Categoria = "";
            public decimal Stock;
            public decimal Minimo;
            public decimal Valor;
            public string Estado = "OK";
            public bool EsCritico => Estado == "Agotado" || Estado == "Bajo mínimo";
        }

        private bool listo;   // evita cargar datos mientras se llenan los ComboBox

        public UC_InventarioGlobal()
        {
            InitializeComponent();
        }

        private void UC_InventarioGlobal_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            // El primer elemento (Id = 0) representa "todas": no filtra nada
            List<Sucursal> sucursales = new List<Sucursal> { new Sucursal { SucursalId = 0, Nombre = "Todas las sucursales" } };
            sucursales.AddRange(Almacen.Sucursales.Cargar().Where(s => s.Tipo == "TIENDA"));
            cboSucursal.DataSource = sucursales;

            List<Categoria> categorias = new List<Categoria> { new Categoria { CategoriaId = 0, Nombre = "Todas las categorías" } };
            categorias.AddRange(Almacen.Categorias.Cargar());
            cboCategoria.DataSource = categorias;

            listo = true;
            CargarInventario();
        }

        /// <summary>Un solo manejador para los 4 filtros (sucursal, categoría, texto y casilla de críticos).</summary>
        private void FiltroCambiado(object? sender, EventArgs e)
        {
            if (listo) CargarInventario();
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            if (listo) CargarInventario();
        }

        // ------------------------------------------------------------ Carga

        private void CargarInventario()
        {
            Dictionary<int, Sucursal> sucursales = Almacen.Sucursales.Cargar().ToDictionary(s => s.SucursalId);
            Dictionary<int, Producto> productos = Almacen.Productos.Cargar().ToDictionary(p => p.ProductoId);
            Dictionary<int, Categoria> categorias = Almacen.Categorias.Cargar().ToDictionary(c => c.CategoriaId);

            int sucursalId = (cboSucursal.SelectedItem as Sucursal)?.SucursalId ?? 0;
            int categoriaId = (cboCategoria.SelectedItem as Categoria)?.CategoriaId ?? 0;
            string texto = txtBuscar.Text.Trim();
            bool soloCriticos = chkSoloCriticos.Checked;

            // ListaSimple: primero se filtra el inventario por sucursal...
            ListaSimple<Inventario> inventario = ListaSimple<Inventario>.Desde(Almacen.Inventario.Cargar());
            if (sucursalId != 0) inventario = inventario.Filtrar(i => i.SucursalId == sucursalId);

            // ...se arma una fila por cada existencia (uniendo producto, categoría y sucursal)...
            ListaSimple<FilaInventario> filas = new ListaSimple<FilaInventario>();
            foreach (Inventario existencia in inventario)
            {
                if (!productos.TryGetValue(existencia.ProductoId, out Producto? producto)) continue;
                if (!sucursales.TryGetValue(existencia.SucursalId, out Sucursal? sucursal)) continue;

                string estado = "OK";
                if (!producto.ControlaStock) estado = "Sin control";
                else if (existencia.StockActual <= 0) estado = "Agotado";
                else if (existencia.StockActual < producto.StockMinimo) estado = "Bajo mínimo";

                filas.AgregarFinal(new FilaInventario
                {
                    SucursalId = sucursal.SucursalId,
                    Sucursal = sucursal.Nombre,
                    Sku = producto.SKU,
                    Producto = producto.Nombre,
                    CategoriaId = producto.CategoriaId,
                    Categoria = categorias.TryGetValue(producto.CategoriaId, out Categoria? categoria) ? categoria.Nombre : "-",
                    Stock = existencia.StockActual,
                    Minimo = producto.StockMinimo,
                    Valor = existencia.StockActual * producto.PrecioCompra,
                    Estado = estado
                });
            }

            // ...y por último se filtra por categoría, texto y críticos
            filas = filas.Filtrar(f =>
                (categoriaId == 0 || f.CategoriaId == categoriaId) &&
                (texto.Length == 0 ||
                    f.Producto.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    f.Sku.Contains(texto, StringComparison.OrdinalIgnoreCase)) &&
                (!soloCriticos || f.EsCritico));

            dgvInventario.Rows.Clear();
            decimal valorTotal = 0;
            int criticos = 0;
            foreach (FilaInventario f in filas.OrderBy(x => x.SucursalId).ThenBy(x => x.Producto))
            {
                int fila = dgvInventario.Rows.Add(f.Sucursal, f.Sku, f.Producto, f.Categoria,
                                                  f.Stock.ToString("0.##"), f.Minimo.ToString("0.##"),
                                                  f.Estado, f.Valor.ToString("N2"));
                if (f.EsCritico)
                {
                    dgvInventario.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
                    criticos++;
                }
                valorTotal += f.Valor;
            }

            lblResumen.Text = $"Registros: {filas.Cantidad}   ·   Críticos: {criticos}   ·   Valor del inventario: S/ {valorTotal:N2}";
        }
    }
}
