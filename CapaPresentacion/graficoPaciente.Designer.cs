﻿namespace CapaPresentacion
{
    partial class graficoPaciente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnLimpiarGrafico = new System.Windows.Forms.Button();
            this.btnCrearGrafico = new System.Windows.Forms.Button();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimirGrafico = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCircular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLinea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarGrafico
            // 
            this.btnLimpiarGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarGrafico.Location = new System.Drawing.Point(876, 334);
            this.btnLimpiarGrafico.Name = "btnLimpiarGrafico";
            this.btnLimpiarGrafico.Size = new System.Drawing.Size(186, 67);
            this.btnLimpiarGrafico.TabIndex = 164;
            this.btnLimpiarGrafico.Text = "Limpiar Grafico";
            this.btnLimpiarGrafico.UseVisualStyleBackColor = false;
            this.btnLimpiarGrafico.Click += new System.EventHandler(this.btnLimpiarGrafico_Click);
            // 
            // btnCrearGrafico
            // 
            this.btnCrearGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCrearGrafico.ForeColor = System.Drawing.Color.White;
            this.btnCrearGrafico.Location = new System.Drawing.Point(876, 261);
            this.btnCrearGrafico.Name = "btnCrearGrafico";
            this.btnCrearGrafico.Size = new System.Drawing.Size(186, 67);
            this.btnCrearGrafico.TabIndex = 163;
            this.btnCrearGrafico.Text = "Generar Gráfico";
            this.btnCrearGrafico.UseVisualStyleBackColor = false;
            this.btnCrearGrafico.Click += new System.EventHandler(this.btnCrearGrafico_Click);
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Edad",
            "Sexo",
            "Estado Civil"});
            this.cbCampo.Location = new System.Drawing.Point(876, 119);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(186, 24);
            this.cbCampo.TabIndex = 162;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartLinea);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(710, 522);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Linea";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartCircular);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartBarras);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Barras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(870, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 167;
            this.label6.Text = "Campo:";
            // 
            // btnImprimirGrafico
            // 
            this.btnImprimirGrafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnImprimirGrafico.ForeColor = System.Drawing.Color.White;
            this.btnImprimirGrafico.Location = new System.Drawing.Point(876, 407);
            this.btnImprimirGrafico.Name = "btnImprimirGrafico";
            this.btnImprimirGrafico.Size = new System.Drawing.Size(186, 67);
            this.btnImprimirGrafico.TabIndex = 166;
            this.btnImprimirGrafico.Text = "Imprimir Gráfico";
            this.btnImprimirGrafico.UseVisualStyleBackColor = false;
            this.btnImprimirGrafico.Click += new System.EventHandler(this.btnImprimirGrafico_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(81, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 551);
            this.tabControl1.TabIndex = 165;
            // 
            // chartBarras
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBarras.Legends.Add(legend3);
            this.chartBarras.Location = new System.Drawing.Point(6, 6);
            this.chartBarras.Name = "chartBarras";
            this.chartBarras.Size = new System.Drawing.Size(698, 510);
            this.chartBarras.TabIndex = 1;
            this.chartBarras.Text = "chart1";
            // 
            // chartCircular
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCircular.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCircular.Legends.Add(legend2);
            this.chartCircular.Location = new System.Drawing.Point(6, 6);
            this.chartCircular.Name = "chartCircular";
            this.chartCircular.Size = new System.Drawing.Size(698, 510);
            this.chartCircular.TabIndex = 3;
            this.chartCircular.Text = "chart1";
            // 
            // chartLinea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLinea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLinea.Legends.Add(legend1);
            this.chartLinea.Location = new System.Drawing.Point(3, 3);
            this.chartLinea.Name = "chartLinea";
            this.chartLinea.Size = new System.Drawing.Size(704, 516);
            this.chartLinea.TabIndex = 2;
            this.chartLinea.Text = "chart1";
            // 
            // graficoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 650);
            this.Controls.Add(this.btnLimpiarGrafico);
            this.Controls.Add(this.btnCrearGrafico);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImprimirGrafico);
            this.Controls.Add(this.tabControl1);
            this.Name = "graficoPaciente";
            this.Text = "graficoPaciente";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCircular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarGrafico;
        private System.Windows.Forms.Button btnCrearGrafico;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimirGrafico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLinea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCircular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
    }
}