using SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion;
using SistemaDeGestion_KusiMinimarket2026.Clases.Estructuras;

namespace SistemaDeGestion_KusiMinimarket2026.UC.AdminGeneral
{
    /// <summary>
    /// Usuarios del sistema y los módulos a los que accede cada rol (solo rol Administrador general).
    /// Estructura: ListaSimple (cuentas, catálogo de módulos y filtros por rol / texto).
    /// Las cuentas son las mismas de demostración de AutenticacionService.
    /// </summary>
    public partial class UC_UsuariosPermisos : UserControl
    {
        /// <summary>Un módulo del sistema y el rol que puede abrirlo.</summary>
        private sealed class Modulo
        {
            public string Nombre;
            public string Menu;
            public RolUsuario Rol;

            public Modulo(string nombre, string menu, RolUsuario rol)
            {
                Nombre = nombre;
                Menu = menu;
                Rol = rol;
            }
        }

        private static readonly ListaSimple<Modulo> catalogo = CrearCatalogo();
        private readonly ListaSimple<Usuario> usuarios = CrearUsuarios();
        private bool listo;   // evita cargar datos mientras se arma la pantalla

        public UC_UsuariosPermisos()
        {
            InitializeComponent();
        }

        private void UC_UsuariosPermisos_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;
            if (!ServicioAdminGeneral.Aplicar(this)) return;   // otro rol: no se carga nada

            cboRol.SelectedIndex = 0;
            listo = true;
            CargarUsuarios();
        }

        private void FiltroCambiado(object? sender, EventArgs e)
        {
            if (listo) CargarUsuarios();
        }

        // ------------------------------------------------------------ Datos

        private static ListaSimple<Modulo> CrearCatalogo()
        {
            ListaSimple<Modulo> lista = new ListaSimple<Modulo>();

            foreach (string nombre in new[] { "Nueva venta", "Historial de ventas", "Transacciones en espera" })
                lista.AgregarFinal(new Modulo(nombre, "Cajero", RolUsuario.Cajero));

            foreach (string nombre in new[] { "Resumen", "Inventario", "Compras", "Gastos", "Ventas y anulaciones", "Reportes" })
                lista.AgregarFinal(new Modulo(nombre, "Admin. sucursal", RolUsuario.AdministradorSucursal));

            foreach (string nombre in new[] { "Vista consolidada", "Detalle por sucursal", "Inventario global",
                                              "Productos y categorías", "Usuarios y permisos", "Auditoría y sincronización" })
                lista.AgregarFinal(new Modulo(nombre, "Admin. general", RolUsuario.AdministradorGeneral));

            return lista;
        }

        private static ListaSimple<Usuario> CrearUsuarios()
        {
            ListaSimple<Usuario> lista = new ListaSimple<Usuario>();
            lista.AgregarFinal(NuevoUsuario(1, "Juan Perez", "admin.general", RolUsuario.AdministradorGeneral, 8, "ADM-01", "Sede administrativa Kusi"));
            lista.AgregarFinal(NuevoUsuario(2, "Erick Encarnación", "admin.centro", RolUsuario.AdministradorSucursal, 1, "SUC-01", "Kusi Centro"));
            lista.AgregarFinal(NuevoUsuario(3, "Flor Becerra", "admin.norte", RolUsuario.AdministradorSucursal, 2, "SUC-02", "Kusi Norte"));
            lista.AgregarFinal(NuevoUsuario(4, "Alexis Sanchéz", "cajero.centro1", RolUsuario.Cajero, 1, "SUC-01", "Kusi Centro"));
            lista.AgregarFinal(NuevoUsuario(5, "Tatiana Mendoza", "cajero.norte1", RolUsuario.Cajero, 2, "SUC-02", "Kusi Norte"));
            return lista;
        }

        private static Usuario NuevoUsuario(int id, string nombre, string usuario, RolUsuario rol,
                                            int sucursalId, string codigo, string sucursal) => new Usuario
        {
            UsuarioId = id,
            NombreCompleto = nombre,
            NombreUsuario = usuario,
            Rol = rol,
            SucursalId = sucursalId,
            CodigoSucursal = codigo,
            NombreSucursal = sucursal
        };

        /// <summary>El SuperAdmin usa el mismo menú que el Administrador general.</summary>
        private static RolUsuario RolEfectivo(RolUsuario rol) =>
            rol == RolUsuario.SuperAdmin ? RolUsuario.AdministradorGeneral : rol;

        private static string NombreRol(RolUsuario rol) => rol switch
        {
            RolUsuario.Cajero => "Cajero",
            RolUsuario.AdministradorSucursal => "Administrador de sucursal",
            RolUsuario.AdministradorGeneral => "Administrador general",
            _ => rol.ToString()
        };

        // ------------------------------------------------------------ Usuarios

        private void CargarUsuarios()
        {
            RolUsuario? rolFiltro = cboRol.SelectedIndex switch
            {
                1 => RolUsuario.Cajero,
                2 => RolUsuario.AdministradorSucursal,
                3 => RolUsuario.AdministradorGeneral,
                _ => null
            };
            string texto = txtBuscar.Text.Trim();

            ListaSimple<Usuario> filtrados = usuarios.Filtrar(u =>
                (rolFiltro == null || RolEfectivo(u.Rol) == rolFiltro) &&
                (texto.Length == 0 ||
                    u.NombreCompleto.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    u.NombreUsuario.Contains(texto, StringComparison.OrdinalIgnoreCase)));

            dgvUsuarios.Rows.Clear();
            foreach (Usuario u in filtrados)
            {
                int fila = dgvUsuarios.Rows.Add(u.NombreUsuario, u.NombreCompleto, NombreRol(u.Rol), u.CodigoSucursal);
                dgvUsuarios.Rows[fila].Tag = u;
            }

            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.Rows[0].Selected = true;
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows[0].Cells[0];
            }
            MostrarPermisos(ObtenerUsuarioSeleccionado());
        }

        private Usuario? ObtenerUsuarioSeleccionado() =>
            dgvUsuarios.SelectedRows.Count > 0 ? dgvUsuarios.SelectedRows[0].Tag as Usuario : null;

        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            if (listo) MostrarPermisos(ObtenerUsuarioSeleccionado());
        }

        // ------------------------------------------------------------ Permisos del usuario

        private void MostrarPermisos(Usuario? usuario)
        {
            dgvPermisos.Rows.Clear();

            if (usuario == null)
            {
                lblUsuarioSel.Text = "Seleccione un usuario";
                lblRolSel.Text = "Rol: -";
                lblResumenPermisos.Text = "Acceso a 0 de 0 módulos";
                return;
            }

            lblUsuarioSel.Text = $"{usuario.NombreCompleto}  ({usuario.NombreUsuario})";
            lblRolSel.Text = $"Rol: {NombreRol(usuario.Rol)}   ·   {usuario.NombreSucursal}";

            RolUsuario rol = RolEfectivo(usuario.Rol);
            int conAcceso = 0;
            foreach (Modulo m in catalogo)
            {
                bool acceso = m.Rol == rol;
                int fila = dgvPermisos.Rows.Add(m.Nombre, m.Menu, acceso ? "✔ Sí" : "✘ No");
                dgvPermisos.Rows[fila].Cells[2].Style.ForeColor = acceso ? Color.DarkOliveGreen : Color.Brown;
                if (acceso) conAcceso++;
            }
            lblResumenPermisos.Text = $"Acceso a {conAcceso} de {catalogo.Cantidad} módulos";
        }

        // ------------------------------------------------------------ Revisión

        private void btnRegistrarRevision_Click(object? sender, EventArgs e)
        {
            ServicioAdminGeneral.RegistrarAuditoria("REVISION_ACCESOS",
                $"Revisión de accesos: {usuarios.Cantidad} cuentas revisadas por {Sesion.Actual?.NombreCompleto}");

            MessageBox.Show("La revisión de accesos quedó registrada en la auditoría.", "Usuarios y permisos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
