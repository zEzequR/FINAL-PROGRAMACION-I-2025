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
             
            ResetAndDisableCheckboxes();
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Modificar";


            ResetAndDisableCheckboxes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Eliminar";

            ResetAndDisableCheckboxes();
        }

        private void verXBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Text = "Ver";

            EnableAndResetCheckboxesForView();
        }

        private void verTodosCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            // Si marco "Todos", desmarco los otros dos.
            if (verTodosCheckbox.Checked)
            {
                verXNombreCheckbox.Checked = false;
                verXIDCheckbox.Checked = false;
            }
        }

        private void verXIDCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            // Si marco "ID" y "Todos" está marcado -> desmarco "Todos".
            if (verXIDCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void verXNombreCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            // Si marco "Nombre" y "Todos" está marcado -> desmarco "Todos".
            if (verXNombreCheckbox.Checked && verTodosCheckbox.Checked)
            {
                verTodosCheckbox.Checked = false;
            }
        }

        private void ResetAndDisableCheckboxes()
        {
            // Usamos únicamente la propiedad Checked para simplificar
            verXNombreCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;

            verXNombreCheckbox.Enabled = false;
            verTodosCheckbox.Enabled = false;
            verXIDCheckbox.Enabled = false;
        }

        private void EnableAndResetCheckboxesForView()
        {
            // Cuando entras al modo Ver, empieza limpio (desmarcado) y habilitado
            verXNombreCheckbox.Checked = false;
            verTodosCheckbox.Checked = false;
            verXIDCheckbox.Checked = false;

            verXNombreCheckbox.Enabled = true;
            verTodosCheckbox.Enabled = true;
            verXIDCheckbox.Enabled = true;
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
