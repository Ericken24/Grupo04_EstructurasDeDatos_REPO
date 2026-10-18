using System.Security.Cryptography;
using System.Text;

namespace SistemaDeGestion_KusiMinimarket2026.Clases.Autenticacion
{
    /// <summary>Crea y verifica hashes de contraseña. La clave nunca se guarda en texto.</summary>
    public static class HashClave
    {
        private const int IteracionesPbkdf2 = 100_000;

        /// <summary>Hash nuevo con PBKDF2-SHA256 y sal aleatoria (para crear usuarios o cambiar claves).</summary>
        public static (byte[] Hash, byte[] Sal, int Iteraciones) CrearPbkdf2(string clave)
        {
            byte[] sal = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                clave, sal, IteracionesPbkdf2, HashAlgorithmName.SHA256, 32);
            return (hash, sal, IteracionesPbkdf2);
        }

        /// <summary>
        /// Verifica según el algoritmo guardado en la base:
        /// "SHA512" (usuarios del script inicial) = SHA512(sal + clave en UTF-16), igual que HASHBYTES;
        /// "PBKDF2" (usuarios que ya cambiaron su clave desde la app).
        /// </summary>
        public static bool Verificar(string clave, byte[] hashGuardado, byte[] sal, string algoritmo, int? iteraciones)
        {
            byte[] calculado;

            if (algoritmo == "PBKDF2")
            {
                calculado = Rfc2898DeriveBytes.Pbkdf2(
                    clave, sal, iteraciones ?? IteracionesPbkdf2, HashAlgorithmName.SHA256, hashGuardado.Length);
            }
            else
            {
                byte[] claveBytes = Encoding.Unicode.GetBytes(clave);
                calculado = SHA512.HashData(sal.Concat(claveBytes).ToArray());
            }

            return CryptographicOperations.FixedTimeEquals(calculado, hashGuardado);
        }
    }
}