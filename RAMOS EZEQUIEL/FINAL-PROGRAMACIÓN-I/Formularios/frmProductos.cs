using Bunifu.UI.WinForms;
using FINAL_PROGRAMACIÓN_I.Clases;
using FINAL_PROGRAMACIÓN_I.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    public partial class frmProductos : Form
    {
        Controladores controladores = new Controladores();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            controladores.MostrarDatos("spu_mostrar_productos",
                productsTable,
                new List<string> { },
                new List<object> { },
                false
                );

            DataTable Proveedores = controladores.getData("spu_mostrar_proveedores",
                new List<string> { },
                new List<string> { },
                'N'
                );

            List<Proveedor> listProv = new List<Proveedor>();

            foreach (DataRow row in Proveedores.Rows)
            {
                Proveedor prov = new Proveedor(row.Field<int>("ID"),
                    row.Field<string>("Proveedor"),
                    row.Field<string>("Teléfono"),
                    row.Field<string>("Email")
                    );
                listProv.Add(prov);
            }

            provSelect.DataSource = listProv;
            provSelect.DisplayMember = "nombre_Proveedor";
            provSelect.ValueMember = "id_proveedor";

            //REVISAR!!

            //foreach (DataGridViewRow row in productsTable.Rows)
            //{
            //    if (row.Cells[3].Value.ToString() == "0")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.LightCoral;
            //    }
            //}

        }

        private void clientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            codProdInp.Text = productsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            descProdInp.Text = productsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            stockProdInp.Text = productsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            precioProdInp.Text = productsTable.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Agregar";

            codProdInp.Text = controladores.getLastID("spu_id_nuevo_producto").ToString();

            codProdInp.Enabled = false;
            descProdInp.Enabled = true;
            stockProdInp.Enabled = true;
            precioProdInp.Enabled = true;

            descProdInp.Focus();

            ResetAndDisableCheckboxes();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Modificar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { codProdInp,
            descProdInp,
            stockProdInp,
            precioProdInp
            });

            codProdInp.Enabled = false;
            descProdInp.Enabled = true;
            stockProdInp.Enabled = true;
            precioProdInp.Enabled = true;

            ResetAndDisableCheckboxes();

        }

        private void verXBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Ver";

            controladores.LimpiarCampos(new List<BunifuTextBox> { codProdInp,
            descProdInp,
            stockProdInp,
            precioProdInp
            });

            codProdInp.Enabled = true;
            descProdInp.Enabled = true;
            stockProdInp.Enabled = true;
            precioProdInp.Enabled = true;

            EnableAndResetCheckboxesForView();

        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            confirmBtn.Text = "Eliminar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { codProdInp,
            descProdInp,
            stockProdInp,
            precioProdInp
            });

            codProdInp.Enabled = false;
            descProdInp.Enabled = false;
            stockProdInp.Enabled = false;
            precioProdInp.Enabled = false;

            ResetAndDisableCheckboxes();
        }

        private void verTodosCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verTodosCheckbox.Checked)
            {
                verXDescCheckbox.Checked = false;
                verXIDCheckbox.Checked = false;
                verXStockCheckbox.Checked = false;
                verXPrecioCheckbox.Checked = false;
                verXProvCheckBox.Checked = false;
            }
        }

        private void verXIDCheckbox_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXIDCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXDescCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXDescCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXStockCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXStockCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXPrecioCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXPrecioCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXProvCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXProvCheckBox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dtProductos = (DataTable)productsTable.DataSource;

            if (dtProductos.Columns.Contains("Código"))
            {
                dtProductos.Columns["Código"].ColumnName = "Codigo";
            }
            if (dtProductos.Columns.Contains("Descripción"))
            {
                dtProductos.Columns["Descripción"].ColumnName = "Descripcion";
            }

            frmReportes frmReportes = new frmReportes(this, dtProductos);
            frmReportes.ShowDialog();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (confirmBtn.Text)
            {
                case "Agregar":
                    if (int.TryParse(codProdInp.Text, out int id) && int.TryParse(stockProdInp.Text, out int stck) && decimal.TryParse(precioProdInp.Text, out decimal price))
                    {
                        Producto product = new Producto(id, descProdInp.Text, Convert.ToInt32(provSelect.SelectedValue?.ToString()), stck, price);

                        controladores.subirDatos("spu_cargar_productos",
                            new List<string> { "@codigo", "@descripcion", "@stock", "@precio" },
                            new List<object> { product.codigo, product.descripcion,
                                product.stock, product.precio },
                            'A');

                        MessageBox.Show("Producto agregado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { descProdInp,
                            stockProdInp,
                            precioProdInp
                            });

                        codProdInp.Text = (int.Parse(codProdInp.Text) + 1).ToString();

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_productos",
                            productsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error desconocido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { descProdInp,
                            stockProdInp,
                            precioProdInp
                            });
                    }
                    break;
                case "Eliminar":
                    if (int.TryParse(codProdInp.Text, out int id2) && int.TryParse(stockProdInp.Text, out int stck2) && decimal.TryParse(precioProdInp.Text, out decimal price2))
                    {
                        Producto product = new Producto(id2, descProdInp.Text, Convert.ToInt32(provSelect.SelectedValue?.ToString()), stck2, price2);

                        controladores.subirDatos("spu_eliminar_productos",
                            new List<string> { "@codigo" },
                            new List<object> { product.codigo },
                            'E');

                        MessageBox.Show("Producto eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { codProdInp ,
                            descProdInp,
                            stockProdInp,
                            precioProdInp
                            });

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_productos",
                            productsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un producto de la grilla para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Modificar":
                    if (int.TryParse(codProdInp.Text, out int id3) && int.TryParse(stockProdInp.Text, out int stck3) && decimal.TryParse(precioProdInp.Text, out decimal price3))
                    {
                        Producto product = new Producto(id3, descProdInp.Text, Convert.ToInt32(provSelect.SelectedValue?.ToString()), stck3, price3);

                        controladores.subirDatos("spu_modificar_productos",
                             new List<string> { "@codigo", "@descripcion", "@stock", "@precio" },
                             new List<object> { product.codigo, product.descripcion,
                             product.stock, product.precio },
                             'U');

                        MessageBox.Show("Producto modificado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { codProdInp ,
                            descProdInp,
                            stockProdInp,
                            precioProdInp
                            });

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_productos",
                            productsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un producto de la grilla para modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Ver":
                    int.TryParse(codProdInp.Text, out int id4);
                    string descrip = descProdInp.Text;
                    int.TryParse(stockProdInp.Text, out int stock4);
                    decimal.TryParse(precioProdInp.Text, out decimal price4);


                    Producto producto = new Producto(id4, descrip, Convert.ToInt32(provSelect.SelectedValue), stock4, price4);

                    if (verTodosCheckbox.Checked)
                    {
                        controladores.MostrarDatos("spu_mostrar_productos",
                            productsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                        );
                    }
                    else
                    {
                        controladores.MostrarDatos("spu_mostrar_productos",
                            productsTable,
                            new List<string> { "@codigo", "@descripcion", "@id_prov", "@stock", "@precio" },
                            new List<object> {
                                verXIDCheckbox.Checked ? (object)producto.codigo : DBNull.Value,
                                verXDescCheckbox.Checked ? (object)producto.descripcion : DBNull.Value,
                                verXProvCheckBox.Checked ? (object)producto.id_proveedor : DBNull.Value,
                                verXStockCheckbox.Checked ? (object)producto.stock : DBNull.Value,
                                verXPrecioCheckbox.Checked ? (object)producto.precio : DBNull.Value
                            },
                            true
                        );
                    }
                    break;
                default:
                    MessageBox.Show("Porfavor, seleccione una opción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ResetAndDisableCheckboxes()
        {
            verXDescCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXStockCheckbox.Checked = false;
            verXPrecioCheckbox.Checked = false;
            verXProvCheckBox.Checked = false;

            verXDescCheckbox.Enabled = false;
            verTodosCheckbox.Enabled = false;
            verXIDCheckbox.Enabled = false;
            verXStockCheckbox.Enabled = false;
            verXStockCheckbox.Enabled = false;
            verXPrecioCheckbox.Enabled = false;
            verXProvCheckBox.Enabled = false;
        }

        private void EnableAndResetCheckboxesForView()
        {
            verXDescCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXStockCheckbox.Checked = false;
            verXPrecioCheckbox.Checked = false;
            verXProvCheckBox.Checked = false;

            verXDescCheckbox.Enabled = true;
            verTodosCheckbox.Enabled = true;
            verXIDCheckbox.Enabled = true;
            verXStockCheckbox.Enabled = true;
            verXPrecioCheckbox.Enabled = true;
            verXProvCheckBox.Enabled = true;
        }
    }
}
