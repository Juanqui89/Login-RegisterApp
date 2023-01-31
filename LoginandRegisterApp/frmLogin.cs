//
//Id de estudiante: 181091673
//Nombre y Apellidos de estudiante: Juan Carlos Serrano Rodríguez
//Nombre de la Universidad: EDP University
//Código y título del curso: ITP-4385 - Programación Orientada a Objetos II
//Nombre de la aplicacion: RegistroClientes
//Nombre del programa: Login and Register App
//Fecha de creación: 14-Octubre-2021
//Describción general: Programa que permite Registrar o Logear al usuario.
//					   
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginandRegisterApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
