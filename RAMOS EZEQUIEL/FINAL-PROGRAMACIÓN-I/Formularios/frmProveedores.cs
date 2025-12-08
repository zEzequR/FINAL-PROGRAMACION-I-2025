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
    public partial class frmProveedores : Form
    {
        Controladores controladores = new Controladores();
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            controladores.MostrarDatos("spu_mostrar_proveedores",
                provTable,
                new List<string> { },
                new List<object> { },
                false
                );
        }

        private void provTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idProvInp.Text = provTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomProvInp.Text = provTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            telProvInp.Text = provTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailNomInp.Text = provTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Agregar";

            idProvInp.Text = controladores.getLastID("spu_id_nuevo_proveedor").ToString();

            idProvInp.Enabled = false;
            nomProvInp.Enabled = true;
            telProvInp.Enabled = true;
            emailNomInp.Enabled = true;

            nomProvInp.Focus();

            ResetAndDisableCheckboxes();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Modificar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idProvInp,
            nomProvInp,
            telProvInp,
            emailNomInp
            });

            idProvInp.Enabled = false;
            nomProvInp.Enabled = true;
            telProvInp.Enabled = true;
            emailNomInp.Enabled = true;

            ResetAndDisableCheckboxes();
        }

        private void verXBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Ver";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idProvInp,
            nomProvInp,
            telProvInp,
            emailNomInp
            });

            idProvInp.Enabled = true;
            nomProvInp.Enabled = true;
            telProvInp.Enabled = true;
            emailNomInp.Enabled = true;

            EnableAndResetCheckboxesForView();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Eliminar";

            controladores.LimpiarCampos(new List<BunifuTextBox> { idProvInp,
            nomProvInp,
            telProvInp,
            emailNomInp
            });

            idProvInp.Enabled = false;
            nomProvInp.Enabled = false;
            telProvInp.Enabled = false;
            emailNomInp.Enabled = false;

            ResetAndDisableCheckboxes();
        }

        private void verTodosCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verTodosCheckbox.Checked)
            {
                verXNomCheckbox.Checked = false;
                verXIDCheckbox.Checked = false;
                verXTelCheckbox.Checked = false;
                verXEmailCheckbox.Checked = false;
            }
        }

        private void verXIDCheckbox_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXIDCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXNomCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXNomCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXTelCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXTelCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXEmailCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (verXEmailCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dtProveedores = (DataTable)provTable.DataSource;

            if (dtProveedores.Columns.Contains("Teléfono"))
            {
                dtProveedores.Columns["Teléfono"].ColumnName = "Telefono";
            }

            frmReportes frmReportes = new frmReportes(this, dtProveedores);
            frmReportes.ShowDialog();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (confirmBtn.Text)
            {
                case "Agregar":
                    if (int.TryParse(idProvInp.Text, out int id))
                    {
                        Proveedor proveedor = new Proveedor(id, nomProvInp.Text, telProvInp.Text, emailNomInp.Text);

                        controladores.subirDatos("spu_cargar_proveedores",
                            new List<string> { "@id_proveedor", "@nombre_Proveedor", "@telefono", "@email" },
                            new List<object> { proveedor.id_proveedor, proveedor.nombre_proveedor, proveedor.telefono, proveedor.email },
                            'A');

                        MessageBox.Show("Proveedor agregado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        controladores.LimpiarCampos(new List<BunifuTextBox> { nomProvInp,
                            telProvInp,
                            emailNomInp
                            });

                        idProvInp.Text = (int.Parse(idProvInp.Text) + 1).ToString();

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_proveedores",
                            provTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );

                        break;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error desconocido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        controladores.LimpiarCampos(new List<BunifuTextBox> { nomProvInp,
                            telProvInp,
                            emailNomInp
                            });
                    }
                    break;
                case "Eliminar":
                    if (int.TryParse(idProvInp.Text, out int id2))
                    {
                        Proveedor proveedor = new Proveedor(id2, nomProvInp.Text, telProvInp.Text, emailNomInp.Text);

                        controladores.subirDatos("spu_eliminar_proveedores",
                            new List<string> { "@id_proveedor" },
                            new List<object> { proveedor.id_proveedor },
                            'E');

                        MessageBox.Show("Producto eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        controladores.LimpiarCampos(new List<BunifuTextBox> { idProvInp, 
                            nomProvInp,
                            telProvInp,
                            emailNomInp
                            });

                        confirmBtn.Text = "-";


                        controladores.MostrarDatos("spu_mostrar_proveedores",
                            provTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un proveedor de la grilla para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Modificar":
                    if (int.TryParse(idProvInp.Text, out int id3))
                    {
                        Proveedor proveedor = new Proveedor(id3, nomProvInp.Text, telProvInp.Text, emailNomInp.Text);

                        controladores.subirDatos("spu_modificar_proveedores",
                            new List<string> { "@id_proveedor", "@nombre_Proveedor", "@telefono", "@email" },
                            new List<object> { proveedor.id_proveedor, proveedor.nombre_proveedor, proveedor.telefono, proveedor.email },
                            'U');

                        MessageBox.Show("Proveedor modificado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        controladores.LimpiarCampos(new List<BunifuTextBox> { idProvInp,
                            nomProvInp,
                            telProvInp,
                            emailNomInp
                            });

                        confirmBtn.Text = "-";

                        controladores.MostrarDatos("spu_mostrar_proveedores",
                            provTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, seleccione un proveedor de la grilla para modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Ver":

                    int.TryParse(idProvInp.Text, out int id4);
                    string nombreProv = nomProvInp.Text;
                    string telProv = telProvInp.Text;
                    string emailProv = emailNomInp.Text;


                    Proveedor prov = new Proveedor(id4, nombreProv, telProv, emailProv);

                    if (verTodosCheckbox.Checked)
                    {
                        controladores.MostrarDatos("spu_mostrar_proveedores",
                            provTable,
                            new List<string> { },
                            new List<object> { },
                            false
                            );
                    }
                    else
                    {
                        controladores.MostrarDatos("spu_mostrar_proveedores",
                            provTable,
                            new List<string> { "@id_proveedor", "@nombre_Proveedor", "@telefono", "@email" },
                            new List<object> {
                                verXIDCheckbox.Checked ? (object)prov.id_proveedor : DBNull.Value,
                                verXNomCheckbox.Checked ? (object)prov.nombre_proveedor : DBNull.Value,
                                verXTelCheckbox.Checked ? (object)prov.telefono : DBNull.Value,
                                verXEmailCheckbox.Checked ? (object)prov.email : DBNull.Value
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
            verXNomCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXTelCheckbox.Checked = false;
            verXEmailCheckbox.Checked = false;

            verXNomCheckbox.Enabled = false;
            verTodosCheckbox.Enabled = false;
            verXIDCheckbox.Enabled = false;
            verXTelCheckbox.Enabled = false;
            verXEmailCheckbox.Enabled = false;
        }

        private void EnableAndResetCheckboxesForView()
        {
            verXNomCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXTelCheckbox.Checked = false;
            verXEmailCheckbox.Checked = false;

            verXNomCheckbox.Enabled = true;
            verTodosCheckbox.Enabled = true;
            verXIDCheckbox.Enabled = true;
            verXTelCheckbox.Enabled = true;
            verXEmailCheckbox.Enabled = true;
        }
    }
}
