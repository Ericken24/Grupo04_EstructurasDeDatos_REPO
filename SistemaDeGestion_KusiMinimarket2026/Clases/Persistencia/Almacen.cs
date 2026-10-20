using SistemaDeGestion_KusiMinimarket2026.Clases.Modelos;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia
{
    /// <summary>
    /// Punto único de acceso a los datos. Cualquier UC usa, por ejemplo:
    ///     List&lt;Producto&gt; productos = Almacen.Productos.Cargar();
    /// Para usar una carpeta compartida (red/OneDrive), basta con cambiar CarpetaDatos.
    /// </summary>
    public static class Almacen
    {
        // Carpeta "Datos" junto al .exe (el .csproj la copia al compilar)
        public static string CarpetaDatos { get; set; } = Path.Combine(AppContext.BaseDirectory, "Datos");

        public static readonly RepositorioJson<Categoria>  Categorias  = new("categorias.json");
        public static readonly RepositorioJson<Proveedor>  Proveedores = new("proveedores.json");
        public static readonly RepositorioJson<Sucursal>   Sucursales  = new("sucursales.json");
        public static readonly RepositorioJson<MetodoPago> MetodosPago = new("metodos_pago.json");
        public static readonly RepositorioJson<Producto>   Productos   = new("productos.json");
        public static readonly RepositorioJson<Inventario> Inventario  = new("inventario.json");
        public static readonly RepositorioJson<Venta>      Ventas      = new("ventas.json");        // compartido: cajero escribe, admins leen
        public static readonly RepositorioJson<Venta>      ColaEspera  = new("cola_espera.json");
        public static readonly RepositorioJson<Compra>     Compras     = new("compras.json");
        public static readonly RepositorioJson<Gasto>      Gastos      = new("gastos.json");
        public static readonly RepositorioJson<Auditoria>  Auditoria   = new("auditoria.json");
        public static readonly RepositorioJson<EnlaceSync> Enlaces     = new("enlaces_sync.json");
    }
}
