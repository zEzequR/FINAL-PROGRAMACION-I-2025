using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Proveedor
    {
        public int id_proveedor { get; set; }

        public string nombre_proveedor { get; set; }

        public string telefono { get; set; }

        public string email { get; set; }

        public Proveedor(int id, string nombre, string telefono, string email)
        {
            this.id_proveedor = id;
            this.nombre_proveedor = nombre;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
