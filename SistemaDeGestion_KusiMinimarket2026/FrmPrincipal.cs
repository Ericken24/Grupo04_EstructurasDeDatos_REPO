using SistemaDeGestion_KusiMinimarket2026.AdmiGenRol_UC;
using SistemaDeGestion_KusiMinimarket2026.AdmiSucRol_UC;
using SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC;
using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeGestion_KusiMinimarket2026
{
    public partial class FrmPrincipal : Form
    {
        private readonly Usuario usuarioActual;
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

            lblUsuario.Text = usuarioActual.NombreCompleto;
            lblRol.Text = usuarioActual.Rol.ToString();
            lblSucursal.Text = usuarioActual.NombreSucursal;


            CargarMenuPorRol();
        }

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
                    MessageBox.Show(
                        "El rol del usuario no tiene un menú asignado.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }

            pnlMenu.Controls.Clear();

            menu.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(menu);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();

            login.StartPosition = FormStartPosition.CenterScreen;
            login.WindowState = FormWindowState.Minimized;

            login.Show();
            login.Activate();
            login.BringToFront();

            this.Hide();
        }
    }
}
