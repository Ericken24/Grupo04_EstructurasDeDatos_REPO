using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    /// <summary>
    /// Transacciones en espera de la sucursal del cajero (solo rol Cajero).
    /// Estructura: Cola (FIFO). Solo se cobra o descarta la transacción que está al frente,
    /// respetando el orden de llegada.
    /// </summary>
    public partial class UC_TransaccionesEspera : UserControl
    {
        private Cola<Venta> cola = new Cola<Venta>();
        private Usuario? cajero;

        public UC_TransaccionesEspera()
        {
            InitializeComponent();
        }

        private void UC_TransaccionesEspera_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!RestriccionCajero.Aplicar(this)) return;   // otro rol: no se carga nada

            cajero = ServicioCajero.CajeroActual;
            cboMetodoPago.DataSource = Almacen.MetodosPago.Cargar();
            CargarCola();
        }

        // ------------------------------------------------------------ Cola

        private void CargarCola()
        {
            cola = ServicioCajero.ObtenerColaDeSucursal(cajero!);

            dgvCola.Rows.Clear();
            int orden = 1;
            foreach (Venta v in cola)   // recorre del frente al final (orden de llegada)
            {
                int fila = dgvCola.Rows.Add(orden++, v.CodigoOperacion, v.FechaVenta.ToString("HH:mm"),
                                            v.NombreCajero, v.Detalles.Count, v.Total.ToString("N2"));
                dgvCola.Rows[fila].Tag = v;
            }

            Venta? frente = cola.Frente();
            lblCantidad.Text = $"En cola: {cola.Cantidad}";
            lblSiguiente.Text = frente == null
                ? "No hay transacciones en espera."
                : $"Siguiente en atender: {frente.CodigoOperacion}  -  S/ {frente.Total:N2}";

            btnAtender.Enabled = !cola.EstaVacia;
            btnDescartar.Enabled = !cola.EstaVacia;

            if (dgvCola.Rows.Count > 0)
            {
                dgvCola.Rows[0].DefaultCellStyle.Font = new Font(dgvCola.Font, FontStyle.Bold);   // el que sigue
                dgvCola.CurrentCell = dgvCola.Rows[0].Cells[0];
            }
            MostrarDetalle(frente);
        }

        private void dgvCola_SelectionChanged(object? sender, EventArgs e)
        {
            if (cajero == null) return;
            MostrarDetalle(dgvCola.CurrentRow?.Tag as Venta);
        }

        private void MostrarDetalle(Venta? venta)
        {
            dgvDetalle.Rows.Clear();
            if (venta == null)
            {
                lblTotalDetalle.Text = "TOTAL:  S/ 0.00";
                return;
            }

            foreach (DetalleVenta d in venta.Detalles)
                dgvDetalle.Rows.Add(d.Nombre, d.Cantidad.ToString("0.##"), d.PrecioUnitario.ToString("N2"), d.Importe.ToString("N2"));
            lblTotalDetalle.Text = $"TOTAL:  S/ {venta.Total:N2}";
        }

        // ------------------------------------------------------------ Cobro

        private void cboMetodoPago_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool requiere = cboMetodoPago.SelectedItem is MetodoPago m && m.RequiereReferencia;
            txtReferencia.Enabled = requiere;
            if (!requiere) txtReferencia.Clear();
        }

        private void btnAtender_Click(object? sender, EventArgs e)
        {
            if (cajero == null || cola.EstaVacia) return;

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

            Venta? atendida = ServicioCajero.AtenderSiguiente(cajero, metodo, txtReferencia.Text, out string? error);
            if (atendida == null)
            {
                MessageBox.Show(error ?? "No se pudo cobrar la transacción.", "Cobro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarCola();
                return;
            }

            MessageBox.Show($"Transacción cobrada correctamente.\n\nCódigo: {atendida.CodigoOperacion}\nTotal: S/ {atendida.Total:N2}\nPago: {metodo.Nombre}",
                "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtReferencia.Clear();
            CargarCola();
        }

        private void btnDescartar_Click(object? sender, EventArgs e)
        {
            if (cajero == null || cola.EstaVacia) return;

            Venta? frente = cola.Frente();
            if (frente == null) return;

            if (MessageBox.Show($"¿Descartar la transacción {frente.CodigoOperacion} (S/ {frente.Total:N2})?\nNo se cobrará ni descontará stock.",
                    "Descartar transacción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            ServicioCajero.DescartarSiguiente(cajero);
            CargarCola();
        }
    }
}
