namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    /// <summary>
    /// Autenticación local para la demo: sin base de datos, funciona en cualquier laptop.
    /// Las cuentas viven en esta lista. Más adelante se puede reemplazar por una base de datos
    /// o un archivo sin cambiar FrmLogin, porque solo depende del método IniciarSesion.
    /// </summary>
    public class AutenticacionService
    {
        // Cuenta = datos de acceso + datos del usuario que se proyectan en FrmPrincipal
        private record Cuenta(string NombreUsuario, string Correo, string Clave, Usuario Datos); //record es como una clase pero inmutable y con igualdad por valor

        private static int siguienteId = 1;   // debe ir ANTES de la lista (orden de inicialización)

        private static readonly List<Cuenta> cuentas = // lista de cuentas de prueba, sin base de datos
        [
            Crear("admin.general", "Admin123", "Juan Perez",
                  RolUsuario.AdministradorGeneral, 8, "ADM-01", "Sede administrativa Kusi"),

            Crear("admin.centro", "Centro123", "Erick Encarnación",
                  RolUsuario.AdministradorSucursal, 1, "SUC-01", "Kusi Centro"),
            Crear("admin.norte", "Norte123", "Flor Becerra",
                  RolUsuario.AdministradorSucursal, 2, "SUC-02", "Kusi Norte"),

            Crear("cajero.centro1", "Cajero123", "Alexis Sanchéz",
                  RolUsuario.Cajero, 1, "SUC-01", "Kusi Centro"),
            Crear("cajero.norte1", "Cajero123", "Tatiana Mendoza",
                  RolUsuario.Cajero, 2, "SUC-02", "Kusi Norte"),
        ];

        private static Cuenta Crear(string usuario, string clave, string nombre, RolUsuario rol,        // crea un usuario de prueba y lo agrega a la lista
                                    int sucursalId, string codigoSucursal, string nombreSucursal)
        {
            Usuario datos = new Usuario
            {
                UsuarioId = siguienteId++,
                NombreCompleto = nombre,
                NombreUsuario = usuario,
                Rol = rol,
                SucursalId = sucursalId,
                CodigoSucursal = codigoSucursal,
                NombreSucursal = nombreSucursal,
                DebeCambiarClave = false
            };
            return new Cuenta(usuario, usuario + "@kusi.example", clave, datos);
        }

        /// <summary>Acepta usuario o correo (sin distinguir mayúsculas). Devuelve null si no coincide.</summary>
        public Usuario?IniciarSesion(string login, string clave) // login puede ser nombre de usuario o correo, ?: permite que el método devuelva null si no se encuentra la cuenta
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(clave))
                return null;

            string buscado = login.Trim();

            Cuenta? cuenta = cuentas.FirstOrDefault(c =>                  // busca por nombre de usuario o correo, sin distinguir mayúsculas, el simbolo ? permite que c sea null y no lance excepción
                c.NombreUsuario.Equals(buscado, StringComparison.OrdinalIgnoreCase) ||
                c.Correo.Equals(buscado, StringComparison.OrdinalIgnoreCase));

            if (cuenta == null || cuenta.Clave != clave)
                return null;

            return cuenta.Datos;
        }
    }
}