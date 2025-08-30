using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class encryptar
    {
        public static string Encriptar(string contraseña)
        {
            return BCrypt.Net.BCrypt.HashPassword(contraseña);
        }

       
        public static bool Verificar(string contraseñaIngresada, string hashGuardado)
        {
            return BCrypt.Net.BCrypt.Verify(contraseñaIngresada, hashGuardado);
        }
    }
}
