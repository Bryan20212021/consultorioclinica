﻿namespace CapaPresentacion
{
    partial class frmOperacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.datalistadoOperaciones = new System.Windows.Forms.DataGridView();
            this.lblCantidadOperaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.cblBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1436, 79);
            this.panel3.TabIndex = 154;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(411, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 60);
            this.label12.TabIndex = 7;
            this.label12.Text = "Historial De Operaciones";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(36, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(520, 95);
            this.label13.TabIndex = 6;
            this.label13.Text = "Crystal Clear";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datalistadoOperaciones
            // 
            this.datalistadoOperaciones.AllowUserToAddRows = false;
            this.datalistadoOperaciones.AllowUserToDeleteRows = false;
            this.datalistadoOperaciones.AllowUserToOrderColumns = true;
            this.datalistadoOperaciones.BackgroundColor = System.Drawing.Color.White;
            this.datalistadoOperaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoOperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistadoOperaciones.ColumnHeadersHeight = 50;
            this.datalistadoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datalistadoOperaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.datalistadoOperaciones.GridColor = System.Drawing.Color.DarkCyan;
            this.datalistadoOperaciones.Location = new System.Drawing.Point(354, 209);
            this.datalistadoOperaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalistadoOperaciones.MultiSelect = false;
            this.datalistadoOperaciones.Name = "datalistadoOperaciones";
            this.datalistadoOperaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistadoOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistadoOperaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datalistadoOperaciones.RowTemplate.Height = 24;
            this.datalistadoOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoOperaciones.Size = new System.Drawing.Size(700, 510);
            this.datalistadoOperaciones.TabIndex = 153;
            // 
            // lblCantidadOperaciones
            // 
            this.lblCantidadOperaciones.AutoSize = true;
            this.lblCantidadOperaciones.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblCantidadOperaciones.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidadOperaciones.Location = new System.Drawing.Point(979, 175);
            this.lblCantidadOperaciones.Name = "lblCantidadOperaciones";
            this.lblCantidadOperaciones.Size = new System.Drawing.Size(75, 32);
            this.lblCantidadOperaciones.TabIndex = 152;
            this.lblCantidadOperaciones.Text = "label4";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblFecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblFecha.Location = new System.Drawing.Point(25, 292);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 32);
            this.lblFecha.TabIndex = 167;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(31, 268);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 22);
            this.txtNombre.TabIndex = 175;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNombreUsuario.Location = new System.Drawing.Point(25, 234);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(218, 32);
            this.lblNombreUsuario.TabIndex = 174;
            this.lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // cblBusqueda
            // 
            this.cblBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.cblBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cblBusqueda.ForeColor = System.Drawing.Color.DarkCyan;
            this.cblBusqueda.FormattingEnabled = true;
            this.cblBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Fecha",
            "Suceso"});
            this.cblBusqueda.Location = new System.Drawing.Point(31, 167);
            this.cblBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cblBusqueda.Name = "cblBusqueda";
            this.cblBusqueda.Size = new System.Drawing.Size(160, 40);
            this.cblBusqueda.TabIndex = 195;
            this.cblBusqueda.Text = "Nombre";
            this.cblBusqueda.SelectedIndexChanged += new System.EventHandler(this.cblBusqueda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 196;
            this.label2.Text = "Buscar según:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "d/M/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(31, 327);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(275, 22);
            this.dtpFecha.TabIndex = 197;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(25, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 198;
            this.label1.Text = "Suceso:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.comboBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Iniciar sesion.",
            "Cerrar sesion.",
            "Creación de registro.",
            "Edición de registro.",
            "Anulación de registro."});
            this.comboBox1.Location = new System.Drawing.Point(31, 397);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 40);
            this.comboBox1.TabIndex = 199;
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 865);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cblBusqueda);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datalistadoOperaciones);
            this.Controls.Add(this.lblCantidadOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOperacion";
            this.Text = "frmOperacion";
            this.Load += new System.EventHandler(this.frmOperacion_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadoOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datalistadoOperaciones;
        private System.Windows.Forms.Label lblCantidadOperaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ComboBox cblBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}