using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmOperacion : Form
    {
        public frmOperacion()
        {
            InitializeComponent();

        }

        private void frmOperacion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        //Método Mostrar
        private void Mostrar()
        {





            this.datalistadoOperaciones.DataSource = NOperacion.Mostrar();



            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);
        }



        //Método BuscarFecha
        private void BuscarFecha()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/




            lblCantidadOperaciones.Text = "Total de Operaciones: " + Convert.ToString(datalistadoOperaciones.Rows.Count);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
