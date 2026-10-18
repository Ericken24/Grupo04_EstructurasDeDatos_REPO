using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public RolUsuario Rol { get; set; }
        public int? SucursalId { get; set; }
        public string NombreSucursal { get; set; }
        public string CodigoSucursal { get; set; }
        public bool DebeCambiarClave { get; set; }
    }
}
