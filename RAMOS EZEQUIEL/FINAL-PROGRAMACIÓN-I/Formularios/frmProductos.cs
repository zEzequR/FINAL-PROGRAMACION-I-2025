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
            codProdInp.Text = clientsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            descProdInp.Text = clientsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            stockProdInp.Text = clientsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            precioProdInp.Text = clientsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Agregar";
            ResetAndDisableCheckboxes();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Modificar";
            ResetAndDisableCheckboxes();

        }

        private void verXBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Ver";
            EnableAndResetCheckboxesForView();

        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            confirmBtn.Text = "Eliminar";
            ResetAndDisableCheckboxes();
        }

        private void verTodosCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            // Si marco "Todos", desmarco los otros dos.
            if (verTodosCheckbox.Checked)
            {
                verXDescCheckbox.Checked = false;
                verXIDCheckbox.Checked = false;
                verXStockCheckbox.Checked = false;
                verXPrecioCheckbox.Checked = false;
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

        private void ResetAndDisableCheckboxes()
        {
            verXDescCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXStockCheckbox.Checked = false;
            verXPrecioCheckbox.Checked = false;

            verXDescCheckbox.Enabled = false;
            verTodosCheckbox.Enabled = false;
            verXIDCheckbox.Enabled = false;
            verXStockCheckbox.Enabled = false;
            verXPrecioCheckbox.Enabled = false;
        }

        private void EnableAndResetCheckboxesForView()
        {
            verXDescCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;
            verXStockCheckbox.Checked = false;
            verXPrecioCheckbox.Checked = false;

            verXDescCheckbox.Enabled = true;
            verTodosCheckbox.Enabled = true;
            verXIDCheckbox.Enabled = true;
            verXStockCheckbox.Enabled = true;
            verXPrecioCheckbox.Enabled = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (confirmBtn.Text)
            {
                case "Agregar":
                    Debug.WriteLine("hola");
                    break;
                case "Eliminar":
                    Debug.WriteLine("holi");
                    break;
                case "Modificar":
                    Debug.WriteLine("holu");
                    break;
                case "Ver":
                    Debug.WriteLine("ver");
                    break;
                default:
                    Debug.WriteLine("chau");
                    break;
            }
        }
    }
}
