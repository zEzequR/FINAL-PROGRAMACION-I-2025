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

        public Usuario(int id_usuario, string usuario, int psw)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.psw = psw;
        }
    }
}
