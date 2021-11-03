
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
            this.RwCarrera = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.GbReporte = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GbFiltro.SuspendLayout();
            this.GbReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // RwCarrera
            // 
            this.RwCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RwCarrera.Location = new System.Drawing.Point(3, 18);
            this.RwCarrera.Name = "RwCarrera";
            this.RwCarrera.ServerReport.BearerToken = null;
            this.RwCarrera.Size = new System.Drawing.Size(730, 221);
            this.RwCarrera.TabIndex = 0;
            this.RwCarrera.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.btnGenerar);
            this.GbFiltro.Controls.Add(this.label2);
            this.GbFiltro.Controls.Add(this.label1);
            this.GbFiltro.Controls.Add(this.dtpFechaHasta);
            this.GbFiltro.Controls.Add(this.dtpFechaDesde);
            this.GbFiltro.Location = new System.Drawing.Point(1, 12);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Size = new System.Drawing.Size(736, 100);
            this.GbFiltro.TabIndex = 1;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtros";
            this.GbFiltro.Enter += new System.EventHandler(this.GbFiltro_Enter);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(461, 40);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(150, 30);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(157, 59);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(157, 26);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(259, 22);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // GbReporte
            // 
            this.GbReporte.Controls.Add(this.RwCarrera);
            this.GbReporte.Location = new System.Drawing.Point(1, 118);
            this.GbReporte.Name = "GbReporte";
            this.GbReporte.Size = new System.Drawing.Size(736, 242);
            this.GbReporte.TabIndex = 2;
            this.GbReporte.TabStop = false;
            this.GbReporte.Text = "Reporte";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(582, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(143, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 409);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GbReporte);
            this.Controls.Add(this.GbFiltro);
            this.Name = "FrmReporte";
            this.Text = "Reporte Carrera";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            this.GbReporte.ResumeLayout(false);
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