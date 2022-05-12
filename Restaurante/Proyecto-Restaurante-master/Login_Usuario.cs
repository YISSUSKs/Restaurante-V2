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
using MySql.Data.MySqlClient;

namespace Proyecto_Restaurante
{
    public partial class Login_Usuario : Form
    {
        menu_control menu;
        string usuario;
        string password;
        public Login_Usuario()
        {
            InitializeComponent();


        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            usuario = "Jesus";
            password = "1234";

            if ((txt_Usuario.Text != "") && (txt_Contraseña.Text != ""))
            {
                if ((txt_Usuario.Text == usuario) && (txt_Contraseña.Text == password))
                {
                    menu = new menu_control();
                    menu.Size = new Size(1000, 800);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta!! Intentelo de nuevo");

                    txt_Usuario.Text = "";
                    txt_Contraseña.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar los datos solicitados!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
