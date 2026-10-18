using Microsoft.Data.SqlClient;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmLogin : Form
    {
        private readonly AutenticacionService servicio = new AutenticacionService();

        /// <summary>Usuario validado. Program.cs lo lee cuando este formulario se cierra con DialogResult.OK.</summary>
        public Usuario? UsuarioAutenticado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            AcceptButton = btnIniciarSesion;        // Enter = Ingresar
            txtContraseña.UseSystemPasswordChar = true;   // oculta la clave con puntos
        }

        // Se mantiene porque el Designer lo tiene enlazado (Load += FrmLogin_Load)
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ResultadoLogin resultado;
            Usuario? usuario;

            try
            {
                resultado = servicio.IniciarSesion(txtUsuario.Text, txtContraseña.Text, out usuario);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "No se pudo conectar con la base de datos.\n\nDetalle técnico: " + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (resultado)
            {
                case ResultadoLogin.Ok:
                    UsuarioAutenticado = usuario;
                    txtContraseña.Clear();
                    DialogResult = DialogResult.OK;   // cierra el login y devuelve el control a Program.cs
                    break;

                case ResultadoLogin.Bloqueado:
                    Aviso("Cuenta bloqueada por intentos fallidos. Intenta de nuevo en 15 minutos.");
                    break;

                case ResultadoLogin.Inactivo:
                    Aviso("Tu usuario está desactivado. Contacta al administrador.");
                    break;

                case ResultadoLogin.CuentaIncompleta:
                    Aviso("Tu cuenta no tiene rol o sucursal válidos. Contacta al administrador.");
                    break;

                default:
                    Aviso("Usuario o contraseña incorrectos.");
                    break;
            }
        }

        private void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtContraseña.Clear();
            txtContraseña.Focus();
        }
    }
}