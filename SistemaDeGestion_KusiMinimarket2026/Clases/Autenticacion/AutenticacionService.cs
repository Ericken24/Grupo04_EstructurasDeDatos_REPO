using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using SistemaDeGestion_KusiMinimarket2026.Datos_SQLServer;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    public class AutenticacionService
    {
        private readonly Conexion conexion;

        public AutenticacionService()
        {
            conexion = new Conexion();
        }

        public Usuario? IniciarSesion(string nombreUsuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrEmpty(clave))
            {
                return null;
            }

            byte[] hashClave = SHA512.HashData(
                Encoding.Unicode.GetBytes(clave));

            using SqlConnection cn = conexion.ObtenerConexion();

            string consulta = @"
                SELECT
                    u.UsuarioId,
                    u.NombreCompleto,
                    u.NombreUsuario,
                    u.PasswordHash,
                    u.DebeCambiarClave,
                    r.Nombre AS NombreRol,
                    s.SucursalId,
                    s.Nombre AS NombreSucursal,
                    s.Codigo AS CodigoSucursal
                FROM kusi.Usuarios u
                INNER JOIN kusi.Roles r
                    ON u.RolId = r.RolId
                LEFT JOIN kusi.Sucursales s
                    ON u.SucursalId = s.SucursalId
                WHERE u.NombreUsuario = @NombreUsuario
                    AND u.Activo = 1
                    AND r.Activo = 1;";

            using SqlCommand cmd = new SqlCommand(consulta, cn);

            cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50)
                .Value = nombreUsuario.Trim();

            cn.Open();

            using SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            byte[] hashGuardado = (byte[])reader["PasswordHash"];

            if (!CryptographicOperations.FixedTimeEquals(
                hashClave, hashGuardado))
            {
                return null;
            }

            if (reader["SucursalId"] == DBNull.Value)
                return null;

            string nombreRol = reader["NombreRol"].ToString()!;

            RolUsuario rol;

            switch (nombreRol)
            {
                case "CAJERO":
                    rol = RolUsuario.Cajero;
                    break;

                case "ADMIN_SUCURSAL":
                    rol = RolUsuario.AdministradorSucursal;
                    break;

                case "ADMIN_GENERAL":
                    rol = RolUsuario.AdministradorGeneral;
                    break;

                case "SUPER_ADMIN":
                    rol = RolUsuario.SuperAdmin;
                    break;

                default:
                    return null;
            }

            Usuario usuario = new Usuario
            {
                UsuarioId = Convert.ToInt32(reader["UsuarioId"]),
                NombreCompleto = reader["NombreCompleto"].ToString()!,
                NombreUsuario = reader["NombreUsuario"].ToString()!,
                Rol = rol,
                SucursalId = Convert.ToInt32(reader["SucursalId"]),
                NombreSucursal = reader["NombreSucursal"].ToString()!,
                CodigoSucursal = reader["CodigoSucursal"].ToString()!,
                DebeCambiarClave = Convert.ToBoolean(
                    reader["DebeCambiarClave"])
            };

            reader.Close();

            using SqlCommand actualizar = new SqlCommand(@"
                UPDATE kusi.Usuarios
                SET UltimoAcceso = SYSDATETIME()
                WHERE UsuarioId = @UsuarioId;", cn);

            actualizar.Parameters.Add("@UsuarioId", SqlDbType.Int)
                .Value = usuario.UsuarioId;

            actualizar.ExecuteNonQuery();

            return usuario;
        }
    }
}