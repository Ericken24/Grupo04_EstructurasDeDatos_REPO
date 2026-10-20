using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    /// <summary>
    /// Punto de venta (solo rol Cajero).
    /// Estructuras: ListaSimple (catálogo, inventario y carrito), Pila (deshacer el último producto
    /// agregado) y Cola (poner la venta en espera, vía ServicioCajero).
    /// </summary>
    public partial class UC_NuevaVenta : UserControl
    {
        private ListaSimple<Producto> catalogo = new ListaSimple<Producto>();
        private ListaSimple<Inventario> inventario = new ListaSimple<Inventario>();
        private readonly ListaSimple<DetalleVenta> carrito = new ListaSimple<DetalleVenta>();
        private readonly Pila<DetalleVenta> productosAgregados = new Pila<DetalleVenta>();   // para "Deshacer último"
        private Usuario? cajero;

        public UC_NuevaVenta()
        {
            InitializeComponent();
        }

        private void UC_NuevaVenta_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!RestriccionCajero.Aplicar(this)) return;   // otro rol: no se carga nada

            cajero = ServicioCajero.CajeroActual;
            CargarDatos();
        }

        // ------------------------------------------------------------ Carga de datos

        private void CargarDatos()
        {
            catalogo = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar().Where(p => p.Activo));
            RecargarInventario();

            cboMetodoPago.DataSource = Almacen.MetodosPago.Cargar();   // el ComboBox muestra MetodoPago.ToString() = Nombre
            RefrescarCatalogo();
            RefrescarCarrito();
        }

        private void RecargarInventario()
        {
            inventario = ServicioCajero.InventarioDe(ServicioCajero.SucursalDe(cajero!));
        }

        private decimal StockDe(Producto producto)
        {
            int id = producto.ProductoId;
            return inventario.Buscar(i => i.ProductoId == id)?.StockActual ?? 0;
        }

        // ------------------------------------------------------------ Catálogo

        private void RefrescarCatalogo()
        {
            string filtro = txtBuscar.Text.Trim();
            ListaSimple<Producto> lista = filtro.Length == 0
                ? catalogo
                : catalogo.Filtrar(p =>
                    p.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    p.SKU.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    (p.CodigoBarras != null && p.CodigoBarras.Contains(filtro, StringComparison.OrdinalIgnoreCase)));

            dgvProductos.Rows.Clear();
            foreach (Producto p in lista)
            {
                decimal stock = StockDe(p);
                int fila = dgvProductos.Rows.Add(p.SKU, p.Nombre, p.UnidadMedida,
                                                 p.PrecioVenta.ToString("N2"),
                                                 p.ControlaStock ? stock.ToString("0.##") : "-");
                dgvProductos.Rows[fila].Tag = p;
                if (p.ControlaStock && stock <= 0)
                    dgvProductos.Rows[fila].DefaultCellStyle.ForeColor = Color.Gray;   // sin stock
            }
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            if (cajero != null) RefrescarCatalogo();
        }

        // ------------------------------------------------------------ Carrito

        private void RefrescarCarrito()
        {
            dgvCarrito.Rows.Clear();
            decimal total = 0;
            foreach (DetalleVenta d in carrito)
            {
                dgvCarrito.Rows.Add(d.Nombre, d.Cantidad.ToString("0.##"),
                                    d.PrecioUnitario.ToString("N2"), d.Importe.ToString("N2"));
                total += d.Importe;
            }
            lblTotal.Text = $"TOTAL:  S/ {total:N2}";
            btnCobrar.Enabled = !carrito.EstaVacia;
            btnEnEspera.Enabled = !carrito.EstaVacia;
            btnDeshacer.Enabled = !productosAgregados.EstaVacia;
            btnVaciar.Enabled = !carrito.EstaVacia;
        }

        private void AgregarSeleccionado()
        {
            if (dgvProductos.CurrentRow?.Tag is not Producto producto)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Punto de venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal cantidad = nudCantidad.Value;
            DetalleVenta? linea = carrito.Buscar(d => d.ProductoId == producto.ProductoId);
            decimal yaEnCarrito = linea?.Cantidad ?? 0;

            if (producto.ControlaStock && yaEnCarrito + cantidad > StockDe(producto))
            {
                MessageBox.Show($"Stock insuficiente de \"{producto.Nombre}\".\nDisponible: {StockDe(producto):0.##}   En el carrito: {yaEnCarrito:0.##}",
                    "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (producto.RequiereMayorEdad &&
                MessageBox.Show("Este producto solo se vende a mayores de edad.\n¿El cliente es mayor de edad?",
                    "Verificación de edad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (linea == null)
            {
                carrito.AgregarFinal(new DetalleVenta
                {
                    ProductoId = producto.ProductoId,
                    Nombre = producto.Nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.PrecioVenta
                });
            }
            else
            {
                linea.Cantidad += cantidad;
            }

            // La pila recuerda cada agregado para poder deshacerlo en orden inverso (LIFO)
            productosAgregados.Apilar(new DetalleVenta
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Cantidad = cantidad,
                PrecioUnitario = producto.PrecioVenta
            });

            nudCantidad.Value = 1;
            RefrescarCarrito();
        }

        private void btnAgregar_Click(object? sender, EventArgs e) => AgregarSeleccionado();

        private void dgvProductos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) AgregarSeleccionado();
        }

        private void btnDeshacer_Click(object? sender, EventArgs e)
        {
            DetalleVenta? ultimo = productosAgregados.Desapilar();
            if (ultimo == null) return;

            int productoId = ultimo.ProductoId;
            decimal cantidad = ultimo.Cantidad;
            DetalleVenta? linea = carrito.Buscar(d => d.ProductoId == productoId);
            if (linea != null)
            {
                linea.Cantidad -= cantidad;
                if (linea.Cantidad <= 0) carrito.Eliminar(d => d.ProductoId == productoId);
            }
            RefrescarCarrito();
        }

        private void btnVaciar_Click(object? sender, EventArgs e)
        {
            if (carrito.EstaVacia) return;
            if (MessageBox.Show("¿Vaciar todo el carrito?", "Punto de venta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            LimpiarVenta();
        }

        private void LimpiarVenta()
        {
            carrito.Limpiar();
            productosAgregados.Limpiar();
            txtReferencia.Clear();
            nudCantidad.Value = 1;
            RefrescarCarrito();
        }

        // ------------------------------------------------------------ Pago

        private void cboMetodoPago_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool requiere = cboMetodoPago.SelectedItem is MetodoPago m && m.RequiereReferencia;
            txtReferencia.Enabled = requiere;
            if (!requiere) txtReferencia.Clear();
        }

        private void btnCobrar_Click(object? sender, EventArgs e)
        {
            if (cajero == null || carrito.EstaVacia) return;

            if (cboMetodoPago.SelectedItem is not MetodoPago metodo)
            {
                MessageBox.Show("Seleccione el método de pago.", "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (metodo.RequiereReferencia && string.IsNullOrWhiteSpace(txtReferencia.Text))
            {
                MessageBox.Show($"Ingrese el número de operación de {metodo.Nombre}.", "Cobro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReferencia.Focus();
                return;
            }

            // El stock pudo cambiar desde que se armó el carrito (otro cajero, otra caja)
            string? error = ServicioCajero.ValidarStock(ServicioCajero.SucursalDe(cajero), carrito);
            if (error != null)
            {
                MessageBox.Show(error, "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RecargarInventario();
                RefrescarCatalogo();
                return;
            }

            Venta venta = ServicioCajero.ArmarVenta(cajero, carrito);
            ServicioCajero.RegistrarVentaPagada(venta, metodo, txtReferencia.Text, cajero);

            MessageBox.Show($"Venta registrada correctamente.\n\nCódigo: {venta.CodigoOperacion}\nTotal: S/ {venta.Total:N2}\nPago: {metodo.Nombre}",
                "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarVenta();
            RecargarInventario();
            RefrescarCatalogo();
        }

        private void btnEnEspera_Click(object? sender, EventArgs e)
        {
            if (cajero == null || carrito.EstaVacia) return;

            Venta venta = ServicioCajero.ArmarVenta(cajero, carrito);
            ServicioCajero.EncolarEnEspera(venta, cajero);   // entra al final de la Cola (FIFO)

            MessageBox.Show($"La venta quedó en espera.\n\nCódigo: {venta.CodigoOperacion}\nTotal: S/ {venta.Total:N2}\n\nPuede atenderla en \"Transacciones en espera\".",
                "Venta en espera", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarVenta();
        }
    }
}
