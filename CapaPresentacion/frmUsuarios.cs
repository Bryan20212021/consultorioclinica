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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {

        private bool IsNuevo = false;

        private bool IsEditar = false;


        public frmUsuarios()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombreUsuario, "Ingrese el Nombre del Usuario");

            this.ttMensaje.SetToolTip(this.txtCargo, "Seleccione el cargo del usuario");
            this.ttMensaje.SetToolTip(this.txtEspecialidad, "Ingrese la especialidad del usuario");
            this.ttMensaje.SetToolTip(this.cmbAcceso, "Seleccione el tipo de acceso");
            this.ttMensaje.SetToolTip(this.txtLogin, "Ingrese el nombre de acceso");
            this.ttMensaje.SetToolTip(this.txtClave, "Ingrese la clave del usuario");

            this.btnAnular.Enabled = false;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
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

            this.txtNombreUsuario.Text = string.Empty;
            this.txtCargo.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.cmbAcceso.Text = string.Empty;
            this.txtClave.Text = string.Empty;
            this.txtLogin.Text = string.Empty;
            this.cmbEstado.Text = string.Empty;



        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigoUsuario.ReadOnly = !valor;
            this.txtNombreUsuario.ReadOnly = !valor;
            this.txtCargo.ReadOnly = !valor;
            this.txtEspecialidad.ReadOnly = !valor;
            this.txtClave.ReadOnly = !valor;
            this.txtLogin.ReadOnly = !valor;





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

            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;

        }


        //Método Mostrar
        private void Mostrar()
        {


            this.dataListado.DataSource = NUsuario.Mostrar();


            this.OcultarColumnas();
            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNombre
        private void BuscarNombre()
        {
            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("nombre LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/


            this.dataListado.DataSource = NUsuario.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();


            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void BuscarCargo()
        {

            /*DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cargo LIKE '%{0}%'", this.txtBuscar.Text);
            dataListado.DataSource = DV;*/

            this.dataListado.DataSource = NUsuario.BuscarCargo(this.txtBuscar.Text);
            this.OcultarColumnas();




            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombreUsuario.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrEmpty(txtEspecialidad.Text)
                    || cmbAcceso.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
                {
                    MensajeError("No se pueden dejar campos vacios");


                    if (this.validarExisteUsuario(this.txtLogin.Text) == true)
                    {

                        MensajeError("Hay un usuario con este nombre. Intente con otro.");
                    }

                }
                else
                {



                    if (this.IsNuevo)
                    {


                        if (this.IsNuevo)
                        {


                            rpta = NUsuario.Insertar(this.txtNombreUsuario.Text.Trim().ToUpper(),
                            this.txtCargo.Text.Trim().ToUpper(), this.txtEspecialidad.Text.Trim().ToUpper(),
                            this.cmbAcceso.Text, this.txtLogin.Text.Trim().ToUpper(), this.txtClave.Text.Trim().ToUpper(), this.cmbEstado.Text);





                            // Operacion Insertar


                            /*SqlConnection SqlCon2 = new SqlConnection();




                            SqlCon2.ConnectionString = Conexion.Cn;
                            SqlCon2.Open();

                            SqlCommand SqlCmd2 = new SqlCommand();
                            SqlCmd2.Connection = SqlCon2;
                            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





                            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
                            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo diagnostico al sistema");





                            //Ejecutamos nuestro comando

                            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";*/


                        }



                    }
                    else
                    {



                        rpta = NUsuario.Editar(Convert.ToInt32(this.txtCodigoUsuario.Text), this.txtNombreUsuario.Text.Trim().ToUpper(),
                         this.txtCargo.Text.Trim().ToUpper(), this.txtEspecialidad.Text.Trim().ToUpper(),
                         this.cmbAcceso.Text, this.txtLogin.Text.Trim().ToUpper(), this.txtClave.Text.Trim().ToUpper(), this.cmbEstado.Text);

                        



                    }

                    if (rpta.Equals("OK"))
                    {




                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el usuario");
                            this.OperacionInsertarUsuario();
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el usuario");
                            this.OperacionEditarUsuario();
                        }

                    }
                    else
                    {


                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.txtCodigoUsuario.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public bool validarExisteUsuario(string login)
        {
            bool resultado = false;


            SqlConnection SqlCon = new SqlConnection();

            SqlDataReader dr;

            //Código
            SqlCon.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand("select * from Usuario where login ='" + login + "' and estado = 'Activo'");
            SqlCmd.Connection = SqlCon;

            //SqlCmd.CommandType = CommandType.StoredProcedure;


            try
            {

                dr = SqlCmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = true;

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error.", ex.Message);
            }

            return resultado;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigoUsuario.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.cmbEstado.Enabled = true;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el usuario a Modificar");
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cargo"))
            {
                this.BuscarCargo();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cblBusqueda.Text.Equals("Nombre"))
            {



                this.BuscarNombre();
            }
            else if (this.cblBusqueda.Text.Equals("Cargo"))
            {
                this.BuscarCargo();
            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idusuario"].Value);
            this.txtNombreUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtCargo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cargo"].Value);
            this.txtEspecialidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["especialidad"].Value);

            this.cmbAcceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["acceso"].Value);
            this.txtLogin.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["login"].Value);
            this.txtClave.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value);

            this.cmbEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["estado"].Value);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los/el usuario", "Consultorio Medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NUsuario.Anular(Convert.ToInt32(Codigo));


                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente El Usuario");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }






                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void OperacionInsertarUsuario()
        {

            

           


            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se ha registrado un nuevo usuario al sistema");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionEditarUsuario()
        {



            // Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se editó un usuario");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }



        private void OperacionAnularUsuario()
        {



            

             //Operacion Anular
            string rpta2 = "";


            SqlConnection SqlCon2 = new SqlConnection();




            SqlCon2.ConnectionString = "Data Source=MIRLU\\SQLEXPRESS; Initial Catalog=dbclinica; Integrated Security=true";
            SqlCon2.Open();

            SqlCommand SqlCmd2 = new SqlCommand();
            SqlCmd2.Connection = SqlCon2;
            SqlCmd2.CommandText = "insert into Operacion (fecha, descripcion) values (@d1,@d2)";





            SqlCmd2.Parameters.AddWithValue("@d1", DateTime.Now.ToString());
            SqlCmd2.Parameters.AddWithValue("@d2", "Se anuló un usuario");





            //Ejecutamos nuestro comando

            rpta2 = SqlCmd2.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




        }

        





    }



}
