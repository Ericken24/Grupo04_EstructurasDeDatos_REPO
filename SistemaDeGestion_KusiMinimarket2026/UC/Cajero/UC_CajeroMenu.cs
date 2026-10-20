using SistemaDeGestion_KusiMinimarket2026.Clases.Persistencia;
using SistemaDeGestion_KusiMinimarket2026.UC.Cajero;

namespace SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC
{
    public partial class UC_CajeroMenu : UserControl
    {
        public UC_CajeroMenu()
        {
            InitializeComponent();
            btnPuntoVenta.Click += (s, e) => Abrir(new UC_NuevaVenta());
            btnHisotrialVentas.Click += (s, e) => Abrir(new UC_HistorialVentas());
            btnTransEspera.Click += (s, e) => Abrir(new UC_TransaccionesEspera());
        }

        private void Abrir(UserControl modulo)
        {
            // Los módulos de este menú son exclusivos del rol Cajero
            if (!ServicioCajero.EsCajero)
            {
                modulo.Dispose();
                MessageBox.Show("Estos módulos son exclusivos del rol Cajero.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (FindForm() is FrmPrincipal principal) principal.MostrarModulo(modulo);
        }
    }
}
