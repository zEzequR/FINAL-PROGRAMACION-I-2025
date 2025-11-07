using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Usuario
    {
        public string usuario;
        public int psw;

        public Usuario setUsuario(string nombreUsuario, int contraseña)
        {
            Usuario user = new Usuario();
            user.usuario = nombreUsuario;
            user.psw = contraseña;
            return user;
        }
    }
}
