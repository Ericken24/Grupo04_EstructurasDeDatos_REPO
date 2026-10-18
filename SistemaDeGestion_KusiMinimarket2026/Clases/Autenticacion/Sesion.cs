namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    /// <summary>
    /// Usuario que inició sesión. Se llena UNA vez en el login y cualquier formulario
    /// (ventas, inventario, compras...) lo lee sin volver a consultar la base de datos.
    /// </summary>
    public static class Sesion
    {
        public static Usuario? Actual { get; private set; }

        public static void Iniciar(Usuario usuario) => Actual = usuario;

        public static void Cerrar() => Actual = null;
    }
}