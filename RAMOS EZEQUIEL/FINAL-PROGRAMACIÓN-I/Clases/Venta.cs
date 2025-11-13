using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROGRAMACIÓN_I.Clases
{
    internal class Venta
    {
        public int id_venta { get; set; }
        public DateTime fecha { get; set; }
        public int id_cliente { get; set; }
        public decimal importe { get; set; }
        public int id_usuario { get; set; }


        public Venta(int id, DateTime fecha, int idClient, decimal imp, int idUser)
        {
            this.id_venta = id;
            this.fecha = fecha;
            this.id_cliente = idClient;
            this.importe = imp;
            this.id_usuario = idUser;
        }
    }
}
