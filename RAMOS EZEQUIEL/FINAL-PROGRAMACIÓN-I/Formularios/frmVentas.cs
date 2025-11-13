using Bunifu.UI.WinForms;
using FINAL_PROGRAMACIÓN_I.Clases;
using FINAL_PROGRAMACIÓN_I.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    public partial class frmVentas : Form
    {
        Controladores controladores = new Controladores();
        
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            idVtaInp.Enabled = false;
            fechaVtaInp.Enabled = false;
            importeVtaInp.Enabled = false;
            userInpTxt.Enabled = false;

            cantTxt.Visible = false;
            prodsTxt.Visible = false;
            addProdBtn.Visible = false;
            searchProdInp.Visible = false;
            searchProdInp.Visible = false;
            buscarProdTxt.Visible = false;
            clientsImg.Visible = false;
            cantSelect.Visible = false;
            deleteProdBtn.Visible = false;
            cancelarVtaBtn.Visible = false;
            closeVtaBtn.Visible = false;

            DataTable clientes = controladores.getData("spu_mostrar_clientes",
                new List<string> { },
                new List<string> { },
                'N'
                );

            List<Cliente> listClients = new List<Cliente>();

            foreach (DataRow row in clientes.Rows)
            {
                Cliente client = new Cliente(row.Field<int>(0), row.Field<string>(1));
                listClients.Add(client);
            }

            clientSelect.DataSource = listClients;
            clientSelect.DisplayMember = "razon_social";
            clientSelect.ValueMember = "id_cliente";


            controladores.MostrarDatos("spu_mostrar_prodStock",
                prodsTable,
                new List<string> { },
                new List<object> { },
                false
                );
        }

        private void nuevaVtaBtn_Click(object sender, EventArgs e)
        {
            idVtaInp.Text = controladores.getLastID("spu_id_nueva_venta").ToString();
            fechaVtaInp.Text = DateTime.Now.ToString();
            importeVtaInp.Text = 0.00.ToString();
            userInpTxt.Text = frmLogin.username.ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idVtaInp.Text, out int idVta) && decimal.TryParse(importeVtaInp.Text, out decimal imp))
            {
                Venta venta = new Venta(idVta, DateTime.Now.ToUniversalTime(), Convert.ToInt32(clientSelect.SelectedValue?.ToString()) ,imp, frmLogin.id);
                controladores.subirDatos("spu_cargar_venta",
                new List<string> { "@id_venta", "@fecha", "@id_cliente", "@id_usuario" },
                new List<object> { venta.id_venta, venta.fecha, venta.id_cliente,  venta.id_cliente },
                'A'
                );

                MessageBox.Show("Para añadir productos al carrito, simplemente busque y seleccione en la grilla el producto que quiere, seleccione la cantidad y luego apriete en añadir producto", "TUTORIAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                cantTxt.Visible = true;
                prodsTxt.Visible = true;
                addProdBtn.Visible = true;
                searchProdInp.Visible = true;
                searchProdInp.Visible = true;
                buscarProdTxt.Visible = true;
                clientsImg.Visible = true;
                cantSelect.Visible = true;
                deleteProdBtn.Visible = true;
                cancelarVtaBtn.Visible = true;
                closeVtaBtn.Visible = true;

                searchProdInp.Focus();
            }
        }

        private void searchProdInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Producto producto = new Producto(0, searchProdInp.Text, 0, 0);
            controladores.MostrarDatos("spu_buscar_producto",
                prodsTable,
                new List<string> { "@desc" },
                new List<object> { producto.descripcion },
                true
                );
        }

        private void prodsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<int> cantProd = new List<int>();
            if (e.RowIndex == -1)
            {
                return;
            }

            if (int.TryParse(prodsTable.Rows[e.RowIndex].Cells[2].Value.ToString(), out int stock))
            {
                for (int i = 0; i < stock; i++)
                {
                    cantProd.Add(i+1);
                }
            }

            Producto prod = new Producto(Convert.ToInt32(prodsTable.Rows[e.RowIndex].Cells[0].Value),
                Convert.ToString(prodsTable.Rows[e.RowIndex].Cells[1].Value),
                Convert.ToInt32(prodsTable.Rows[e.RowIndex].Cells[2].Value),
                Convert.ToDecimal(prodsTable.Rows[e.RowIndex].Cells[3].Value)
                );


            cantSelect.DataSource = cantProd;

        }

        private void cancelarVtaBtn_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(Convert.ToInt32(idVtaInp.Text), DateTime.Now.ToUniversalTime(), Convert.ToInt32(clientSelect.SelectedValue?.ToString()), Convert.ToDecimal(importeVtaInp.Text), frmLogin.id);

            DialogResult response = MessageBox.Show("¿Está seguro de que quiere cancelar la venta?", "CANCELAR VENTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (response == DialogResult.OK)
            {
                controladores.subirDatos("spu_cancelar_detalle_vta",
                    new List<string> { "@id_Vta" },
                    new List<object> { venta.id_venta },
                    'E'
                    );

                controladores.subirDatos("spu_eliminar_venta",
                    new List<string> { "@idVta" },
                    new List<object> { venta.id_venta },
                    'E'
                    );

                controladores.MostrarDatos("spu_mostrar_detalle_venta",
                    VentaTable,
                    new List<string> { "@id_vta" },
                    new List<object> { venta.id_venta },
                    true
                    );

                DataTable productos = controladores.getData("spu_mostrar_prodStock",
                    new List<string> { },
                    new List<string> { },
                    'N'
                    );

                prodsTable.DataSource = productos;

                controladores.LimpiarCampos(new List<Bunifu.UI.WinForms.BunifuTextBox> { idVtaInp, importeVtaInp, userInpTxt });
            }                                                                            
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {

            Producto prod = new Producto(Convert.ToInt32(prodsTable.CurrentRow.Cells[0].Value),
                Convert.ToString(prodsTable.CurrentRow.Cells[1].Value),
                Convert.ToInt32(prodsTable.CurrentRow.Cells[2].Value),
                Convert.ToDecimal(prodsTable.CurrentRow.Cells[3].Value)
                );

            DetalleVta detVta = new DetalleVta(controladores.getLastID("spu_id_nuevo_detalleVta"),
                Convert.ToInt32(idVtaInp.Text), prod.codigo, prod.precio,
                Convert.ToInt32(cantSelect.Text),
                prod.precio * Convert.ToInt32(cantSelect.Text)
                );

            controladores.subirDatos("spu_nuevo_detalle_vta",
                new List<string> { "@id_dtaVta", "@id_venta", "@codigo", "@precio", "@cantidad",
                    "@precio_r" },
                new List<object> { detVta.id_detalle_venta, detVta.id_venta,
                    detVta.codigo,
                    detVta.precio,
                    detVta.cantidad,
                    detVta.precio_r
                },
                'A'
                );


            controladores.MostrarDatos("spu_mostrar_detalle_venta",
                VentaTable,
                new List<string> { "@id_vta" },
                new List<object> { Convert.ToInt32(idVtaInp.Text) },
                true
                );

            DataTable productos = controladores.getData("spu_mostrar_prodStock",
                new List<string> { },
                new List<string> { },
                'N'
                );

            int ultFila = prodsTable.Rows.Count;

            prodsTable.DataSource = productos;

            int filaCount = prodsTable.Rows.Count;
            decimal total = 0;

            foreach (DataGridViewRow row in VentaTable.Rows)
            {
                if (!row.IsNewRow && row.Cells[6].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[6].Value);
                }
            }

            importeVtaInp.Text = total.ToString();

        }

        private void closeVtaBtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "¿Está seguro de cerrar la venta a " + clientSelect.Text + " por $" + importeVtaInp.Text + "?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (response == DialogResult.Yes)
            {
                controladores.subirDatos("spu_actualizar_ventas",
                    new List<string> { "@id_venta", "@id_cliente", "@importe" },
                    new List<object>
                    {
                        idVtaInp.Text,
                        Convert.ToInt32(clientSelect.SelectedValue?.ToString()),
                        Convert.ToDecimal(importeVtaInp.Text)
                    },
                    'U'
                    );

                controladores.LimpiarCampos( new List<BunifuTextBox> { idVtaInp, importeVtaInp } );

                VentaTable.DataSource = null;

                DataTable productos = controladores.getData("spu_mostrar_prodStock",
                    new List<string> { },
                    new List<string> { },
                    'N'
                    );

                prodsTable.DataSource = productos;
            }

        }

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            controladores.subirDatos("spu_eliminar_prod_detVta",
                new List<string> { "@codProd" },
                new List<object> { VentaTable.CurrentRow.Cells[2].Value },
                'E'
                );

            controladores.MostrarDatos("spu_mostrar_detalle_venta",
                VentaTable,
                new List<string> { "@id_vta" },
                new List<object> { Convert.ToInt32(idVtaInp.Text) },
                true
                );

            DataTable productos = controladores.getData("spu_mostrar_prodStock",
                new List<string> { },
                new List<string> { },
                'N'
                );

            prodsTable.DataSource = productos;
        }
    }
}
