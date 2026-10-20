using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Detalle de una sucursal elegida (solo rol Administrador general).
    /// Estructuras: ListaSimple (filtrar ventas, compras y gastos de la sucursal)
    /// y ListaDoble (navegar Primera / Anterior / Siguiente / Última con un cursor).
    /// </summary>
    public partial class UC_DetalleSucursal : UserControl
    {
        private ListaDoble<Venta> historial = new ListaDoble<Venta>();
        private List<MetodoPago> metodos = new List<MetodoPago>();
        private int indice;               // posición del cursor de la lista (0 = venta más reciente)
        private bool sincronizando;       // evita que el grid y los botones se llamen entre sí en bucle
        private bool listo;               // evita cargar datos mientras se llena el ComboBox

        public UC_DetalleSucursal()
        {
            InitializeComponent();
        }

        private void UC_DetalleSucursal_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            metodos = Almacen.MetodosPago.Cargar();
            ListaSimple<Sucursal> tiendas = ListaSimple<Sucursal>.Desde(Almacen.Sucursales.Cargar())
                .Filtrar(s => s.Tipo == "TIENDA");
            cboSucursal.DataSource = tiendas.ToList();

            listo = true;
            CargarSucursal();
        }

        private void cboSucursal_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listo) CargarSucursal();
        }

        // ------------------------------------------------------------ Carga

        private string NombreMetodo(int metodoPagoId)
        {
            MetodoPago? metodo = metodos.FirstOrDefault(m => m.MetodoPagoId == metodoPagoId);
            return metodo?.Nombre ?? "-";
        }

        private void CargarSucursal()
        {
            if (cboSucursal.SelectedItem is not Sucursal sucursal) return;
            int sucursalId = sucursal.SucursalId;

            lblInfoSucursal.Text = $"Código: {sucursal.Codigo}   ·   Distrito: {sucursal.Distrito}   ·   {(sucursal.Activa ? "Activa" : "Inactiva")}";

            // ListaSimple: solo los registros de esta sucursal
            ListaSimple<Venta> ventas = ListaSimple<Venta>.Desde(Almacen.Ventas.Cargar())
                .Filtrar(v => v.SucursalId == sucursalId && v.Estado != "EN_ESPERA");
            ListaSimple<Compra> compras = ListaSimple<Compra>.Desde(Almacen.Compras.Cargar())
                .Filtrar(c => c.SucursalId == sucursalId && c.Estado != "ANULADA");
            ListaSimple<Gasto> gastos = ListaSimple<Gasto>.Desde(Almacen.Gastos.Cargar())
                .Filtrar(g => g.SucursalId == sucursalId && g.Estado == "REGISTRADO");

            decimal totalVentas = ventas.Filtrar(v => v.Estado == "PAGADA").Sum(v => v.Total);
            decimal totalCompras = compras.Sum(c => c.Total);
            decimal totalGastos = gastos.Sum(g => g.Monto);
            decimal utilidad = totalVentas - totalCompras - totalGastos;

            lblResumenSuc.Text = $"Ventas: S/ {totalVentas:N2}   ·   Compras: S/ {totalCompras:N2}   ·   Gastos: S/ {totalGastos:N2}   ·   Utilidad: S/ {utilidad:N2}";
            lblResumenSuc.ForeColor = utilidad < 0 ? Color.Brown : Color.DarkOliveGreen;

            // ListaDoble: de la venta más reciente a la más antigua
            historial = ListaDoble<Venta>.Desde(ventas.OrderByDescending(v => v.FechaVenta));

            sincronizando = true;
            try
            {
                dgvVentas.Rows.Clear();
                foreach (Venta v in historial)
                {
                    int fila = dgvVentas.Rows.Add(v.CodigoOperacion, v.FechaVenta.ToString("dd/MM/yyyy HH:mm"),
                                                  v.NombreCajero, v.Estado, v.Total.ToString("N2"));
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
                lblCodigo.Text = lblCajero.Text = lblMetodo.Text = lblEstado.Text = "-";
                lblEstado.ForeColor = Color.Black;
                lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
                lblPosicion.Text = "Sin ventas";
                btnPrimera.Enabled = btnAnterior.Enabled = btnSiguiente.Enabled = btnUltima.Enabled = false;
                return;
            }

            lblCodigo.Text = venta.CodigoOperacion;
            lblCajero.Text = venta.NombreCajero;
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
    }
}
