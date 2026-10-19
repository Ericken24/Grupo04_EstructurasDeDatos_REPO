using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmLogin : Form
    {
        private readonly AutenticacionService servicio = new AutenticacionService(); // servicio de autenticación local (sin base de datos), reondly: no se puede cambiar después de inicializarlo

        /// <summary>Usuario validado. Program.cs lo lee cuando este formulario se cierra con DialogResult.OK.</summary>
        public Usuario? UsuarioAutenticado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            AcceptButton = btnIniciarSesion;               // Enter = Ingresar
            txtContraseña.UseSystemPasswordChar = true;    // oculta la clave con puntos
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario?usuario = servicio.IniciarSesion(txtUsuario.Text, txtContraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            UsuarioAutenticado = usuario;
            txtContraseña.Clear();
            DialogResult = DialogResult.OK;   // cierra el login y devuelve el control a Program.cs
        }
    }
}