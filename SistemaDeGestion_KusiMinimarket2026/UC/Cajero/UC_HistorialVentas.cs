using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    /// <summary>
    /// Historial de ventas del cajero (solo rol Cajero).
    /// Estructuras: ListaDoble (navegar Primera / Anterior / Siguiente / Última con un cursor)
    /// y Pila (la última venta es el tope: es la única que se puede anular).
    /// </summary>
    public partial class UC_HistorialVentas : UserControl
    {
        private ListaDoble<Venta> historial = new ListaDoble<Venta>();
        private List<MetodoPago> metodos = new List<MetodoPago>();
        private Usuario? cajero;
        private int indice;               // posición del cursor de la lista (0 = venta más reciente)
        private bool sincronizando;       // evita que el grid y los botones se llamen entre sí en bucle

        public UC_HistorialVentas()
        {
            InitializeComponent();
        }

        private void UC_HistorialVentas_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!RestriccionCajero.Aplicar(this)) return;   // otro rol: no se carga nada

            cajero = Sesion.Actual;
            if (cajero?.Rol != RolUsuario.Cajero || cajero.SucursalId == null) return;
            metodos = Almacen.MetodosPago.Cargar();
            CargarHistorial();
        }

        // ------------------------------------------------------------ Carga

        private string NombreMetodo(int metodoPagoId)
        {
            MetodoPago? metodo = metodos.FirstOrDefault(m => m.MetodoPagoId == metodoPagoId);
            return metodo?.Nombre ?? "-";
        }

        private void CargarHistorial()
        {
            Usuario actual = cajero!;
            int sucursalId = actual.SucursalId!.Value;
            string filtro = txtBuscar.Text.Trim();

            // Solo las ventas de este cajero en su sucursal, de la más reciente a la más antigua
            IEnumerable<Venta> ventas = Almacen.Ventas.Cargar()
                .Where(v => v.SucursalId == sucursalId && v.UsuarioId == actual.UsuarioId && v.Estado != "EN_ESPERA")
                .Where(v => filtro.Length == 0 || v.CodigoOperacion.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(v => v.FechaVenta);

            historial = ListaDoble<Venta>.Desde(ventas);

            sincronizando = true;
            try
            {
                dgvVentas.Rows.Clear();
                foreach (Venta v in historial)
                {
                    int fila = dgvVentas.Rows.Add(v.CodigoOperacion, v.FechaVenta.ToString("dd/MM/yyyy HH:mm"),
                                                  NombreMetodo(v.MetodoPagoId), v.Estado, v.Total.ToString("N2"));
                    if (v.Estado == "ANULADA") dgvVentas.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
                }
            }
            finally
            {
                sincronizando = false;
            }

            historial.IrAlInicio();
            indice = 0;
            SeleccionarFila(0);
            MostrarActual();
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            if (cajero != null) CargarHistorial();
        }

        // ------------------------------------------------------------ Cursor de la lista doble

        private void SeleccionarFila(int fila)
        {
            if (fila < 0 || fila >= dgvVentas.Rows.Count) return;

            sincronizando = true;
            try
            {
                dgvVentas.ClearSelection();
                dgvVentas.Rows[fila].Selected = true;
                dgvVentas.CurrentCell = dgvVentas.Rows[fila].Cells[0];
            }
            finally
            {
                sincronizando = false;
            }
        }

        /// <summary>El usuario hizo clic en una fila: se lleva el cursor de la lista hasta esa posición.</summary>
        private void dgvVentas_SelectionChanged(object? sender, EventArgs e)
        {
            if (sincronizando || dgvVentas.CurrentRow == null) return;

            int fila = dgvVentas.CurrentRow.Index;
            historial.IrAlInicio();
            for (int i = 0; i < fila; i++) historial.IrSiguiente();
            indice = fila;
            MostrarActual();
        }

        private void btnPrimera_Click(object? sender, EventArgs e)
        {
            historial.IrAlInicio();
            indice = 0;
            SeleccionarFila(indice);
            MostrarActual();
        }

        private void btnAnterior_Click(object? sender, EventArgs e)
        {
            if (historial.IrAnterior()) indice--;
            SeleccionarFila(indice);
            MostrarActual();
        }

        private void btnSiguiente_Click(object? sender, EventArgs e)
        {
            if (historial.IrSiguiente()) indice++;
            SeleccionarFila(indice);
            MostrarActual();
        }

        private void btnUltima_Click(object? sender, EventArgs e)
        {
            historial.IrAlFinal();
            indice = Math.Max(0, historial.Cantidad - 1);
            SeleccionarFila(indice);
            MostrarActual();
        }

        // ------------------------------------------------------------ Detalle de la venta actual

        private void MostrarActual()
        {
            Venta? venta = historial.DatoActual;
            dgvDetalle.Rows.Clear();

            if (venta == null)
            {
                lblCodigo.Text = lblFecha.Text = lblMetodo.Text = lblEstado.Text = "-";
                lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
                lblPosicion.Text = "Sin ventas";
                btnPrimera.Enabled = btnAnterior.Enabled = btnSiguiente.Enabled = btnUltima.Enabled = false;
                return;
            }

            lblCodigo.Text = venta.CodigoOperacion;
            lblFecha.Text = venta.FechaVenta.ToString("dd/MM/yyyy HH:mm");
            lblMetodo.Text = NombreMetodo(venta.MetodoPagoId) +
                             (string.IsNullOrWhiteSpace(venta.Referencia) ? "" : $"  (Op. {venta.Referencia})");
            lblEstado.Text = venta.Estado;
            lblEstado.ForeColor = venta.Estado == "ANULADA" ? Color.Brown : Color.Black;

            foreach (DetalleVenta d in venta.Detalles)
                dgvDetalle.Rows.Add(d.Nombre, d.Cantidad.ToString("0.##"), d.PrecioUnitario.ToString("N2"), d.Importe.ToString("N2"));

            lblTotalDetalle.Text = $"TOTAL:  S/ {venta.Total:N2}";
            lblPosicion.Text = $"Venta {indice + 1} de {historial.Cantidad}";

            btnPrimera.Enabled = btnAnterior.Enabled = historial.TieneAnterior;
            btnSiguiente.Enabled = btnUltima.Enabled = historial.TieneSiguiente;
        }

        // ------------------------------------------------------------ Revertir la última venta (Pila)

        private void btnAnularUltima_Click(object? sender, EventArgs e)
        {
            if (cajero == null) return;

            Pila<Venta> pila = ObtenerPilaVentasDelCajero(cajero);
            Venta? ultima = pila.Cima();
            if (ultima == null)
            {
                MessageBox.Show("No tiene ventas pagadas para anular.", "Anular venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Anular su última venta?\n\nCódigo: {ultima.CodigoOperacion}\nFecha: {ultima.FechaVenta:dd/MM/yyyy HH:mm}\nTotal: S/ {ultima.Total:N2}\n\nLos productos volverán al inventario.",
                "Anular última venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta != DialogResult.Yes) return;

            Venta? revertida = pila.Desapilar();
            if (revertida != null && AnularVenta(revertida, cajero))
            {
                MessageBox.Show($"La venta {revertida.CodigoOperacion} fue anulada.", "Anular última venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorial();
            }
        }

        private static Pila<Venta> ObtenerPilaVentasDelCajero(Usuario usuario)
        {
            Pila<Venta> pila = new Pila<Venta>();

            IEnumerable<Venta> ventas = Almacen.Ventas.Cargar()
                .Where(v => v.UsuarioId == usuario.UsuarioId &&
                            v.SucursalId == usuario.SucursalId &&
                            v.Estado == "PAGADA")
                .OrderBy(v => v.FechaVenta);

            foreach (Venta venta in ventas)
                pila.Apilar(venta);

            return pila;
        }

        private static bool AnularVenta(Venta venta, Usuario usuario)
        {
            List<Venta> ventas = Almacen.Ventas.Cargar();
            Venta? registrada = ventas.FirstOrDefault(v =>
                v.VentaId == venta.VentaId &&
                v.UsuarioId == usuario.UsuarioId &&
                v.SucursalId == usuario.SucursalId &&
                v.Estado == "PAGADA");

            if (registrada == null) return false;

            List<Inventario> inventario = Almacen.Inventario.Cargar();
            foreach (DetalleVenta detalle in registrada.Detalles)
            {
                Inventario? existencia = inventario.FirstOrDefault(i =>
                    i.SucursalId == registrada.SucursalId && i.ProductoId == detalle.ProductoId);

                if (existencia != null)
                    existencia.StockActual += detalle.Cantidad;
            }

            registrada.Estado = "ANULADA";
            Almacen.Inventario.Guardar(inventario);
            Almacen.Ventas.Guardar(ventas);
            return true;
        }
    }
}
