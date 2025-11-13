using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Usuario
    {
        public int id_usuario {  get; set; }
        public string usuario { get; set; }
        public int psw { get; set; }

        public Usuario setUsuario(int id, string nombreUsuario, int contraseña)
        {
            Usuario user = new Usuario();
            user.id_usuario = id;
            user.usuario = nombreUsuario;
            user.psw = contraseña;
            return user;
        }
    }
}
