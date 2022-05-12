using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_Restaurante
{
    class conexion
    {
        public void conexion()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "restaurante"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conn = new MySqlConnection
                    (cadenaConexion);
                conn.Open();
                MessageBox.Show("111");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar:" + ex.Message);

            }

        }
    }
}
