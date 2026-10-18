using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using static System.Collections.Specialized.BitVector32;

namespace SistemaDeGestion_KusiMinimarket2026
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Ciclo: Login -> Principal -> (Cerrar sesión) -> Login ...
            // Si el usuario cierra el Login con la X, o cierra el Principal con la X, la app termina.
            while (true)
            {
                using (FrmLogin login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK || login.UsuarioAutenticado == null)
                        break;

                    Sesion.Iniciar(login.UsuarioAutenticado);
                }

                using (FrmPrincipal principal = new FrmPrincipal(Sesion.Actual!))
                {
                    Application.Run(principal);

                    if (!principal.CerrarSesionSolicitada)
                        break;
                }

                Sesion.Cerrar();
            }
        }
    }
}
