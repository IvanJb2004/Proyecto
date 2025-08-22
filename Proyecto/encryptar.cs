using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

public static class Encriptador
{
    // Encripta la contraseña con sal automática
    public static string Encriptar(string contraseña)
    {
        return BCrypt.Net.BCrypt.HashPassword(contraseña);
    }

    // Verifica si la contraseña ingresada coincide con el hash guardado
    public static bool Verificar(string contraseñaIngresada, string hashGuardado)
    {
        return BCrypt.Net.BCrypt.Verify(contraseñaIngresada, hashGuardado);
    }
}