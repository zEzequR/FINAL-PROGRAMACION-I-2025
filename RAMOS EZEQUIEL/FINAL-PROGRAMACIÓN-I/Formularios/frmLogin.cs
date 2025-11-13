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
        public static int id;
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
                int ID = Controladores.getuserID("spu_get_id_usuario", userInp.Text);

                user = user.setUsuario(ID, userInp.Text, psw);

                System.Diagnostics.Debug.WriteLine("ID: " + user.id_usuario + "Usuario: " + user.usuario + " Contraseña: " + user.psw);

                Console.WriteLine("aca");
                bool response = Controladores.Logincomparision("spu_login",
                    new List<string> { "@usuario", "@psw" },
                    new List<object> { user.usuario, user.psw });

                if (response)
                {
                    username = user.usuario;
                    id = user.id_usuario;
                    MessageBox.Show("Bienvenido " + userInp.Text, "Sesión inicada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                    frmMain main = new frmMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                    userInp.Focus();
                }
            }
            else
            {
                MessageBox.Show("La contraseña deben ser números. Por favor, intente nuevamente.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Controladores.LimpiarCampos(new List<BunifuTextBox> { userInp, passwrdInp });
                userInp.Focus();
                return;
            }

        }
    }
}
