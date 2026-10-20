using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;
using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;
using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;

namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    internal static class ServicioCajero
    {
        public static bool EsCajero => Sesion.Actual?.Rol == RolUsuario.Cajero;

        public static Usuario? CajeroActual => Sesion.Actual;

        public static int SucursalDe(Usuario usuario) => usuario.SucursalId ?? 0;

        public static ListaSimple<Inventario> InventarioDe(int sucursalId)
        {
            return ListaSimple<Inventario>.Desde(
                Almacen.Inventario.Cargar().Where(i => i.SucursalId == sucursalId));
        }

        public static string? ValidarStock(int sucursalId, IEnumerable<DetalleVenta> detalles)
        {
            List<Producto> productos = Almacen.Productos.Cargar();
            List<Inventario> inventario = Almacen.Inventario.Cargar();

            foreach (DetalleVenta detalle in detalles)
            {
                Producto? producto = productos.FirstOrDefault(p => p.ProductoId == detalle.ProductoId);
                if (producto?.ControlaStock != true) continue;

                decimal stock = inventario.FirstOrDefault(i =>
                    i.SucursalId == sucursalId && i.ProductoId == detalle.ProductoId)?.StockActual ?? 0;

                if (detalle.Cantidad > stock)
                    return $"Stock insuficiente de \"{detalle.Nombre}\".\nDisponible: {stock:0.##}";
            }

            return null;
        }

        public static Venta ArmarVenta(Usuario usuario, IEnumerable<DetalleVenta> detalles)
        {
            List<DetalleVenta> copia = detalles.Select(d => new DetalleVenta
            {
                ProductoId = d.ProductoId,
                Nombre = d.Nombre,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario,
                Descuento = d.Descuento
            }).ToList();
            decimal total = copia.Sum(d => d.Importe);
            List<Venta> ventas = Almacen.Ventas.Cargar();
            int ventaId = RepositorioJson<Venta>.SiguienteId(ventas.Select(v => v.VentaId));
            string codigoSucursal = usuario.CodigoSucursal ?? $"SUC-{usuario.SucursalId:00}";

            return new Venta
            {
                VentaId = ventaId,
                CodigoOperacion = $"V-{codigoSucursal}-{ventaId:D6}",
                SucursalId = SucursalDe(usuario),
                UsuarioId = usuario.UsuarioId,
                NombreCajero = usuario.NombreCompleto,
                FechaVenta = DateTime.Now,
                Estado = "EN_ESPERA",
                Subtotal = total,
                Total = total,
                Detalles = copia
            };
        }

        public static void RegistrarVentaPagada(Venta venta, MetodoPago metodo, string referencia, Usuario usuario)
        {
            venta.MetodoPagoId = metodo.MetodoPagoId;
            venta.Referencia = string.IsNullOrWhiteSpace(referencia) ? null : referencia.Trim();
            venta.Estado = "PAGADA";
            DescontarStock(venta);
            Almacen.Ventas.Agregar(venta);
        }

        public static void EncolarEnEspera(Venta venta, Usuario usuario)
        {
            venta.Estado = "EN_ESPERA";
            Almacen.ColaEspera.Agregar(venta);
        }

        public static Cola<Venta> ObtenerColaDeSucursal(Usuario usuario)
        {
            return Cola<Venta>.Desde(Almacen.ColaEspera.Cargar()
                .Where(v => v.SucursalId == SucursalDe(usuario) && v.Estado == "EN_ESPERA")
                .OrderBy(v => v.FechaVenta));
        }

        public static Venta? AtenderSiguiente(Usuario usuario, MetodoPago metodo, string referencia, out string? error)
        {
            Cola<Venta> cola = ObtenerColaDeSucursal(usuario);
            Venta? venta = cola.Frente();
            if (venta == null)
            {
                error = "No hay transacciones en espera.";
                return null;
            }

            error = ValidarStock(venta.SucursalId, venta.Detalles);
            if (error != null) return null;

            List<Venta> pendientes = Almacen.ColaEspera.Cargar();
            pendientes.RemoveAll(v => v.VentaId == venta.VentaId);
            Almacen.ColaEspera.Guardar(pendientes);

            venta.MetodoPagoId = metodo.MetodoPagoId;
            venta.Referencia = string.IsNullOrWhiteSpace(referencia) ? null : referencia.Trim();
            venta.Estado = "PAGADA";
            DescontarStock(venta);
            Almacen.Ventas.Agregar(venta);
            return venta;
        }

        public static void DescartarSiguiente(Usuario usuario)
        {
            Venta? venta = ObtenerColaDeSucursal(usuario).Frente();
            if (venta == null) return;

            List<Venta> pendientes = Almacen.ColaEspera.Cargar();
            pendientes.RemoveAll(v => v.VentaId == venta.VentaId);
            Almacen.ColaEspera.Guardar(pendientes);
        }

        private static void DescontarStock(Venta venta)
        {
            List<Producto> productos = Almacen.Productos.Cargar();
            List<Inventario> inventario = Almacen.Inventario.Cargar();
            foreach (DetalleVenta detalle in venta.Detalles)
            {
                if (productos.FirstOrDefault(p => p.ProductoId == detalle.ProductoId)?.ControlaStock != true)
                    continue;

                Inventario? existencia = inventario.FirstOrDefault(i =>
                    i.SucursalId == venta.SucursalId && i.ProductoId == detalle.ProductoId);
                if (existencia != null) existencia.StockActual -= detalle.Cantidad;
            }
            Almacen.Inventario.Guardar(inventario);
        }
    }
}
