
namespace ReporteCarrera
{
    partial class FrmReporte
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
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.GbReporte = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.btnGenerar);
            this.GbFiltro.Controls.Add(this.label2);
            this.GbFiltro.Controls.Add(this.label1);
            this.GbFiltro.Controls.Add(this.dtpFechaHasta);
            this.GbFiltro.Controls.Add(this.dtpFechaDesde);
            this.GbFiltro.Location = new System.Drawing.Point(1, 15);
            this.GbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbFiltro.Size = new System.Drawing.Size(736, 125);
            this.GbFiltro.TabIndex = 1;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(461, 50);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 38);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(157, 74);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(255, 27);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(157, 32);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(259, 27);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // GbReporte
            // 
            this.GbReporte.Location = new System.Drawing.Point(1, 148);
            this.GbReporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbReporte.Name = "GbReporte";
            this.GbReporte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbReporte.Size = new System.Drawing.Size(736, 302);
            this.GbReporte.TabIndex = 2;
            this.GbReporte.TabStop = false;
            this.GbReporte.Text = "Reporte";
            this.GbReporte.Enter += new System.EventHandler(this.GbReporte_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(582, 459);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 38);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 511);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GbReporte);
            this.Controls.Add(this.GbFiltro);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporte";
            this.Text = "Reporte Carrera";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwCarrera;
        private System.Windows.Forms.GroupBox GbFiltro;
        private System.Windows.Forms.GroupBox GbReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    }
}