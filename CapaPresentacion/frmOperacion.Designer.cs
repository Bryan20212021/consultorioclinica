namespace CapaPresentacion
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 64);
            this.panel3.TabIndex = 154;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(308, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 49);
            this.label12.TabIndex = 7;
            this.label12.Text = "Historial De Operaciones";
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
            this.datalistadoOperaciones.Location = new System.Drawing.Point(291, 184);
            this.datalistadoOperaciones.Margin = new System.Windows.Forms.Padding(2);
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
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datalistadoOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datalistadoOperaciones.RowTemplate.Height = 24;
            this.datalistadoOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistadoOperaciones.Size = new System.Drawing.Size(525, 414);
            this.datalistadoOperaciones.TabIndex = 153;
            // 
            // lblCantidadOperaciones
            // 
            this.lblCantidadOperaciones.AutoSize = true;
            this.lblCantidadOperaciones.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblCantidadOperaciones.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidadOperaciones.Location = new System.Drawing.Point(527, 134);
            this.lblCantidadOperaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadOperaciones.Name = "lblCantidadOperaciones";
            this.lblCantidadOperaciones.Size = new System.Drawing.Size(60, 25);
            this.lblCantidadOperaciones.TabIndex = 152;
            this.lblCantidadOperaciones.Text = "label4";
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datalistadoOperaciones);
            this.Controls.Add(this.lblCantidadOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}