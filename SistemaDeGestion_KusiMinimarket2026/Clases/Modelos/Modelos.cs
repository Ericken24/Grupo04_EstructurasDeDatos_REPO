namespace SistemaDeGestion_KusiMinimarket2026.Clases.Modelos
{
    // Un archivo con todos los modelos: cada clase es un registro del JSON (equivale a una tabla del SQL).

    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public bool Activa { get; set; } = true;
        public override string ToString() => Nombre;      // para mostrarla directo en un ComboBox
    }

    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string RazonSocial { get; set; } = "";
        public string? Ruc { get; set; }
        public bool Activo { get; set; } = true;
        public override string ToString() => RazonSocial;
    }

    public class Sucursal
    {
        public int SucursalId { get; set; }
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Tipo { get; set; } = "TIENDA";       // TIENDA | ADMINISTRATIVA
        public string Distrito { get; set; } = "";
        public bool Activa { get; set; } = true;
        public override string ToString() => Nombre;
    }

    public class MetodoPago
    {
        public int MetodoPagoId { get; set; }
        public string Nombre { get; set; } = "";
        public bool RequiereReferencia { get; set; }
        public override string ToString() => Nombre;
    }

    public class Producto
    {
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public int ProveedorId { get; set; }
        public string SKU { get; set; } = "";
        public string? CodigoBarras { get; set; }
        public string Nombre { get; set; } = "";
        public string UnidadMedida { get; set; } = "UND";
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }           // incluye IGV 18%
        public decimal StockMinimo { get; set; }
        public bool EsPerecible { get; set; }
        public bool RequiereMayorEdad { get; set; }
        public bool ControlaStock { get; set; } = true;
        public bool Activo { get; set; } = true;
        public override string ToString() => Nombre;
    }

    public class Inventario
    {
        public int SucursalId { get; set; }
        public int ProductoId { get; set; }
        public decimal StockActual { get; set; }
    }

    public class DetalleVenta
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = "";           // se copia para que el historial no cambie si editan el producto
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Importe => Cantidad * PrecioUnitario - Descuento;
    }

    public class Venta
    {
        public int VentaId { get; set; }
        public string CodigoOperacion { get; set; } = "";  // ej. V-SUC01-000001
        public int SucursalId { get; set; }
        public int UsuarioId { get; set; }
        public string NombreCajero { get; set; } = "";
        public int MetodoPagoId { get; set; }
        public string? Referencia { get; set; }            // N.º de operación Yape/Plin/tarjeta
        public DateTime FechaVenta { get; set; } = DateTime.Now;
        public string Estado { get; set; } = "PAGADA";     // PAGADA | ANULADA | EN_ESPERA
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }              // IGV contenido en el total
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }

    public class DetalleCompra
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal Importe => Cantidad * CostoUnitario;
    }

    public class Compra
    {
        public int CompraId { get; set; }
        public string CodigoCompra { get; set; } = "";
        public int SucursalId { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaCompra { get; set; } = DateTime.Now;
        public string Estado { get; set; } = "REGISTRADA"; // REGISTRADA | RECIBIDA | ANULADA
        public decimal Total { get; set; }
        public List<DetalleCompra> Detalles { get; set; } = new List<DetalleCompra>();
    }

    public class Gasto
    {
        public int GastoId { get; set; }
        public int SucursalId { get; set; }
        public int UsuarioId { get; set; }
        public string CategoriaGasto { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public decimal Monto { get; set; }
        public DateTime FechaGasto { get; set; } = DateTime.Now;
        public string Estado { get; set; } = "REGISTRADO"; // REGISTRADO | ANULADO
    }

    public class Auditoria
    {
        public int AuditoriaId { get; set; }
        public int? UsuarioId { get; set; }
        public int? SucursalId { get; set; }
        public string Accion { get; set; } = "";
        public string Detalle { get; set; } = "";
        public DateTime FechaEvento { get; set; } = DateTime.Now;
    }

    /// <summary>Arista del grafo de sincronización entre sucursales (no dirigida, con peso).</summary>
    public class EnlaceSync
    {
        public string Origen { get; set; } = "";           // código de sucursal, ej. SUC-01
        public string Destino { get; set; } = "";
        public decimal Costo { get; set; }
        public bool Disponible { get; set; } = true;       // false = conectividad caída
    }
}
