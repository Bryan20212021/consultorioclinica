﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmHistoria : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;


        public frmHistoria()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.dtpFechaConsulta, "Ingrese la fecha de consulta");

            this.ttMensaje.SetToolTip(this.txtRazonConsulta, "Ingrese la razon de la consulta");
            this.ttMensaje.SetToolTip(this.txtEnfermedadActual, "Ingrese la enfermedad actual");
            this.ttMensaje.SetToolTip(this.txtHistoriaPersonal, "Ingrese la historia personal");
            this.ttMensaje.SetToolTip(this.txtHistoriaFamiliar, "Ingrese la historia familiar");
            this.ttMensaje.SetToolTip(this.txtTratamiento_Actual, "Ingrese el tratamiento actual");
            this.ttMensaje.SetToolTip(this.txtExamenFisico, "Ingrese el examen fisico");
            this.ttMensaje.SetToolTip(this.txtLaboratorio, "Ingrese el laboratorio");
            this.ttMensaje.SetToolTip(this.txtecg, "Ingrese el ecg paciente");
            this.ttMensaje.SetToolTip(this.txtRayos_X, "Ingrese los rayos X del paciente");
            this.ttMensaje.SetToolTip(this.txtEcocardiograma, "Ingrese el ecocardiograma del paciente");
            this.ttMensaje.SetToolTip(this.txtPlanEstudio, "Ingrese el plan de estudio");
            this.ttMensaje.SetToolTip(this.txtTerapeutico, "Ingrese el plan terapeutico");

            this.btnAnular.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmHistoria_Load(object sender, EventArgs e)
        {
            this.MostrarHistoriasActivas();
            this.MostrarHistoriasAnuladas();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        DataTable dbdataset;


        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Clinica", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {

            this.txtPaciente.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            this.txtServicio.Text = string.Empty;
            this.txtMostrarPeso.Text = string.Empty;
            this.txtMostrarTalla.Text = string.Empty;
            this.txtRazonConsulta.Text = string.Empty;
            this.txtEnfermedadActual.Text = string.Empty;
            this.txtHistoriaPersonal.Text = string.Empty;
            this.txtHistoriaFamiliar.Text = string.Empty;
            this.txtTratamiento_Actual.Text = string.Empty;
            this.txtExamenFisico.Text = string.Empty;
            this.txtLaboratorio.Text = string.Empty;
            this.txtecg.Text = string.Empty;
            this.txtRayos_X.Text = string.Empty;
            this.txtEcocardiograma.Text = string.Empty;
            this.txtPlanEstudio.Text = string.Empty;
            this.txtTerapeutico.Text = string.Empty;



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtPaciente.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtServicio.ReadOnly = !valor;
            this.txtMostrarPeso.ReadOnly = !valor;
            this.txtMostrarTalla.ReadOnly = !valor;
            this.txtEnfermedadActual.ReadOnly = !valor;
            this.txtRazonConsulta.ReadOnly = !valor;
            this.txtHistoriaPersonal.ReadOnly = !valor;
            this.txtHistoriaFamiliar.ReadOnly = !valor;
            this.txtTratamiento_Actual.ReadOnly = !valor;
            this.txtExamenFisico.ReadOnly = !valor;
            this.txtLaboratorio.ReadOnly = !valor;
            this.txtecg.ReadOnly = !valor;
            this.txtRayos_X.ReadOnly = !valor;
            this.txtEcocardiograma.ReadOnly = !valor;
            this.txtPlanEstudio.ReadOnly = !valor;
            this.txtTerapeutico.ReadOnly = !valor;



            //this.btnLimpiar.Enabled = valor;

        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {

            this.datalistadohistorias.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
            this.datalistadohistorias.Columns[1].Visible = true;

        }





        //Método Mostrar
        private void Mostrar()
        {


            string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.peso, Paciente.talla, Cita.idusuario, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Costo, Cita.Estado from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio where Cita.estado = 'Activo'; ", conDataBase);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataListado.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }





            this.OcultarColumnas();
            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método Mostrar
        private void MostrarHistoriasActivas()
        {


            string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.estado = 'Activo'; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblHistoriasActivas.Text = "Total de Historias : " + Convert.ToString(datalistadohistorias.Rows.Count);
        }



        //Método Mostrar
        private void MostrarHistoriasAnuladas()
        {


            string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.estado = 'Inactivo'; ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadoMuertos.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblCantidadArchivosMuertos.Text = "Total de Historias: " + Convert.ToString(datalistadoMuertos.Rows.Count);
        }


        //Método BuscarNombre
        private void BuscarNombre()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Paciente LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarServicio
        private void BuscarServicio()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Servicio LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarTalla
        private void BuscarTalla()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("talla LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método BuscarPeso
        private void BuscarPeso()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("peso LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarPeso
        private void BuscarCedula()
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("num_cedula LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;





            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }



        //Método Mostrar
        private void MostrarFechas(string fecha1, string fecha2)
        {


            string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula, Paciente.peso, Paciente.talla, Cita.idusuario, Cita.fecha, Cita.idservicio, Servicio.nombre as Servicio, Cita.Costo, Cita.Estado from Cita inner join dbo.Paciente ON dbo.Cita.idpaciente = dbo.Paciente.idpaciente INNER JOIN dbo.Servicio ON dbo.Cita.idservicio = dbo.Servicio.idservicio where Cita.fecha between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataListado.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }





            this.OcultarColumnas();
            lblTotal.Text = "Total de Citas: " + Convert.ToString(dataListado.Rows.Count);
        }


        //Método Mostrar
        private void MostrarFechasActivas(string fecha1, string fecha2)
        {


            /*string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.fecha_consulta between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadohistorias.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblHistoriasActivas.Text = "Total de Historias : " + Convert.ToString(datalistadohistorias.Rows.Count);*/
        }



        //Método Mostrar
        private void MostrarFechasAnuladas(string fecha1, string fecha2)
        {


            /*string Cn = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlConnection conDataBase = new SqlConnection(Cn);
            //SqlCommand cmdDataBase = new SqlCommand("select Cita.idcita, Cita.idpaciente, Paciente.nombre, Usuario.idusuario, Usuario.nombre, Usuario.cargo from Cita inner join Paciente on Cita.idpaciente = Paciente.idpaciente inner join Usuario on Cita.idusuario = Usuario.idusuario ", conDataBase);
            //SqlCommand cmdDataBase = new SqlCommand("select * from Cita where estado = 'Activo'; ", conDataBase);
            SqlCommand cmdDataBase = new SqlCommand("SELECT Historia.idhistoria, Historia.idcita, Cita.costo, Cita.idpaciente, Paciente.nombre as Paciente, Paciente.tipo_cedula, Paciente.num_cedula,Cita.idservicio, Servicio.nombre AS Servicio, Historia.fecha_consulta, Historia.razon_consulta, Historia.enfermedad_actual, Historia.historia_familiar, Historia.historia_personal, Historia.tratamiento_actual, Historia.examen_fisico, Historia.ecg, Historia.laboratorio, Historia.rayos_x, Historia.ecocardiograma, Historia.plan_estudio, Historia.plan_terapeutico, Historia.estado FROM Cita INNER JOIN Historia ON Cita.idcita = Historia.idcita INNER JOIN Paciente ON Cita.idpaciente = Paciente.idpaciente INNER JOIN Servicio ON Cita.idservicio = Servicio.idservicio where Historia.fecha_consulta between '" + fecha1 + "' and '" + fecha2 + "' ", conDataBase);





            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                datalistadoMuertos.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ex)
            {


                MessageBox.Show("Ha ocurrido un error");
            }






            lblCantidadArchivosMuertos.Text = "Total de Historias: " + Convert.ToString(datalistadoMuertos.Rows.Count);*/
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Paciente"].Value);
            this.lblCodigoPaciente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpaciente"].Value);
            this.lblCodigoCita.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcita"].Value);
            this.cmbTipoCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cedula"].Value);
            this.txtCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_cedula"].Value);
            this.txtServicio.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Servicio"].Value);
            this.txtMostrarPeso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["peso"].Value);
            this.txtMostrarTalla.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["talla"].Value);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Paciente"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Servicio"))
            {
                this.BuscarServicio();
            }

            else if (this.cblBusqueda.Text.Equals("Talla"))
            {
                this.BuscarTalla();
            }

            else if (this.cblBusqueda.Text.Equals("Peso"))
            {
                this.BuscarPeso();
            }

            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Paciente"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Servicio"))
            {
                this.BuscarServicio();
            }

            else if (this.cblBusqueda.Text.Equals("Talla"))
            {
                this.BuscarTalla();
            }

            else if (this.cblBusqueda.Text.Equals("Peso"))
            {
                this.BuscarPeso();
            }

            else if (this.cblBusqueda.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPaciente.Focus();

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtPaciente.Text == string.Empty)
                {
                    MessageBox.Show("No puede dejar campos vacios o sin seleccionar. ", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.tabControl1.SelectedIndex = 1;
                }
                else
                {



                    if (this.IsNuevo)
                    {


                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "insert into Historia (idcita, fecha_consulta, razon_consulta, enfermedad_actual, historia_familiar, historia_personal, tratamiento_actual, examen_fisico, laboratorio, ecg, rayos_x, ecocardiograma, plan_estudio, plan_terapeutico, estado) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15);";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoCita.Text);
                        SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
                        SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
                        SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
                        SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
                        SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
                        SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
                        SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
                        SqlCmd.Parameters.AddWithValue("@d13", this.txtPlanEstudio.Text);
                        SqlCmd.Parameters.AddWithValue("@d14", this.txtTerapeutico.Text);
                        SqlCmd.Parameters.AddWithValue("@d15", this.cmbEstadoHistoria.Text);





                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                    }
                    else
                    {

                        SqlConnection SqlCon = new SqlConnection();



                        //Código
                        SqlCon.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                        SqlCon.Open();
                        //Establecer el Comando
                        SqlCommand SqlCmd = new SqlCommand();
                        SqlCmd.Connection = SqlCon;
                        SqlCmd.CommandText = "update Historia set idcita = @d1, fecha_consulta = @d2, razon_consulta = @d3, enfermedad_actual = @d4, historia_familiar = @d5, historia_personal = @d6, tratamiento_actual = @d7, examen_fisico = @d8, laboratorio = @d9, ecg = @d10, rayos_x = @d11, ecocardiograma = @d12, plan_estudio = @d13, plan_terapeutico = @d14, estado = @d15 where idhistoria=@d15";
                        //SqlCmd.CommandType = CommandType.StoredProcedure;



                        //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                        SqlCmd.Parameters.AddWithValue("@d1", this.lblCodigoCita.Text);
                        SqlCmd.Parameters.AddWithValue("@d2", this.dtpFechaConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d3", this.txtRazonConsulta.Text);
                        SqlCmd.Parameters.AddWithValue("@d4", this.txtEnfermedadActual.Text);
                        SqlCmd.Parameters.AddWithValue("@d5", this.txtHistoriaFamiliar.Text);
                        SqlCmd.Parameters.AddWithValue("@d6", this.txtHistoriaPersonal.Text);
                        SqlCmd.Parameters.AddWithValue("@d7", this.txtTratamiento_Actual.Text);
                        SqlCmd.Parameters.AddWithValue("@d8", this.txtExamenFisico.Text);
                        SqlCmd.Parameters.AddWithValue("@d9", this.txtLaboratorio.Text);
                        SqlCmd.Parameters.AddWithValue("@d10", this.txtecg.Text);
                        SqlCmd.Parameters.AddWithValue("@d11", this.txtRayos_X.Text);
                        SqlCmd.Parameters.AddWithValue("@d12", this.txtEcocardiograma.Text);
                        SqlCmd.Parameters.AddWithValue("@d13", this.txtPlanEstudio.Text);
                        SqlCmd.Parameters.AddWithValue("@d14", this.txtTerapeutico.Text);
                        SqlCmd.Parameters.AddWithValue("@d15", this.lblCodigoHistoria.Text);





                        //Ejecutamos nuestro comando

                        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



                    }


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Insertó de forma correcta la historia clinica");
                        this.OperacionInsertarHistoria();
                    }
                    else
                    {
                        this.MensajeOk("Se Actualizó de forma correcta la historia clinica");
                        this.OperacionEditarHistoria();
                    }



                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.MostrarHistoriasActivas();
                    this.MostrarHistoriasAnuladas();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.lblCodigoHistoria.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero la historia clinica a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.datalistadohistorias.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.datalistadohistorias.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void datalistadohistorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadohistorias.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)datalistadohistorias.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void datalistadohistorias_DoubleClick(object sender, EventArgs e)
        {
            this.lblCodigoHistoria.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["idhistoria"].Value);
            this.dtpFechaConsulta.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["fecha_consulta"].Value);
            this.txtRazonConsulta.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["razon_consulta"].Value);
            this.txtEnfermedadActual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["enfermedad_actual"].Value);
            this.txtHistoriaFamiliar.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_familiar"].Value);
            this.txtHistoriaPersonal.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_personal"].Value);

            this.txtTratamiento_Actual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["tratamiento_actual"].Value);
            this.txtExamenFisico.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["examen_fisico"].Value);
            this.txtHistoriaFamiliar.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["historia_familiar"].Value);
            this.txtEnfermedadActual.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["enfermedad_actual"].Value);
            this.txtLaboratorio.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["laboratorio"].Value);
            this.txtecg.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["ecg"].Value);
            this.txtRayos_X.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["rayos_x"].Value);
            this.txtEcocardiograma.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["ecocardiograma"].Value);
            this.txtPlanEstudio.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_estudio"].Value);
            this.txtTerapeutico.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["plan_terapeutico"].Value);
            this.cmbEstadoHistoria.Text = Convert.ToString(this.datalistadohistorias.CurrentRow.Cells["estado"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular la historia medica?", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in datalistadohistorias.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);



                            SqlConnection SqlCon = new SqlConnection();







                            //Código
                            SqlCon.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
                            SqlCon.Open();
                            //Establecer el Comando
                            SqlCommand SqlCmd = new SqlCommand();
                            SqlCmd.Connection = SqlCon;
                            SqlCmd.CommandText = "update Historia set estado = @d1 where idhistoria = @d2";
                            //SqlCmd.CommandType = CommandType.StoredProcedure;



                            //Sqlcmd.Parameters.AddWithValue("@d1", txtNombreCliente.Text);
                            SqlCmd.Parameters.AddWithValue("@d1", "Inactivo");
                            SqlCmd.Parameters.AddWithValue("@d2", Convert.ToInt32(Codigo));





                            //Ejecutamos nuestro comando

                            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "";







                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente la historia");
                                this.OperacionAnularHistoria();
                                this.MostrarHistoriasAnuladas();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }
                    }
                    this.MostrarHistoriasActivas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void OperacionInsertarHistoria()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado una historia clinica al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarHistoria()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó una historia clinica");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularHistoria()
        {


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=DESKTOP-O96G4O5\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló una historia clinica");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }


    }
}
