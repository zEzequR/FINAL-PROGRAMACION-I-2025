using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Cliente
    {
        public int id_cliente { get; set; }
        public string razon_social { get; set; }

        public Cliente(int id, string nombre)
        {
            this.id_cliente = id;
            this.razon_social = nombre;
        }
    }
}
