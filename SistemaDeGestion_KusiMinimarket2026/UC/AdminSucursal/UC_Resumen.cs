using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Panel de control de la sucursal.
    /// Estructuras: ListaSimple (filtrar registros), ListaDoble (últimas ventas, de la más reciente hacia atrás)
    /// y ListaCircular (carrusel de datos destacados que rota solo).
    /// </summary>
    public partial class UC_Resumen : UserControl
    {
        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private ListaCircular<string> destacados = new ListaCircular<string>();
        private int posicion;

        public UC_Resumen()
        {
            InitializeComponent();
            btnActualizar.Click += (s, e) => CargarResumen();
            btnSiguiente.Click += (s, e) => { MostrarSiguienteDestacado(); timerDestacado.Stop(); timerDestacado.Start(); };
            timerDestacado.Tick += (s, e) => MostrarSiguienteDestacado();
            Load += (s, e) => { if (!DesignMode) CargarResumen(); };
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");
        private static bool EsDelMes(DateTime fecha, DateTime hoy) => fecha.Year == hoy.Year && fecha.Month == hoy.Month;

        private void CargarResumen()
        {
            DateTime hoy = DateTime.Today;
            lblSubtitulo.Text = $"{Sesion.Actual?.NombreSucursal} · {hoy:dd/MM/yyyy}";

            // ListaSimple: cada registro se filtra por sucursal con Filtrar(...)
            ListaSimple<Venta> ventas = ListaSimple<Venta>.Desde(Almacen.Ventas.Cargar()).Filtrar(v => v.SucursalId == sucursalId);
            ListaSimple<Venta> pagadas = ventas.Filtrar(v => v.Estado == "PAGADA");
            ListaSimple<Compra> compras = ListaSimple<Compra>.Desde(Almacen.Compras.Cargar()).Filtrar(c => c.SucursalId == sucursalId && c.Estado != "ANULADA");
            ListaSimple<Gasto> gastos = ListaSimple<Gasto>.Desde(Almacen.Gastos.Cargar()).Filtrar(g => g.SucursalId == sucursalId && g.Estado == "REGISTRADO");

            decimal ventasHoy = 0, ventasMes = 0, comprasMes = 0, gastosMes = 0;
            int nHoy = 0, nMes = 0, nCompras = 0, nGastos = 0;
            Dictionary<string, decimal> porProducto = new Dictionary<string, decimal>();
            Dictionary<int, int> porMetodo = new Dictionary<int, int>();

            foreach (Venta v in pagadas)
            {
                if (v.FechaVenta.Date == hoy) { ventasHoy += v.Total; nHoy++; }
                if (!EsDelMes(v.FechaVenta, hoy)) continue;
                ventasMes += v.Total; nMes++;
                foreach (DetalleVenta d in v.Detalles) porProducto[d.Nombre] = porProducto.GetValueOrDefault(d.Nombre) + d.Cantidad;
                porMetodo[v.MetodoPagoId] = porMetodo.GetValueOrDefault(v.MetodoPagoId) + 1;
            }
            foreach (Compra c in compras) if (EsDelMes(c.FechaCompra, hoy)) { comprasMes += c.Total; nCompras++; }
            foreach (Gasto g in gastos) if (EsDelMes(g.FechaGasto, hoy)) { gastosMes += g.Monto; nGastos++; }

            lblKpi1Valor.Text = Soles(ventasHoy); lblKpi1Sub.Text = $"{nHoy} operaciones";
            lblKpi2Valor.Text = Soles(ventasMes); lblKpi2Sub.Text = $"{nMes} operaciones";
            lblKpi3Valor.Text = Soles(comprasMes); lblKpi3Sub.Text = $"{nCompras} compras";
            lblKpi4Valor.Text = Soles(gastosMes); lblKpi4Sub.Text = $"{nGastos} gastos";

            CargarUltimasVentas(ventas);
            int criticos = CargarStockCritico();
            ArmarDestacados(ventasMes - comprasMes - gastosMes, ventasMes, nMes, porProducto, porMetodo, criticos);
        }

        /// <summary>ListaDoble: se recorre de atrás hacia adelante para mostrar primero lo más reciente.</summary>
        private void CargarUltimasVentas(ListaSimple<Venta> ventas)
        {
            ListaDoble<Venta> historial = ListaDoble<Venta>.Desde(ventas);
            dgvUltimas.Rows.Clear();
            int mostradas = 0;
            foreach (Venta v in historial.RecorrerAlReves())
            {
                if (mostradas++ == 10) break;
                int fila = dgvUltimas.Rows.Add(v.CodigoOperacion, v.FechaVenta.ToString("dd/MM HH:mm"), v.NombreCajero, v.Estado, v.Total);
                if (v.Estado == "ANULADA") dgvUltimas.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
            }
        }

        private int CargarStockCritico()
        {
            ListaSimple<Inventario> inventario = ListaSimple<Inventario>.Desde(Almacen.Inventario.Cargar()).Filtrar(i => i.SucursalId == sucursalId);
            dgvCritico.Rows.Clear();
            int criticos = 0;
            foreach (Producto p in Almacen.Productos.Cargar())
            {
                if (!p.Activo || !p.ControlaStock) continue;
                decimal stock = inventario.Buscar(i => i.ProductoId == p.ProductoId)?.StockActual ?? 0;
                if (stock > p.StockMinimo) continue;
                criticos++;
                int fila = dgvCritico.Rows.Add(p.Nombre, stock, p.StockMinimo, stock <= 0 ? "AGOTADO" : "BAJO");
                if (stock <= 0) dgvCritico.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
            }
            lblCriticoTitulo.Text = $"Stock crítico ({criticos})";
            return criticos;
        }

        // ---------- Carrusel con ListaCircular ----------
        private void ArmarDestacados(decimal utilidad, decimal ventasMes, int nMes, Dictionary<string, decimal> porProducto,
                                     Dictionary<int, int> porMetodo, int criticos)
        {
            destacados = new ListaCircular<string>();
            destacados.Agregar("Utilidad estimada del mes (ventas - compras - gastos): " + Soles(utilidad));
            destacados.Agregar(nMes > 0 ? "Ticket promedio del mes: " + Soles(ventasMes / nMes) : "Aún no hay ventas este mes");
            destacados.Agregar("Producto más vendido del mes: " + ProductoMasVendido(porProducto));
            destacados.Agregar("Método de pago más usado: " + MetodoMasUsado(porMetodo));
            destacados.Agregar(criticos == 0 ? "Todo el inventario está por encima del mínimo" : $"Hay {criticos} productos con stock crítico");

            posicion = 0;
            MostrarSiguienteDestacado();
            timerDestacado.Start();
        }

        private void MostrarSiguienteDestacado()
        {
            string? texto = destacados.SiguienteTurno();      // devuelve el turno actual y avanza; al final vuelve al inicio
            if (texto == null) { lblDestacadoTexto.Text = "Sin datos"; lblDestacadoPos.Text = ""; return; }
            posicion = posicion % destacados.Cantidad + 1;
            lblDestacadoTexto.Text = texto;
            lblDestacadoPos.Text = $"{posicion} de {destacados.Cantidad}";
        }

        private static string ProductoMasVendido(Dictionary<string, decimal> porProducto)
        {
            string mejor = "—"; decimal max = 0;
            foreach (KeyValuePair<string, decimal> par in porProducto)
                if (par.Value > max) { max = par.Value; mejor = $"{par.Key} ({par.Value:0.##} und.)"; }
            return mejor;
        }

        private static string MetodoMasUsado(Dictionary<int, int> porMetodo)
        {
            int mejorId = 0, max = 0;
            foreach (KeyValuePair<int, int> par in porMetodo)
                if (par.Value > max) { max = par.Value; mejorId = par.Key; }
            if (max == 0) return "—";
            MetodoPago? metodo = Almacen.MetodosPago.Cargar().FirstOrDefault(m => m.MetodoPagoId == mejorId);
            string nombre = metodo != null ? metodo.Nombre : "N.º " + mejorId;
            return $"{nombre} ({max} ventas)";
        }
    }
}
