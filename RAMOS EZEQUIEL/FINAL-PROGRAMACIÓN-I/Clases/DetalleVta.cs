using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class DetalleVta
    {
        public int id_detalle_venta {  get; set; }
        public int id_venta { get; set; }
        public int codigo { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }

        public decimal precio_r {  get; set; }

        public DetalleVta(int id, int idVta, int cod, decimal price, int cant, decimal precioF)
        {
            this.id_detalle_venta = id;
            this.id_venta = idVta;
            this.codigo = cod;
            this.precio = price;
            this.cantidad = cant;
            this.precio_r = precioF;
        }
    }
}
