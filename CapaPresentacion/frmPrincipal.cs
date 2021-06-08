﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void GestionUsuario()
        {
            //Controlar los accesos
            if (this.lblAcceso.Text == "Medico")
            {
                this.btnPacientes.Enabled = true;
                this.btnUsuarios.Enabled = true;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = true;
                this.btnServicios.Enabled = true;
                this.btnDiagnosticos.Enabled = true;
                this.btnRecetas.Enabled = true;
                this.btnOperaciones.Enabled = true;

            }



            else
            {
                /*this.btnPacientes.Enabled = true;
                this.btnUsuarios.Enabled = false;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = false;
                this.btnServicios.Enabled = false;
                this.btnDiagnosticos.Enabled = false;
                this.btnRecetas.Enabled = false;
                this.btnOperaciones.Enabled = false;*/

                this.btnPacientes.Enabled = true;
                this.btnUsuarios.Enabled = true;
                this.btnCitas.Enabled = true;
                this.btnHistorias.Enabled = true;
                this.btnServicios.Enabled = true;
                this.btnDiagnosticos.Enabled = true;
                this.btnRecetas.Enabled = true;
                this.btnOperaciones.Enabled = true;

            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            label3_Click(null, e);
            GestionUsuario();
            this.WindowState = FormWindowState.Maximized;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPaciente());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmUsuarios());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCitas());
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDiagnostico());
        }

        private void btnHistorias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmHistoria());
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmRecetas());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmServicios());
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmOperacion());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }




    }
}
