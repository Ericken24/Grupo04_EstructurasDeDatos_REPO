using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Consulta de ventas de la sucursal y anulación con devolución de stock.
    /// Estructuras: ListaSimple (filtros), ListaDoble (botones Anterior/Siguiente con cursor),
    /// Pila (revertir la última anulación: LIFO) y Cola (transacciones en espera del cajero, solo lectura).
    /// </summary>
    public partial class UC_VentasAnulaciones : UserControl
    {
        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private ListaDoble<Venta> recorrido = new ListaDoble<Venta>();          // ventas mostradas, de la más reciente a la más antigua
        private readonly Pila<Venta> anulaciones = new Pila<Venta>();           // anulaciones hechas en esta sesión
        private List<MetodoPago> metodos = new List<MetodoPago>();
        private bool cargando = true;

        public UC_VentasAnulaciones()
        {
            InitializeComponent();
            cmbEstado.Items.AddRange(new object[] { "Todos", "PAGADA", "ANULADA" });
            cmbEstado.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;

            dtpDesde.ValueChanged += (s, e) => Refrescar();
            dtpHasta.ValueChanged += (s, e) => Refrescar();
            cmbEstado.SelectedIndexChanged += (s, e) => Refrescar();
            txtBuscar.TextChanged += (s, e) => Refrescar();
            dgvVentas.SelectionChanged += (s, e) => { if (!cargando) MostrarVenta(); };
            btnAnterior.Click += (s, e) => Mover(adelante: false);
            btnSiguiente.Click += (s, e) => Mover(adelante: true);
            btnAnular.Click += (s, e) => AnularVenta();
            btnRevertir.Click += (s, e) => RevertirUltima();
            Load += (s, e) =>
            {
                if (DesignMode) return;
                lblSubtitulo.Text = Sesion.Actual?.NombreSucursal ?? "";
                metodos = Almacen.MetodosPago.Cargar();
                cargando = false;
                Refrescar();
                ActualizarPie();
            };
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");
        private static void Avisar(string mensaje, MessageBoxIcon icono = MessageBoxIcon.Information)
            => MessageBox.Show(mensaje, "Ventas y anulaciones", MessageBoxButtons.OK, icono);

        // ---------- Listado ----------
        private void Refrescar()
        {
            if (cargando) return;
            cargando = true;

            int? seleccionada = (dgvVentas.CurrentRow?.Tag as Venta)?.VentaId;
            DateTime desde = dtpDesde.Value.Date, hasta = dtpHasta.Value.Date.AddDays(1);
            string estado = cmbEstado.SelectedIndex > 0 ? (string)cmbEstado.SelectedItem! : "";
            string texto = txtBuscar.Text.Trim();

            ListaSimple<Venta> filtradas = ListaSimple<Venta>.Desde(Almacen.Ventas.Cargar())
                .Filtrar(v => v.SucursalId == sucursalId && v.FechaVenta >= desde && v.FechaVenta < hasta
                    && (estado == "" || v.Estado == estado)
                    && (texto.Length == 0 || v.CodigoOperacion.Contains(texto, StringComparison.OrdinalIgnoreCase)
                                          || v.NombreCajero.Contains(texto, StringComparison.OrdinalIgnoreCase)));

            // ListaDoble: queda ordenada de la más reciente a la más antigua; el cursor se mueve con Anterior/Siguiente
            recorrido = ListaDoble<Venta>.Desde(filtradas.ToList().OrderByDescending(v => v.FechaVenta));

            decimal total = 0;
            int filaSeleccionada = -1;
            dgvVentas.Rows.Clear();
            foreach (Venta v in recorrido)
            {
                int fila = dgvVentas.Rows.Add(v.CodigoOperacion, v.FechaVenta.ToString("dd/MM/yyyy HH:mm"), v.NombreCajero,
                    metodos.FirstOrDefault(m => m.MetodoPagoId == v.MetodoPagoId)?.Nombre ?? "-", v.Total, v.Estado);
                dgvVentas.Rows[fila].Tag = v;
                if (v.Estado == "ANULADA") dgvVentas.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
                else total += v.Total;
                if (v.VentaId == seleccionada) filaSeleccionada = fila;
            }
            lblConteo.Text = $"{filtradas.Cantidad} ventas · {Soles(total)}";

            if (dgvVentas.Rows.Count > 0)
                dgvVentas.CurrentCell = dgvVentas.Rows[filaSeleccionada >= 0 ? filaSeleccionada : 0].Cells[0];
            cargando = false;
            MostrarVenta();
        }

        private void MostrarVenta()
        {
            dgvDetalle.Rows.Clear();
            if (dgvVentas.CurrentRow?.Tag is not Venta v)
            {
                lblVentaSel.Text = "Seleccione una venta de la tabla";
                btnAnular.Enabled = btnAnterior.Enabled = btnSiguiente.Enabled = false;
                return;
            }

            // El cursor de la ListaDoble se coloca sobre la venta elegida en la tabla
            recorrido.IrAlInicio();
            while (recorrido.DatoActual?.VentaId != v.VentaId && recorrido.IrSiguiente()) { }

            foreach (DetalleVenta d in v.Detalles) dgvDetalle.Rows.Add(d.Nombre, d.Cantidad, d.PrecioUnitario, d.Descuento, d.Importe);
            lblVentaSel.Text = $"{v.CodigoOperacion} · {v.Estado}\nTotal {Soles(v.Total)} · Cajero: {v.NombreCajero}";
            btnAnular.Enabled = v.Estado == "PAGADA";
            btnAnterior.Enabled = recorrido.TieneAnterior;
            btnSiguiente.Enabled = recorrido.TieneSiguiente;
        }

        private void Mover(bool adelante)
        {
            bool movio = adelante ? recorrido.IrSiguiente() : recorrido.IrAnterior();
            Venta? destino = recorrido.DatoActual;
            if (!movio || destino == null) return;
            foreach (DataGridViewRow fila in dgvVentas.Rows)
                if (fila.Tag is Venta v && v.VentaId == destino.VentaId) { dgvVentas.CurrentCell = fila.Cells[0]; break; }
        }

        // ---------- Anulación ----------
        private void AnularVenta()
        {
            if (dgvVentas.CurrentRow?.Tag is not Venta sel || sel.Estado != "PAGADA") { Avisar("Seleccione una venta PAGADA.", MessageBoxIcon.Warning); return; }
            string motivo = txtMotivo.Text.Trim();
            if (motivo.Length < 5) { Avisar("Escriba el motivo de la anulación (mínimo 5 caracteres).", MessageBoxIcon.Warning); txtMotivo.Focus(); return; }
            if (MessageBox.Show($"¿Anular la venta {sel.CodigoOperacion} por {Soles(sel.Total)}?\nEl stock de sus productos será devuelto.",
                "Anular venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            List<Venta> todas = Almacen.Ventas.Cargar();
            Venta? venta = todas.FirstOrDefault(v => v.VentaId == sel.VentaId);
            if (venta == null || venta.Estado != "PAGADA") { Avisar("La venta ya cambió de estado.", MessageBoxIcon.Warning); Refrescar(); return; }

            MoverStock(venta, +1);                     // devuelve las unidades al inventario
            venta.Estado = "ANULADA";
            Almacen.Ventas.Guardar(todas);
            anulaciones.Apilar(venta);                 // Pila: la última anulación queda en el tope
            Auditar("ANULAR_VENTA", $"{venta.CodigoOperacion}. Motivo: {motivo}");

            txtMotivo.Clear();
            Refrescar();
            ActualizarPie();
        }

        private void RevertirUltima()
        {
            Venta? ultima = anulaciones.Cima();        // la anulación más reciente (LIFO)
            if (ultima == null) { Avisar("No hay anulaciones en esta sesión para revertir."); return; }

            List<Venta> todas = Almacen.Ventas.Cargar();
            Venta? venta = todas.FirstOrDefault(v => v.VentaId == ultima.VentaId);
            if (venta == null || venta.Estado != "ANULADA")
            {
                anulaciones.Desapilar();
                Avisar("Esa venta ya no está anulada.", MessageBoxIcon.Warning);
                ActualizarPie();
                return;
            }

            string? sinStock = ProductoSinStock(venta);
            if (sinStock != null) { Avisar($"No se puede revertir: no hay stock suficiente de \"{sinStock}\".", MessageBoxIcon.Warning); return; }
            if (MessageBox.Show($"¿Revertir la anulación de {venta.CodigoOperacion}?\nLa venta volverá a PAGADA y se descontará el stock.",
                "Revertir anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            MoverStock(venta, -1);
            venta.Estado = "PAGADA";
            Almacen.Ventas.Guardar(todas);
            anulaciones.Desapilar();                   // ahora sí se saca del tope
            Auditar("REVERTIR_ANULACION", venta.CodigoOperacion);
            Refrescar();
            ActualizarPie();
        }

        /// <summary>Suma (signo = +1) o resta (signo = -1) al inventario las cantidades de la venta. Ignora productos sin control de stock.</summary>
        private void MoverStock(Venta venta, int signo)
        {
            List<Inventario> inventario = Almacen.Inventario.Cargar();
            ListaSimple<Producto> productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar());
            foreach (DetalleVenta d in venta.Detalles)
            {
                Producto? p = productos.Buscar(x => x.ProductoId == d.ProductoId);
                if (p != null && !p.ControlaStock) continue;
                Inventario? registro = inventario.FirstOrDefault(i => i.SucursalId == sucursalId && i.ProductoId == d.ProductoId);
                if (registro == null)
                {
                    registro = new Inventario { SucursalId = sucursalId, ProductoId = d.ProductoId, StockActual = 0 };
                    inventario.Add(registro);
                }
                registro.StockActual += signo * d.Cantidad;
            }
            Almacen.Inventario.Guardar(inventario);
        }

        /// <summary>Devuelve el nombre del primer producto sin stock suficiente para volver a vender la venta, o null si alcanza.</summary>
        private string? ProductoSinStock(Venta venta)
        {
            List<Inventario> inventario = Almacen.Inventario.Cargar();
            ListaSimple<Producto> productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar());
            foreach (DetalleVenta d in venta.Detalles)
            {
                Producto? p = productos.Buscar(x => x.ProductoId == d.ProductoId);
                if (p != null && !p.ControlaStock) continue;
                decimal stock = inventario.FirstOrDefault(i => i.SucursalId == sucursalId && i.ProductoId == d.ProductoId)?.StockActual ?? 0;
                if (stock < d.Cantidad) return d.Nombre;
            }
            return null;
        }

        private void ActualizarPie()
        {
            // Cola (solo lectura): transacciones que el cajero dejó en espera, en orden de llegada
            Cola<Venta> espera = Cola<Venta>.Desde(Almacen.ColaEspera.Cargar().Where(v => v.SucursalId == sucursalId));
            string textoCola = espera.EstaVacia ? "sin transacciones en espera" : $"{espera.Cantidad} en espera, sigue {espera.Frente()!.CodigoOperacion}";
            lblEspera.Text = $"Pila de anulaciones: {anulaciones.Cantidad}\nCola del cajero: {textoCola}";
            btnRevertir.Enabled = !anulaciones.EstaVacia;
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
