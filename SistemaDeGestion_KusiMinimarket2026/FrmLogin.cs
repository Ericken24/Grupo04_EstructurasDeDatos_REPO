using Microsoft.Data.SqlClient;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Datos_SQLServer;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            /** este bloques de try y catch es para probar la conexión con la base de datos, se puede eliminar si no se desea probar la conexión
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    MessageBox.Show(
                        "conexión exitosa con kusiminimarket",
                        "conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "no se pudo conectar: " + ex.Message,
                    "error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }**/
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string claveIngresada = txtContraseña.Text;

            try
            {
                AutenticacionService servicio = new AutenticacionService();

                Usuario? usuario = servicio.IniciarSesion(
                    usuarioIngresado, claveIngresada);

                if (usuario == null)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos, o cuenta inactiva.",
                        "Inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                FrmPrincipal principal = new FrmPrincipal(usuario);

                principal.StartPosition = FormStartPosition.CenterScreen;
                principal.WindowState = FormWindowState.Minimized;

                principal.Show();
                principal.Activate();
                principal.BringToFront();

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo completar el inicio de sesión. Verifica la conexión con la base de datos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
