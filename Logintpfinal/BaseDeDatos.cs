using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logintpfinal
{
    public static class BaseDeDatos
    {
        public static List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario()
            {
                NombreUsuario = "Admin",
                Contraseña = "12345",
                Correo = "admin@gmail.com",
                Rol = "Admin"
            },
            new Usuario()
            {
                NombreUsuario = "Usuario",
                Contraseña = "12345",
                Correo = "usuario@gmail.com",
                Rol = "Usuario"
            }
        };
    }
}
