using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace SistemaDeGestion_KusiMinimarket2026.Datos_SQLServer
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=KusiMinimarket_DB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
