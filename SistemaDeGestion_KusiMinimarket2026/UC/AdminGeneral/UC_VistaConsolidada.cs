using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Vista consolidada de todas las sucursales (solo rol Administrador general).
    /// Estructuras: ListaSimple (filtrar ventas, compras y gastos por sucursal)
    /// y ListaCircular (carrusel de datos destacados: cada clic pasa al siguiente y vuelve al inicio).
    /// </summary>
    public partial class UC_VistaConsolidada : UserControl
    {
        /// <summary>Totales de una sucursal para mostrar en la tabla.</summary>
        private sealed class FilaSucursal
        {
            public string Nombre = "";
            public int CantidadVentas;
            public decimal Ventas;
            public decimal Compras;
            public decimal Gastos;
            public decimal Utilidad => Ventas - Compras - Gastos;
        }

        private ListaCircular<string> destacados = new ListaCircular<string>();
        private int posicionDestacado;

        public UC_VistaConsolidada()
        {
            InitializeComponent();
        }

        private void UC_VistaConsolidada_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            CargarConsolidado();
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            CargarConsolidado();
        }

        private void btnSiguienteDestacado_Click(object? sender, EventArgs e)
        {
            MostrarSiguienteDestacado();
        }

        private static string Soles(decimal monto) => "S/ " + monto.ToString("N2");

        // ------------------------------------------------------------ Carga

        private void CargarConsolidado()
        {
            // ListaSimple: cada registro se filtra con Filtrar(...)
            ListaSimple<Sucursal> tiendas = ListaSimple<Sucursal>.Desde(Almacen.Sucursales.Cargar())
                .Filtrar(s => s.Tipo == "TIENDA" && s.Activa);

            List<Venta> todasLasVentas = Almacen.Ventas.Cargar();
            ListaSimple<Venta> pagadas = ListaSimple<Venta>.Desde(todasLasVentas).Filtrar(v => v.Estado == "PAGADA");
            ListaSimple<Venta> anuladas = ListaSimple<Venta>.Desde(todasLasVentas).Filtrar(v => v.Estado == "ANULADA");
            ListaSimple<Compra> compras = ListaSimple<Compra>.Desde(Almacen.Compras.Cargar()).Filtrar(c => c.Estado != "ANULADA");
            ListaSimple<Gasto> gastos = ListaSimple<Gasto>.Desde(Almacen.Gastos.Cargar()).Filtrar(g => g.Estado == "REGISTRADO");

            ListaSimple<FilaSucursal> filas = new ListaSimple<FilaSucursal>();
            foreach (Sucursal tienda in tiendas)
            {
                ListaSimple<Venta> ventasTienda = pagadas.Filtrar(v => v.SucursalId == tienda.SucursalId);
                filas.AgregarFinal(new FilaSucursal
                {
                    Nombre = tienda.Nombre,
                    CantidadVentas = ventasTienda.Cantidad,
                    Ventas = ventasTienda.Sum(v => v.Total),
                    Compras = compras.Filtrar(c => c.SucursalId == tienda.SucursalId).Sum(c => c.Total),
                    Gastos = gastos.Filtrar(g => g.SucursalId == tienda.SucursalId).Sum(g => g.Monto)
                });
            }

            dgvSucursales.Rows.Clear();
            foreach (FilaSucursal f in filas)
            {
                int fila = dgvSucursales.Rows.Add(f.Nombre, f.CantidadVentas, f.Ventas.ToString("N2"),
                                                  f.Compras.ToString("N2"), f.Gastos.ToString("N2"), f.Utilidad.ToString("N2"));
                if (f.Utilidad < 0) dgvSucursales.Rows[fila].DefaultCellStyle.ForeColor = Color.Brown;
            }

            decimal totalVentas = filas.Sum(f => f.Ventas);
            decimal totalCompras = filas.Sum(f => f.Compras);
            decimal totalGastos = filas.Sum(f => f.Gastos);
            decimal utilidad = totalVentas - totalCompras - totalGastos;

            lblKpiVentas.Text = Soles(totalVentas);
            lblKpiCompras.Text = Soles(totalCompras);
            lblKpiGastos.Text = Soles(totalGastos);
            lblKpiUtilidad.Text = Soles(utilidad);
            lblKpiUtilidad.ForeColor = utilidad < 0 ? Color.Brown : Color.DarkOliveGreen;
            lblSubtitulo.Text = $"{tiendas.Cantidad} sucursales activas  ·  {DateTime.Today:dd/MM/yyyy}";

            ArmarDestacados(filas, anuladas.Cantidad, ContarCriticos(tiendas));
        }

        // ------------------------------------------------------------ Carrusel (ListaCircular)

        private void ArmarDestacados(ListaSimple<FilaSucursal> filas, int ventasAnuladas, int productosCriticos)
        {
            destacados = new ListaCircular<string>();

            FilaSucursal? lider = filas.OrderByDescending(f => f.Ventas).FirstOrDefault();
            destacados.Agregar(lider != null && lider.Ventas > 0
                ? $"Sucursal con más ventas:\n\n{lider.Nombre}\n{Soles(lider.Ventas)}"
                : "Aún no hay ventas pagadas registradas.");

            FilaSucursal? mayorGasto = filas.OrderByDescending(f => f.Gastos).FirstOrDefault();
            destacados.Agregar(mayorGasto != null && mayorGasto.Gastos > 0
                ? $"Sucursal con más gastos:\n\n{mayorGasto.Nombre}\n{Soles(mayorGasto.Gastos)}"
                : "Aún no hay gastos registrados.");

            destacados.Agregar($"Productos en stock crítico (agotados o bajo el mínimo):\n\n{productosCriticos}");
            destacados.Agregar($"Ventas anuladas en toda la red:\n\n{ventasAnuladas}");

            posicionDestacado = 0;
            MostrarSiguienteDestacado();
        }

        private void MostrarSiguienteDestacado()
        {
            string? texto = destacados.SiguienteTurno();
            if (texto == null)
            {
                lblDestacado.Text = "Sin datos para mostrar.";
                lblPosicionDestacado.Text = "";
                return;
            }

            posicionDestacado = posicionDestacado % destacados.Cantidad + 1;   // al llegar al final vuelve a 1
            lblDestacado.Text = texto;
            lblPosicionDestacado.Text = $"{posicionDestacado} de {destacados.Cantidad}";
        }

        /// <summary>Cuenta los registros de inventario de las tiendas que están bajo el stock mínimo.</summary>
        private static int ContarCriticos(ListaSimple<Sucursal> tiendas)
        {
            Dictionary<int, Producto> productos = Almacen.Productos.Cargar()
                .Where(p => p.Activo && p.ControlaStock)
                .ToDictionary(p => p.ProductoId);

            ListaSimple<Inventario> inventario = ListaSimple<Inventario>.Desde(Almacen.Inventario.Cargar())
                .Filtrar(i => tiendas.Buscar(s => s.SucursalId == i.SucursalId) != null);

            int contador = 0;
            foreach (Inventario i in inventario)
            {
                if (productos.TryGetValue(i.ProductoId, out Producto? producto) && i.StockActual < producto.StockMinimo)
                    contador++;
            }
            return contador;
        }
    }

    /// <summary>
    /// Candado y utilidades de los módulos del Administrador general (equivale a RestriccionCajero + ServicioCajero).
    /// Si la sesión no es de un Administrador general, el UC se vacía y solo muestra un aviso.
    /// </summary>
    internal static class ServicioAdminGeneral
    {
        public static bool EsAdminGeneral =>
            Sesion.Actual?.Rol == RolUsuario.AdministradorGeneral || Sesion.Actual?.Rol == RolUsuario.SuperAdmin;

        public static bool Aplicar(UserControl modulo)
        {
            if (EsAdminGeneral) return true;

            modulo.Controls.Clear();
            modulo.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Brown,
                Location = new Point(20, 80),
                Text = "Acceso restringido: este módulo es exclusivo del rol Administrador general."
            });
            return false;
        }

        /// <summary>Guarda un evento en auditoria.json con el usuario y la sucursal de la sesión.</summary>
        public static void RegistrarAuditoria(string accion, string detalle)
        {
            List<Auditoria> registros = Almacen.Auditoria.Cargar();
            registros.Add(new Auditoria
            {
                AuditoriaId = RepositorioJson<Auditoria>.SiguienteId(registros.Select(a => a.AuditoriaId)),
                UsuarioId = Sesion.Actual?.UsuarioId,
                SucursalId = Sesion.Actual?.SucursalId,
                Accion = accion,
                Detalle = detalle,
                FechaEvento = DateTime.Now
            });
            Almacen.Auditoria.Guardar(registros);
        }
    }
}
