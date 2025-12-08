using FINAL_PROGRAMACIÓN_I.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROGRAMACIÓN_I.Formularios
{
    public partial class frmMain : Form
    {
        Controladores controladores = new Controladores();
        public frmMain()
        {
            InitializeComponent();
            barTxt.Text = "Conectado: " + frmLogin.username;
            timer1.Start();
        }
        private void WinCtrlBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WinCtrlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmClientes(), this);
            WinCtrlBoxTxt.Text = "Final Programación I - Clientes";
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmProductos(), this);
            WinCtrlBoxTxt.Text = "Final Programación I - Productos";
        }

        private void btnVtas_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmVentas(), this);
            WinCtrlBoxTxt.Text = "Final Programación I - Ventas";
        }

        private void proveedoresBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmProveedores(), this);
            WinCtrlBoxTxt.Text = "Final Programación I - Proveedores";
        }

        private void askVtasBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmConsultarVentas(), this);
            WinCtrlBoxTxt.Text = "Final Programación I - Consultar Ventas";
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Está seguro que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechaBarTxt.Text = DateTime.Now.ToUniversalTime().ToString();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            string procedureName = "spu_backup";
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al realizar el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
