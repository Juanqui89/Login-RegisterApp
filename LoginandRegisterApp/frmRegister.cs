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
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.VisualBasic;

namespace LoginandRegisterApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {

                txtName.Text = "";
                txtLastName.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void Conexion()
        {
            SQLiteConnection Con = new SQLiteConnection("Data Source = C://Users//juanq//source//repos//LoginandRegisterApp//LoginandRegisterApp//db.sqlite;cache=share;");
            Con.Open();
            string Conexion = "select from dbLogin.sqlite";
            SQLiteDataReader dr = new SQLiteCommand(Conexion, Con).ExecuteReader();

            while (dr.Read())
            {
                string txtName = Convert.ToString(dr[0]);
                string txtLastName = dr.GetString(1);
                string txtUsername = dr.GetString(2);
                string txtPassword = Convert.ToString(dr[3]);
                string txtConfirmPassword = Convert.ToString(dr[4]);

                Console.WriteLine("txtName : {0}", "txtLastName: {1}", "txtUsername: {2}", "txtPassword: {3}", "txtConfirmPassword: {4}", txtName, txtLastName, txtUsername, txtPassword, txtConfirmPassword);
            }
            Console.ReadKey();
            Con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
