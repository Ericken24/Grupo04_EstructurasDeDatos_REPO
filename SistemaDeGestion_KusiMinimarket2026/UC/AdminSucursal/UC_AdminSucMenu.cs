using SistemaDeGestion_KusiMinimarket2026.UC.AdminSucursal;

namespace SistemaDeGestion_KusiMinimarket2026.AdmiSucRol_UC
{
    public partial class UC_AdminSucMenu : UserControl
    {
        private readonly Dictionary<Button, Func<UserControl>> modulos;

        public UC_AdminSucMenu()
        {
            InitializeComponent();

            // Cada botón sabe qué módulo crear
            modulos = new Dictionary<Button, Func<UserControl>>
            {
                [btnResumen] = () => new UC_Resumen(),
                [btnInventario] = () => new UC_Inventario(),
                [btnCompras] = () => new UC_Compras(),
                [btnGastos] = () => new UC_Gastos(),
                [btnVentasAnulaciones] = () => new UC_VentasAnulaciones(),
                [btnReportes] = () => new UC_Reportes()
            };
            foreach (Button boton in modulos.Keys) boton.Click += (s, e) => Abrir((Button)s!);

        }

        private void Abrir(Button boton)
        {
            foreach (Button b in modulos.Keys) b.BackColor = b == boton ? Color.OliveDrab : Color.DarkOliveGreen;   // resalta el módulo activo
            if (FindForm() is FrmPrincipal principal) principal.MostrarModulo(modulos[boton]());
        }
    }
}
