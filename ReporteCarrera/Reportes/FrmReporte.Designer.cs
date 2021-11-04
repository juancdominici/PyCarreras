
namespace CarreraReporte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RwCarrera = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GbFiltro = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.GbReporte = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dsCarrera = new CarreraReporte.Reportes.DsCarrera();
            this.dsCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GbFiltro.SuspendLayout();
            this.GbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarreraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RwCarrera
            // 
            this.RwCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsCarreraBindingSource;
            this.RwCarrera.LocalReport.DataSources.Add(reportDataSource1);
            this.RwCarrera.LocalReport.ReportEmbeddedResource = "ReporteCarrera.Reportes.Report1.rdlc";
            this.RwCarrera.Location = new System.Drawing.Point(2, 15);
            this.RwCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.RwCarrera.Name = "RwCarrera";
            this.RwCarrera.ServerReport.BearerToken = null;
            this.RwCarrera.Size = new System.Drawing.Size(575, 498);
            this.RwCarrera.TabIndex = 0;
            // 
            // GbFiltro
            // 
            this.GbFiltro.Controls.Add(this.btnGenerar);
            this.GbFiltro.Controls.Add(this.label2);
            this.GbFiltro.Controls.Add(this.label1);
            this.GbFiltro.Controls.Add(this.dtpFechaHasta);
            this.GbFiltro.Controls.Add(this.dtpFechaDesde);
            this.GbFiltro.Location = new System.Drawing.Point(13, 10);
            this.GbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.GbFiltro.Name = "GbFiltro";
            this.GbFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.GbFiltro.Size = new System.Drawing.Size(575, 81);
            this.GbFiltro.TabIndex = 1;
            this.GbFiltro.TabStop = false;
            this.GbFiltro.Text = "Filtros";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(426, 21);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 47);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(118, 48);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(304, 20);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(118, 21);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(304, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // GbReporte
            // 
            this.GbReporte.Controls.Add(this.RwCarrera);
            this.GbReporte.Location = new System.Drawing.Point(11, 95);
            this.GbReporte.Margin = new System.Windows.Forms.Padding(2);
            this.GbReporte.Name = "GbReporte";
            this.GbReporte.Padding = new System.Windows.Forms.Padding(2);
            this.GbReporte.Size = new System.Drawing.Size(579, 515);
            this.GbReporte.TabIndex = 2;
            this.GbReporte.TabStop = false;
            this.GbReporte.Text = "Reporte";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(483, 614);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 24);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dsCarrera
            // 
            this.dsCarrera.DataSetName = "DsCarrera";
            this.dsCarrera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCarreraBindingSource
            // 
            this.dsCarreraBindingSource.DataSource = this.dsCarrera;
            this.dsCarreraBindingSource.Position = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 649);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GbReporte);
            this.Controls.Add(this.GbFiltro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporte";
            this.Text = "Reporte Carrera";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.GbFiltro.ResumeLayout(false);
            this.GbFiltro.PerformLayout();
            this.GbReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarreraBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource dsCarreraBindingSource;
        private Reportes.DsCarrera dsCarrera;
    }
}