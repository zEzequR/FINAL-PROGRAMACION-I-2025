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
    public partial class frmClientes : Form
    {
        Controladores controladores = new Controladores();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            controladores.MostrarDatos("spu_mostrar_clientes",
                clientsTable,
                new List<string> { },
                new List<object> { },
                false
                );
        }

        private void clientsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idClientInp.Text = clientsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            clientNameInp.Text = clientsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Agregar";

            idClientInp.Text = controladores.getLastID("spu_id_nuevo_cliente").ToString();

            idClientInp.Enabled = false;
            clientNameInp.Enabled = true;

            clientNameInp.Focus();


            ResetAndDisableCheckboxes();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Modificar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idClientInp });

            idClientInp.Enabled = false;
            clientNameInp.Enabled = true;

            ResetAndDisableCheckboxes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Eliminar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idClientInp, clientNameInp });

            idClientInp.Enabled = false;
            clientNameInp.Enabled= false;

            ResetAndDisableCheckboxes();
        }

        private void verXBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Ver";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idClientInp });

            idClientInp.Enabled = true;
            clientNameInp.Enabled = true;

            EnableAndResetCheckboxesForView();
        }

        private void verTodosCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verTodosCheckbox.Checked)
            {
                verXNombreCheckbox.Checked = false;
                verXIDCheckbox.Checked = false;
            }
        }

        private void verXIDCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXIDCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXNombreCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXNombreCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dtClientes = (DataTable)clientsTable.DataSource;

            if (dtClientes.Columns.Contains("Razón Social"))
            {
                dtClientes.Columns["Razón Social"].ColumnName = "RazonSocial";
            }

            frmReportes frmReportes = new frmReportes(this, dtClientes);
            frmReportes.ShowDialog();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (confirmBtn.Text) 
            {
                case "Agregar":
                    if (int.TryParse(idClientInp.Text, out int id))
                    {
                        Cliente client = new Cliente(id, clientNameInp.Text);

                        controladores.subirDatos("spu_cargar_cliente",
                            new List<string> { "@id_cliente", "@razon_social" },
                            new List<object> { client.id_cliente, client.razon_social },
                            'A');

                        MessageBox.Show("Cliente agregado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { clientNameInp });

                        idClientInp.Text = (int.Parse(idClientInp.Text) + 1).ToString();

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_clientes",
                            clientsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error desconocido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Eliminar":
                    if (int.TryParse(idClientInp.Text, out int id2))
                    {
                        Cliente client = new Cliente(id2, clientNameInp.Text);

                        controladores.subirDatos("spu_eliminar_cliente",
                            new List<string> { "@id_cliente" },
                            new List<object> { client.id_cliente },
                            'E');

                        MessageBox.Show("Cliente eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { idClientInp, clientNameInp });

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_clientes",
                            clientsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un usuario de la grilla para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Modificar":
                    if (int.TryParse(idClientInp.Text, out int id3))
                    {
                        Cliente client = new Cliente(id3, clientNameInp.Text);

                        controladores.subirDatos("spu_actualizar_cliente",
                            new List<string> { "@id_cliente", "@razon_social" },
                            new List<object> { client.id_cliente, client.razon_social },
                            'U');

                        MessageBox.Show("Cliente modificado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { idClientInp, clientNameInp });

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_clientes",
                            clientsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un usuario de la grilla para modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Ver":
                    Debug.WriteLine("ver");
                    int.TryParse(idClientInp.Text, out int id4);
                    string razon_social = clientNameInp.Text;


                    Cliente cliente = new Cliente(id4, razon_social);

                    if (verTodosCheckbox.Checked)
                    {
                        controladores.MostrarDatos("spu_mostrar_clientes",
                            clientsTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        controladores.MostrarDatos("spu_mostrar_clientes",
                            clientsTable,
                            new List<string> { "@id_cliente", "@razon_social" },
                            new List<object> { 
                                verXIDCheckbox.Checked ? (object)cliente.id_cliente : DBNull.Value,
                                verXNombreCheckbox.Checked ? (object)cliente.razon_social : DBNull.Value
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
            verXNombreCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;

            verXNombreCheckbox.Enabled = false;
            verTodosCheckbox.Enabled = false;
            verXIDCheckbox.Enabled = false;
        }

        private void EnableAndResetCheckboxesForView()
        {
            verXNombreCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;

            verXNombreCheckbox.Enabled = true;
            verTodosCheckbox.Enabled = true;
            verXIDCheckbox.Enabled = true;
        }
    }
}
