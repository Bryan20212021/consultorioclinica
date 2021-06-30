using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRecuperarContrasena : Form
    {



        private static frmRecuperarContrasena _instancia;

        public static frmRecuperarContrasena GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new frmRecuperarContrasena();
            }
            return _instancia;
        }




        public frmRecuperarContrasena()
        {
            InitializeComponent();
        }

        private void frmRecuperarContrasena_Load(object sender, EventArgs e)
        {

        }
    }
}
