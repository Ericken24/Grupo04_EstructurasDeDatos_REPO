using SistemaDeGestion_KusiMinimarket2026.AdmiGenRol_UC;
using SistemaDeGestion_KusiMinimarket2026.AdmiSucRol_UC;
using SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmPrincipal : Form
    {
        private readonly Usuario usuarioActual; // Usuario que inició sesión y se pasa desde FrmLogin.cs

        /// <summary>true si el usuario pulsó "Cerrar sesión" (Program.cs vuelve a mostrar el login).</summary>
        public bool CerrarSesionSolicitada { get; private set; } // Program.cs detecta botón cerrar sesión y abre el login otra vez

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            // Solo se muestran datos que ya vienen del login
            lblUsuario.Text = usuarioActual.NombreCompleto;
            lblRol.Text = NombreRolLegible(usuarioActual.Rol);
            lblSucursal.Text = usuarioActual.NombreSucursal;
            Text = "Kusi Minimarket || " + usuarioActual.NombreSucursal;

            CargarMenuPorRol();
        }

        private static string NombreRolLegible(RolUsuario rol) => rol switch // Convierte el enum RolUsuario a un nombre legible para mostrar en la interfaz
        {
            RolUsuario.Cajero => "Cajero",
            RolUsuario.AdministradorSucursal => "Administrador de sucursal",
            RolUsuario.AdministradorGeneral => "Administrador general",
            _ => rol.ToString()
        };

        private void CargarMenuPorRol()
        {
            UserControl menu;

            switch (usuarioActual.Rol)
            {
                case RolUsuario.Cajero:
                    menu = new UC_CajeroMenu();
                    break;
                case RolUsuario.AdministradorSucursal:
                    menu = new UC_AdminSucMenu();
                    break;
                case RolUsuario.AdministradorGeneral:
                case RolUsuario.SuperAdmin:
                    menu = new UC_AdminGenMenu();
                    break;
                default:
                    MessageBox.Show("El rol del usuario no tiene un menú asignado.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            pnlMenu.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(menu);
        }
        /// <summary>Muestra un UC en el panel principal reemplazando el que haya.</summary>
        public void MostrarModulo(UserControl modulo)
        {
            foreach (Control c in pnlPrincipal.Controls) c.Dispose();
            pnlPrincipal.Controls.Clear();
            modulo.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(modulo);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionSolicitada = true;
            Close();   // Program.cs detecta click en el botón cerrar sesión y abre el login otra vez
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}