using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Proyecto_Restaurante
{
    class conexiob_db
    {

        public int conexion(int desconectar)
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "restaurante"; //Nombre de la base de datos
            string usuario = "root"; //Usuario de acceso a MySQL
            string password = ""; //Contraseña de usuario de acceso a MySQL
            int desconection = 0;

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";
            if(desconection == 0)
            {
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
            else if (desconection == 1) 
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Close();
                desconection = 1;
                return desconection;
            }

        }
    }
}
