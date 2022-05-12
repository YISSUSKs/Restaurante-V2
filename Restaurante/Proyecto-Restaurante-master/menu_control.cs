using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Restaurante
{
    public partial class menu_control : Form
    {
        public menu_control()
        {
            InitializeComponent();
            
        }

        private void btn_Registrar_Empleado_Click(object sender, EventArgs e)
        {
            conexiob_db conectar = new conexiob_db();
            conectar.conexion();
            
        }
    }
}
