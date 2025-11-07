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
    }
}
