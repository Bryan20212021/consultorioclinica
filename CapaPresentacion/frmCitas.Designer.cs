namespace CapaPresentacion
{
    partial class frmCitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbEstadoCita = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodCita = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostoConsulta = new System.Windows.Forms.TextBox();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodServicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdservicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtbuscarpaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(166, 239);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(156, 21);
            this.cmbUsuarios.TabIndex = 189;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(69, 235);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 25);
            this.label14.TabIndex = 188;
            this.label14.Text = "Usuario";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(817, 731);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 187;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMontoTotal.Location = new System.Drawing.Point(677, 731);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(22, 25);
            this.lblMontoTotal.TabIndex = 186;
            this.lblMontoTotal.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(407, 731);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 185;
            this.label5.Text = "Monto total por citas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1437, 62);
            this.panel3.TabIndex = 184;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(363, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 49);
            this.label12.TabIndex = 7;
            this.label12.Text = "Citas Médicas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(390, 77);
            this.label13.TabIndex = 6;
            this.label13.Text = "Crystal Clear";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(244, 674);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(124, 45);
            this.btnAnular.TabIndex = 183;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(114, 674);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 45);
            this.btnBuscar.TabIndex = 182;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cmbEstadoCita.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Items.AddRange(new object[] {
            "Activo",
            "Cancelada"});
            this.cmbEstadoCita.Location = new System.Drawing.Point(544, 674);
            this.cmbEstadoCita.Name = "cmbEstadoCita";
            this.cmbEstadoCita.Size = new System.Drawing.Size(121, 33);
            this.cmbEstadoCita.TabIndex = 181;
            this.cmbEstadoCita.Text = "Activo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(407, 679);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 25);
            this.label11.TabIndex = 180;
            this.label11.Text = "Estado de cita";
            // 
            // txtCodCita
            // 
            this.txtCodCita.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCita.Enabled = false;
            this.txtCodCita.Location = new System.Drawing.Point(657, 329);
            this.txtCodCita.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCita.Name = "txtCodCita";
            this.txtCodCita.Size = new System.Drawing.Size(30, 20);
            this.txtCodCita.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(540, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 178;
            this.label9.Text = "Codigo Cita:";
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.cmbBusqueda.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Paciente",
            "Servicio"});
            this.cmbBusqueda.Location = new System.Drawing.Point(132, 313);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 33);
            this.cmbBusqueda.TabIndex = 177;
            this.cmbBusqueda.Text = "Paciente";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 12.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataListado.ColumnHeadersHeight = 50;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataListado.GridColor = System.Drawing.Color.DarkCyan;
            this.dataListado.Location = new System.Drawing.Point(131, 356);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataListado.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1182, 254);
            this.dataListado.TabIndex = 176;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.chkAnular.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkAnular.Location = new System.Drawing.Point(1231, 324);
            this.chkAnular.Margin = new System.Windows.Forms.Padding(2);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(82, 29);
            this.chkAnular.TabIndex = 175;
            this.chkAnular.Text = "Anular";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTotal.Location = new System.Drawing.Point(693, 676);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 174;
            this.lblTotal.Text = "label3";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Location = new System.Drawing.Point(276, 322);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(133, 20);
            this.txtBuscar.TabIndex = 173;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(804, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 45);
            this.btnCancelar.TabIndex = 172;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(674, 244);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 45);
            this.btnEditar.TabIndex = 171;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(544, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 45);
            this.btnGuardar.TabIndex = 170;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(412, 244);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 45);
            this.btnNuevo.TabIndex = 169;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(166, 188);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(156, 21);
            this.cmbPacientes.TabIndex = 168;
            this.cmbPacientes.SelectedIndexChanged += new System.EventHandler(this.cmbPacientes_SelectedIndexChanged);
            // 
            // cmbServicios
            // 
            this.cmbServicios.BackColor = System.Drawing.SystemColors.Control;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(1126, 197);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(112, 21);
            this.cmbServicios.TabIndex = 167;
            this.cmbServicios.SelectedIndexChanged += new System.EventHandler(this.cmbServicios_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(1029, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 166;
            this.label10.Text = "Costo de consulta";
            // 
            // txtCostoConsulta
            // 
            this.txtCostoConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.txtCostoConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostoConsulta.Location = new System.Drawing.Point(1063, 142);
            this.txtCostoConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoConsulta.Name = "txtCostoConsulta";
            this.txtCostoConsulta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCostoConsulta.Size = new System.Drawing.Size(85, 20);
            this.txtCostoConsulta.TabIndex = 165;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Location = new System.Drawing.Point(501, 142);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(30, 20);
            this.txtCodUsuario.TabIndex = 164;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(439, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 163;
            this.label7.Text = "Codigo de Usuario";
            // 
            // txtCodServicio
            // 
            this.txtCodServicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodServicio.Enabled = false;
            this.txtCodServicio.Location = new System.Drawing.Point(263, 142);
            this.txtCodServicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodServicio.Name = "txtCodServicio";
            this.txtCodServicio.Size = new System.Drawing.Size(30, 20);
            this.txtCodServicio.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(205, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 161;
            this.label6.Text = "Codigo de servicio";
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPaciente.Enabled = false;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(75, 142);
            this.txtCodigoPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(30, 20);
            this.txtCodigoPaciente.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(58, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Codigo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(407, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 158;
            this.label8.Text = "Costo del servicio";
            // 
            // lblIdservicio
            // 
            this.lblIdservicio.AutoSize = true;
            this.lblIdservicio.Location = new System.Drawing.Point(906, 191);
            this.lblIdservicio.Name = "lblIdservicio";
            this.lblIdservicio.Size = new System.Drawing.Size(0, 13);
            this.lblIdservicio.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(1029, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 156;
            this.label2.Text = "Servicios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(736, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 155;
            this.label1.Text = "Fecha de consulta";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(714, 142);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCita.TabIndex = 154;
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.AutoSize = true;
            this.lblCodigoPaciente.Location = new System.Drawing.Point(71, 89);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoPaciente.TabIndex = 153;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(593, 193);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCosto.Size = new System.Drawing.Size(85, 20);
            this.txtCosto.TabIndex = 152;
            // 
            // txtbuscarpaciente
            // 
            this.txtbuscarpaciente.BackColor = System.Drawing.Color.White;
            this.txtbuscarpaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbuscarpaciente.Enabled = false;
            this.txtbuscarpaciente.Location = new System.Drawing.Point(1248, 782);
            this.txtbuscarpaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscarpaciente.Name = "txtbuscarpaciente";
            this.txtbuscarpaciente.Size = new System.Drawing.Size(115, 20);
            this.txtbuscarpaciente.TabIndex = 151;
            this.txtbuscarpaciente.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(70, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 150;
            this.label3.Text = "Paciente";
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 827);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEstadoCita);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodCita);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.chkAnular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cmbPacientes);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCostoConsulta);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblIdservicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtbuscarpaciente);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCitas";
            this.Text = "frmCitas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEstadoCita;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        public System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCostoConsulta;
        public System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCodServicio;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdservicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblCodigoPaciente;
        public System.Windows.Forms.TextBox txtCosto;
        public System.Windows.Forms.TextBox txtbuscarpaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ttMensaje;

    }
}