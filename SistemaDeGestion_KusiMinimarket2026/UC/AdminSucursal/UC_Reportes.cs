using System.Globalization;
using System.Text;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal
{
    /// <summary>
    /// Reportes de la sucursal por rango de fechas.
    /// Estructuras: ListaSimple (filtrar datos del periodo) y Pila (historial de reportes: el botón "Anterior"
    /// vuelve al reporte previo). El orden de las filas se hace con un ordenamiento burbuja propio.
    /// </summary>
    public partial class UC_Reportes : UserControl
    {
        private record ParametrosReporte(int Tipo, DateTime Desde, DateTime Hasta);

        private class FilaReporte
        {
            public string Concepto = "";
            public decimal Cantidad;
            public decimal Monto;
            public decimal Porcentaje;
        }

        private static readonly string[] Tipos =
        {
            "Ventas por día", "Ventas por método de pago", "Ventas por cajero", "Productos más vendidos (Top 10)",
            "Compras por proveedor", "Gastos por categoría", "Inventario valorizado por categoría", "Balance del periodo"
        };
        private const int TipoInventario = 6, TipoBalance = 7;

        private readonly int sucursalId = Sesion.Actual?.SucursalId ?? 0;
        private readonly Pila<ParametrosReporte> historial = new Pila<ParametrosReporte>();
        private List<FilaReporte> filasActuales = new List<FilaReporte>();

        public UC_Reportes()
        {
            InitializeComponent();
            cmbTipo.Items.AddRange(Tipos);
            cmbTipo.SelectedIndex = 0;
            DateTime hoy = DateTime.Today;
            dtpDesde.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpHasta.Value = hoy;

            cmbTipo.SelectedIndexChanged += (s, e) => dtpDesde.Enabled = dtpHasta.Enabled = cmbTipo.SelectedIndex != TipoInventario;
            btnGenerar.Click += (s, e) => Generar(guardarEnPila: true);
            btnVolver.Click += (s, e) => VolverAlAnterior();
            btnExportar.Click += (s, e) => ExportarCsv();
            Load += (s, e) => { if (DesignMode) return; lblSubtitulo.Text = Sesion.Actual?.NombreSucursal ?? ""; Generar(guardarEnPila: true); };
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");
        private static void Avisar(string mensaje, MessageBoxIcon icono = MessageBoxIcon.Information)
            => MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, icono);

        // ---------- Generación ----------
        private void Generar(bool guardarEnPila)
        {
            int tipo = cmbTipo.SelectedIndex;
            DateTime desde = dtpDesde.Value.Date, hasta = dtpHasta.Value.Date;
            if (hasta < desde) { Avisar("La fecha \"Hasta\" no puede ser menor que \"Desde\".", MessageBoxIcon.Warning); return; }

            List<FilaReporte> filas = Construir(tipo, desde, hasta.AddDays(1), out string tituloCantidad);

            decimal baseTotal = 0, totalMostrado = 0;
            foreach (FilaReporte f in filas) baseTotal += f.Monto;
            totalMostrado = baseTotal;
            if (tipo == TipoBalance)
            {
                decimal ventas = filas.Count > 0 ? filas[0].Monto : 0;
                totalMostrado = filas.Count > 3 ? filas[3].Monto : 0;                     // utilidad estimada
                foreach (FilaReporte f in filas) f.Porcentaje = ventas == 0 ? 0 : f.Monto / ventas * 100;
            }
            else foreach (FilaReporte f in filas) f.Porcentaje = baseTotal == 0 ? 0 : f.Monto / baseTotal * 100;

            dgvReporte.Columns[0].HeaderText = tipo == 0 ? "Fecha" : "Concepto";
            dgvReporte.Columns[1].HeaderText = tituloCantidad;
            dgvReporte.Rows.Clear();
            foreach (FilaReporte f in filas) dgvReporte.Rows.Add(f.Concepto, f.Cantidad, f.Monto, f.Porcentaje);

            filasActuales = filas;
            lblReporteTitulo.Text = Tipos[tipo];
            lblReporteDetalle.Text = filas.Count == 0
                ? "Sin datos en el periodo seleccionado"
                : tipo == TipoInventario ? $"Stock actual de la sucursal · {filas.Count} filas"
                : $"Del {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy} · {filas.Count} filas";
            lblReporteTotal.Text = Soles(totalMostrado);

            ParametrosReporte actual = new ParametrosReporte(tipo, desde, hasta);
            if (guardarEnPila && historial.Cima() != actual) historial.Apilar(actual);   // Pila: el último reporte queda en el tope
            ActualizarPie();
        }

        private List<FilaReporte> Construir(int tipo, DateTime desde, DateTime fin, out string tituloCantidad)
        {
            Dictionary<string, FilaReporte> acum = new Dictionary<string, FilaReporte>();
            List<FilaReporte> filas;
            tituloCantidad = "N.º de operaciones";

            // ListaSimple: datos de la sucursal dentro del periodo
            ListaSimple<Venta> ventas = ListaSimple<Venta>.Desde(Almacen.Ventas.Cargar())
                .Filtrar(v => v.SucursalId == sucursalId && v.Estado == "PAGADA" && v.FechaVenta >= desde && v.FechaVenta < fin);
            ListaSimple<Compra> compras = ListaSimple<Compra>.Desde(Almacen.Compras.Cargar())
                .Filtrar(c => c.SucursalId == sucursalId && c.Estado != "ANULADA" && c.FechaCompra >= desde && c.FechaCompra < fin);
            ListaSimple<Gasto> gastos = ListaSimple<Gasto>.Desde(Almacen.Gastos.Cargar())
                .Filtrar(g => g.SucursalId == sucursalId && g.Estado == "REGISTRADO" && g.FechaGasto >= desde && g.FechaGasto < fin);

            switch (tipo)
            {
                case 0:
                    foreach (Venta v in ventas) Acumular(acum, v.FechaVenta.ToString("yyyy-MM-dd"), 1, v.Total);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => string.CompareOrdinal(a.Concepto, b.Concepto));            // fecha ascendente
                    tituloCantidad = "N.º de ventas";
                    break;
                case 1:
                    List<MetodoPago> metodos = Almacen.MetodosPago.Cargar();
                    foreach (Venta v in ventas)
                        Acumular(acum, metodos.FirstOrDefault(m => m.MetodoPagoId == v.MetodoPagoId)?.Nombre ?? "Otro", 1, v.Total);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));                               // mayor monto primero
                    tituloCantidad = "N.º de ventas";
                    break;
                case 2:
                    foreach (Venta v in ventas) Acumular(acum, v.NombreCajero, 1, v.Total);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));
                    tituloCantidad = "N.º de ventas";
                    break;
                case 3:
                    foreach (Venta v in ventas)
                        foreach (DetalleVenta d in v.Detalles) Acumular(acum, d.Nombre, d.Cantidad, d.Importe);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));
                    if (filas.Count > 10) filas.RemoveRange(10, filas.Count - 10);                             // solo el Top 10
                    tituloCantidad = "Unidades vendidas";
                    break;
                case 4:
                    ListaSimple<Proveedor> proveedores = ListaSimple<Proveedor>.Desde(Almacen.Proveedores.Cargar());
                    foreach (Compra c in compras)
                        Acumular(acum, proveedores.Buscar(p => p.ProveedorId == c.ProveedorId)?.RazonSocial ?? "Proveedor " + c.ProveedorId, 1, c.Total);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));
                    tituloCantidad = "N.º de compras";
                    break;
                case 5:
                    foreach (Gasto g in gastos) Acumular(acum, g.CategoriaGasto, 1, g.Monto);
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));
                    tituloCantidad = "N.º de gastos";
                    break;
                case TipoInventario:
                    ListaSimple<Producto> productos = ListaSimple<Producto>.Desde(Almacen.Productos.Cargar());
                    ListaSimple<Categoria> categorias = ListaSimple<Categoria>.Desde(Almacen.Categorias.Cargar());
                    foreach (Inventario i in Almacen.Inventario.Cargar())
                    {
                        if (i.SucursalId != sucursalId) continue;
                        Producto? p = productos.Buscar(x => x.ProductoId == i.ProductoId);
                        if (p == null || !p.Activo) continue;
                        string categoria = categorias.Buscar(c => c.CategoriaId == p.CategoriaId)?.Nombre ?? "Sin categoría";
                        Acumular(acum, categoria, i.StockActual, i.StockActual * p.PrecioCompra);              // valorizado a precio de compra
                    }
                    filas = acum.Values.ToList();
                    OrdenarBurbuja(filas, (a, b) => b.Monto.CompareTo(a.Monto));
                    tituloCantidad = "Unidades en stock";
                    break;
                default:    // balance del periodo (el orden se conserva tal cual)
                    decimal totalVentas = 0, totalCompras = 0, totalGastos = 0;
                    foreach (Venta v in ventas) totalVentas += v.Total;
                    foreach (Compra c in compras) totalCompras += c.Total;
                    foreach (Gasto g in gastos) totalGastos += g.Monto;
                    filas = new List<FilaReporte>
                    {
                        new FilaReporte { Concepto = "Ventas", Cantidad = ventas.Cantidad, Monto = totalVentas },
                        new FilaReporte { Concepto = "Compras", Cantidad = compras.Cantidad, Monto = totalCompras },
                        new FilaReporte { Concepto = "Gastos", Cantidad = gastos.Cantidad, Monto = totalGastos },
                        new FilaReporte { Concepto = "Utilidad estimada", Cantidad = 0, Monto = totalVentas - totalCompras - totalGastos }
                    };
                    tituloCantidad = "N.º de registros";
                    break;
            }
            return filas;
        }

        private static void Acumular(Dictionary<string, FilaReporte> acum, string clave, decimal cantidad, decimal monto)
        {
            if (!acum.TryGetValue(clave, out FilaReporte? fila))
            {
                fila = new FilaReporte { Concepto = clave };
                acum[clave] = fila;
            }
            fila.Cantidad += cantidad;
            fila.Monto += monto;
        }

        /// <summary>Ordenamiento burbuja: compara pares vecinos y los intercambia si están en el orden contrario al pedido.</summary>
        private static void OrdenarBurbuja(List<FilaReporte> lista, Comparison<FilaReporte> comparar)
        {
            for (int i = 0; i < lista.Count - 1; i++)
                for (int j = 0; j < lista.Count - 1 - i; j++)
                    if (comparar(lista[j], lista[j + 1]) > 0)
                        (lista[j], lista[j + 1]) = (lista[j + 1], lista[j]);
        }

        // ---------- Pila de reportes ----------
        private void VolverAlAnterior()
        {
            if (historial.Cantidad < 2) { Avisar("No hay un reporte anterior en la pila."); return; }
            historial.Desapilar();                                  // descarta el reporte actual (tope)
            ParametrosReporte? previo = historial.Cima();           // el que estaba debajo
            if (previo == null) return;

            cmbTipo.SelectedIndex = previo.Tipo;
            dtpDesde.Value = previo.Desde;
            dtpHasta.Value = previo.Hasta;
            Generar(guardarEnPila: false);
        }

        private void ActualizarPie()
        {
            lblPie.Text = $"Reportes en la pila: {historial.Cantidad}";
            btnVolver.Enabled = historial.Cantidad > 1;
            btnExportar.Enabled = filasActuales.Count > 0;
        }

        // ---------- Exportar ----------
        private static string Csv(string texto) => "\"" + texto.Replace("\"", "\"\"") + "\"";

        private void ExportarCsv()
        {
            if (filasActuales.Count == 0) { Avisar("No hay datos para exportar."); return; }
            saveFileDialog1.FileName = $"reporte_{DateTime.Now:yyyyMMdd_HHmm}.csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            CultureInfo inv = CultureInfo.InvariantCulture;
            List<string> lineas = new List<string>
            {
                string.Join(",", dgvReporte.Columns.Cast<DataGridViewColumn>().Select(c => Csv(c.HeaderText)))
            };
            foreach (FilaReporte f in filasActuales)
                lineas.Add($"{Csv(f.Concepto)},{f.Cantidad.ToString("0.##", inv)},{f.Monto.ToString("0.00", inv)},{f.Porcentaje.ToString("0.00", inv)}");

            try
            {
                File.WriteAllLines(saveFileDialog1.FileName, lineas, new UTF8Encoding(true));      // con BOM para que Excel lea las tildes
                Avisar("Reporte exportado correctamente.");
            }
            catch (IOException ex)
            {
                Avisar("No se pudo guardar el archivo: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
