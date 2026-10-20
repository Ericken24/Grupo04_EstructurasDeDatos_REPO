using SistemaDeGestion_KusiMinimarket2026.AdmiGenRol_UC;
using SistemaDeGestion_KusiMinimarket2026.AdmiSucRol_UC;
using SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.UC.Cajero;
using SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral;
using SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmPrincipal : Form
    {
        private readonly Usuario usuarioActual; // Usuario que inició sesión y se pasa desde FrmLogin.cs
        private readonly System.Windows.Forms.Timer reloj = new System.Windows.Forms.Timer(); // Timer para actualizar la fecha y hora cada segundo

        /// <summary>true si el usuario pulsó "Cerrar sesión" (Program.cs vuelve a mostrar el login).</summary>
        public bool CerrarSesionSolicitada { get; private set; } // Program.cs detecta botón cerrar sesión y abre el login otra vez

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            // Cada texto queda centrado sobre la posición donde estaba la "X"
            Centrar(lblUsuario, usuarioActual.NombreCompleto);
            Centrar(lblRol, NombreRolLegible(usuarioActual.Rol));
            Centrar(lblSucursal, usuarioActual.NombreSucursal);
            Text = "Kusi Minimarket || " + usuarioActual.NombreSucursal;

            // Fecha y hora: se actualizan cada segundo
            ActualizarFechaHora();
            reloj.Interval = 1000;
            reloj.Tick += (s, e) => ActualizarFechaHora();
            reloj.Start();
            FormClosed += (s, e) => reloj.Dispose();

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
                    UC_NuevaVenta inicio = new UC_NuevaVenta();
                    inicio.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Clear();
                    pnlPrincipal.Controls.Add(inicio);
                    break;
                case RolUsuario.AdministradorSucursal:
                    menu = new UC_AdminSucMenu();
                    UC_Resumen inicioAdmin = new UC_Resumen();
                    inicioAdmin.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Clear();
                    pnlPrincipal.Controls.Add(inicioAdmin);
                    break;
                case RolUsuario.AdministradorGeneral:
                    menu = new UC_AdminGenMenu();
                    UC_VistaConsolidada inicioGen = new UC_VistaConsolidada();
                    inicioGen.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Clear();
                    pnlPrincipal.Controls.Add(inicioGen);
                    break;
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

        // Pone el texto y mantiene el centro de la etiqueta donde estaba la "X"
        private static void Centrar(Label etiqueta, string texto)
        {
            int centro = etiqueta.Left + etiqueta.Width / 2;   // centro actual
            etiqueta.Text = texto;                              // AutoSize cambia el ancho
            etiqueta.Left = centro - etiqueta.Width / 2;        // se vuelve a centrar
        }

        private void ActualizarFechaHora()
        {
            Centrar(lblFecha, DateTime.Now.ToString("dd/MM/yyyy"));
            Centrar(lblHora, DateTime.Now.ToString("HH:mm:ss"));
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