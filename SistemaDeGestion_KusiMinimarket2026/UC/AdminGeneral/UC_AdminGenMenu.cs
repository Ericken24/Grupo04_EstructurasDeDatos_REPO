using SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral;

namespace SistemaDeGestion_KusiMinimarket2026.AdmiGenRol_UC
{
    public partial class UC_AdminGenMenu : UserControl
    {
        private readonly Dictionary<Button, Func<UserControl>> modulos;

        public UC_AdminGenMenu()
        {
            InitializeComponent();

            modulos = new Dictionary<Button, Func<UserControl>>
            {
                [btnVistaCons] = () => new UC_VistaConsolidada(),
                [btnDetalleSuc] = () => new UC_DetalleSucursal(),
                [btnInventarioGlob] = () => new UC_InventarioGlobal(),
                [btnProdCategorias] = () => new UC_ProductosCategorias(),
                [btnUserPermisos] = () => new UC_UsuariosPermisos(),
                [btnAudSincr] = () => new UC_AuditoriaSincronizacion()
            };

            foreach (Button boton in modulos.Keys)
                boton.Click += (s, e) => Abrir((Button)s!);
        }

        private void Abrir(Button boton)
        {
            foreach (Button b in modulos.Keys)
                b.BackColor = b == boton ? Color.OliveDrab : Color.DarkOliveGreen;

            if (FindForm() is FrmPrincipal principal)
                principal.MostrarModulo(modulos[boton]());
        }
    }
}
