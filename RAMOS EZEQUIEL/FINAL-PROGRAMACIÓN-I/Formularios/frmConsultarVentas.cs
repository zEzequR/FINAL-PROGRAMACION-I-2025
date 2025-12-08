using FINAL_PROGRAMACIÓN_I.Clases;
using FINAL_PROGRAMACIÓN_I.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    public partial class frmConsultarVentas : Form
    {
        Controladores controladores = new Controladores();
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {

            DataTable Ventas = controladores.getData("spu_mostrar_ventas",
                new List<string> { },
                new List<string> { },
                'N'
                );

            DataTable clientes = controladores.getData("spu_mostrar_clientes",
                new List<string> { },
                new List<string> { },
                'N'
                );

            DataTable Usuario = controladores.getData("spu_mostrar_usuarios",
                new List<string> { },
                new List<string> { },
                'N'
                );

            List<Venta> listVtas = new List<Venta>();
            List<Cliente> listClients = new List<Cliente>();
            List<Usuario> listUsers = new List<Usuario>();

            foreach (DataRow row in Ventas.Rows)
            {
                Venta vta = new Venta(row.Field<int>(0),
                    row.Field<DateTime>(1),
                    row.Field<int>(2),
                     row.Field<decimal>(3),
                    row.Field<int>(4)
                 );
                listVtas.Add(vta);
            }

            foreach (DataRow row in clientes.Rows)
            {
                Cliente client = new Cliente(row.Field<int>(0),
                row.Field<string>(1)
                );
                listClients.Add(client);
            }

            foreach (DataRow row in Usuario.Rows)
            {
                Usuario user = new Usuario(row.Field<int>(0),
                row.Field<string>(1),
                row.Field<int>(2)
                );
                listUsers.Add(user);
            }

            idVtaSelect.DataSource = listVtas;
            idVtaSelect.DisplayMember = "id_venta";
            idVtaSelect.ValueMember = "id_venta";

            clientSelect.DataSource = listClients;
            clientSelect.DisplayMember = "razon_social";
            clientSelect.ValueMember = "id_cliente";

            userSelect.DataSource = listUsers;
            userSelect.DisplayMember = "usuario";
            userSelect.ValueMember = "id_usuario";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dtVenta = (DataTable)VentaTable.DataSource;

            if (dtVenta.Columns.Contains("Código del producto"))
            {
                dtVenta.Columns["Código del producto"].ColumnName = "CodProd";
            }

            frmReportes frmReportes = new frmReportes(this, dtVenta);
            frmReportes.ShowDialog();
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(idVtaSelect.SelectedValue.ToString(), out int idVta);
            int.TryParse(clientSelect.SelectedValue.ToString(), out int idClient);
            int.TryParse(userSelect.SelectedValue.ToString(), out int idUser);

            Venta venta = new Venta(idVta,
                Convert.ToDateTime(fechaVtaInp.Value),
                idClient,
                0,
                idUser
                );

            controladores.MostrarDatos(
                "spu_mostrar_detalle_venta_V2",
                VentaTable,
                new List<string> { "@id_vta", "@fecha", "@id_cliente", "@importe", "@id_usuario" },
                new List<object> {
                    verXIDVtaCheckBox.Checked ? (Object)venta.id_venta : DBNull.Value,
                    verXFechaCheckBox.Checked ? (Object)venta.fecha : DBNull.Value,
                    verXClienteCheckBox.Checked ? (Object)venta.id_cliente : DBNull.Value,
                    DBNull.Value,
                    verXUsuarioCheckBox.Checked ? (Object)venta.id_usuario : DBNull.Value
                },
                true
                );

            decimal total = 0;

            foreach (DataGridViewRow row in VentaTable.Rows)
            {
                if (!row.IsNewRow && row.Cells[6].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[6].Value);
                }
            }

            importeVtaInp.Text = total.ToString();

            btnImprimir.Visible = true;
        }
    }
}
