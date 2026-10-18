using System.Data;
using Microsoft.Data.SqlClient;
using SistemaDeGestion_KusiMinimarket2026.Datos_SQLServer;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    public enum ResultadoLogin
    {
        Ok,
        CredencialesInvalidas,
        Bloqueado,
        Inactivo,
        CuentaIncompleta   // rol desconocido o usuario sin sucursal asignada
    }

    public class AutenticacionService
    {
        private readonly Conexion conexion = new Conexion();

        /// <summary>Inicia sesión con nombre de usuario O correo. Es la ÚNICA consulta a la base en todo el flujo de acceso.</summary>
        public ResultadoLogin IniciarSesion(string login, string clave, out Usuario? usuario)
        {
            usuario = null;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(clave))
                return ResultadoLogin.CredencialesInvalidas;

            using SqlConnection cn = conexion.ObtenerConexion();
            cn.Open();

            Usuario candidato;
            byte[] hash, sal;
            string algoritmo;
            int? iteraciones;
            bool activo;
            DateTime? bloqueadoHasta;
            string nombreRol;

            using (SqlCommand cmd = new SqlCommand("kusi.usp_ObtenerUsuarioLogin", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Login", SqlDbType.NVarChar, 254).Value = login.Trim();

                using SqlDataReader r = cmd.ExecuteReader();
                if (!r.Read())
                    return ResultadoLogin.CredencialesInvalidas;

                nombreRol = r.GetString(r.GetOrdinal("Rol"));
                int colSucursal = r.GetOrdinal("SucursalId");

                candidato = new Usuario
                {
                    UsuarioId = r.GetInt32(r.GetOrdinal("UsuarioId")),
                    NombreCompleto = r.GetString(r.GetOrdinal("NombreCompleto")),
                    NombreUsuario = r.GetString(r.GetOrdinal("NombreUsuario")),
                    SucursalId = r.IsDBNull(colSucursal) ? null : r.GetInt32(colSucursal),
                    NombreSucursal = r.IsDBNull(r.GetOrdinal("Sucursal")) ? "" : r.GetString(r.GetOrdinal("Sucursal")),
                    CodigoSucursal = r.IsDBNull(r.GetOrdinal("CodigoSucursal")) ? "" : r.GetString(r.GetOrdinal("CodigoSucursal")),
                    DebeCambiarClave = r.GetBoolean(r.GetOrdinal("DebeCambiarClave"))
                };

                hash = (byte[])r["PasswordHash"];
                sal = (byte[])r["PasswordSalt"];
                algoritmo = r.GetString(r.GetOrdinal("AlgoritmoHash"));
                int colIter = r.GetOrdinal("Iteraciones");
                iteraciones = r.IsDBNull(colIter) ? null : r.GetInt32(colIter);
                activo = r.GetBoolean(r.GetOrdinal("Activo"));
                int colBloq = r.GetOrdinal("BloqueadoHasta");
                bloqueadoHasta = r.IsDBNull(colBloq) ? null : r.GetDateTime(colBloq);
            }   // el reader se cierra aquí, antes de ejecutar otros comandos

            if (bloqueadoHasta.HasValue && bloqueadoHasta.Value > DateTime.Now)
                return ResultadoLogin.Bloqueado;

            if (!HashClave.Verificar(clave, hash, sal, algoritmo, iteraciones))
            {
                EjecutarSp(cn, "kusi.usp_RegistrarLoginFallido", candidato.UsuarioId);
                return ResultadoLogin.CredencialesInvalidas;
            }

            if (!activo)
                return ResultadoLogin.Inactivo;

            RolUsuario? rol = ConvertirRol(nombreRol);
            if (rol == null || candidato.SucursalId == null)
                return ResultadoLogin.CuentaIncompleta;

            candidato.Rol = rol.Value;
            EjecutarSp(cn, "kusi.usp_RegistrarLoginExitoso", candidato.UsuarioId);

            usuario = candidato;
            return ResultadoLogin.Ok;
        }

        private static RolUsuario? ConvertirRol(string nombre) => nombre switch
        {
            "CAJERO" => RolUsuario.Cajero,
            "ADMIN_SUCURSAL" => RolUsuario.AdministradorSucursal,
            "ADMIN_GENERAL" => RolUsuario.AdministradorGeneral,
            _ => null
        };

        private static void EjecutarSp(SqlConnection cn, string procedimiento, int usuarioId)
        {
            using SqlCommand cmd = new SqlCommand(procedimiento, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UsuarioId", SqlDbType.Int).Value = usuarioId;
            cmd.ExecuteNonQuery();
        }
    }
}