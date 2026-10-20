using SistemaDeGestion_KusiMinimarket2026.UC.Cajero;

namespace SistemaDeGestion_KusiMinimarket2026.CajeroRol_UC
{
    public partial class UC_CajeroMenu : UserControl
    {
        public UC_CajeroMenu()
        {
            InitializeComponent();
            btnPuntoVenta.Click += (s, e) => Abrir(new UC_NuevaVenta());
            // btnHisotrialVentas.Click += (s, e) => Abrir(new UC_HistorialVentas());      // se activa cuando exista el UC
            // btnTransEspera.Click     += (s, e) => Abrir(new UC_TransaccionesEspera());  // se activa cuando exista el UC
        }

        private void Abrir(UserControl modulo)
        {
            if (FindForm() is FrmPrincipal principal) principal.MostrarModulo(modulo);
        }
    }
}
