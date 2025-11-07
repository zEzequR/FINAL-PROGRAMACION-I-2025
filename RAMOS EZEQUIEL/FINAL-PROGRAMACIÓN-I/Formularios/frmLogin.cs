using Bunifu.UI.WinForms;
using FINAL_PROGRAMACIÓN_I.Clases;
using FINAL_PROGRAMACIÓN_I.Formularios;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_PROGRAMACIÓN_I
{
    public partial class frmLogin : Form
    {
        public static string username;
        Controladores Controladores = new Controladores();
        Usuario user = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void WinCtrlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinCtrlBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void passwrdHid_CheckedChanged(object sender, EventArgs e)
        {
            if (passwrdHid.Checked == true)
            {
                passwrdInp.PasswordChar = '\0';
            }
            else
            {
                passwrdInp.PasswordChar = '●';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(passwrdInp.Text, out int psw))
            {
                user = user.setUsuario(userInp.Text, psw);

                System.Diagnostics.Debug.WriteLine("Usuario: " + user.usuario + " Contraseña: " + user.psw);

                bool response = Controladores.Logincomparision("spu_login",
                    new List<string> { "@usuario", "@psw" },
                    new List<object> { user.usuario, user.psw });

                if (response)
                {
                    username = user.usuario;
                    MessageBox.Show("Bienvenido " + userInp.Text, "Sesión inicada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                    frmMain main = new frmMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                }
            }
            else
            {
                MessageBox.Show("La contraseña deben ser números. Por favor, intente nuevamente.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                return;
            }

        }
    }
}
