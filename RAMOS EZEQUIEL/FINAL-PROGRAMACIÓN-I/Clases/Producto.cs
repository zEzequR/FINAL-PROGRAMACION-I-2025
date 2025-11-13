using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Producto
    {
        public int codigo {  get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }

        public Producto(int cod, string desc, int stock, decimal precio)
        {
            this.codigo = cod;
            this.descripcion = desc;
            this.stock = stock;
            this.precio = precio;
        }
    }
}
