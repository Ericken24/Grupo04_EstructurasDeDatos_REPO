using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;

namespace SistemaDeGestion_KusiMinimarket2026.UC.Cajero
{
    /// <summary>
    /// Candado de acceso de los módulos del Cajero: si la sesión no es de un Cajero,
    /// el UC se vacía y solo muestra un aviso (nunca carga ni muestra datos).
    /// </summary>
    internal static class RestriccionCajero
    {
        public static bool Aplicar(UserControl modulo)
        {
            if (Sesion.Actual?.Rol == RolUsuario.Cajero) return true;

            modulo.Controls.Clear();
            modulo.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Brown,
                Location = new Point(20, 80),
                Text = "Acceso restringido: este módulo es exclusivo del rol Cajero."
            });
            return false;
        }
    }
}
