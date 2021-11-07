
namespace ReporteCarrera.Reportes
{
    partial class FrmReportePlanesEstudio
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCarreras = new ReporteCarrera.Reportes.DSCarreras();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpCondiciones = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpReporte = new System.Windows.Forms.GroupBox();
            this.rvPlanesEstudio = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCarreras)).BeginInit();
            this.gpCondiciones.SuspendLayout();
            this.gpReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSCarreras;
            // 
            // DSCarreras
            // 
            this.DSCarreras.DataSetName = "DSCarreras";
            this.DSCarreras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(30, 54);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(360, 23);
            this.dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(404, 54);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(349, 23);
            this.dtpHasta.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnGenerar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenerar.Location = new System.Drawing.Point(776, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(97, 59);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gpCondiciones
            // 
            this.gpCondiciones.Controls.Add(this.label2);
            this.gpCondiciones.Controls.Add(this.label1);
            this.gpCondiciones.Controls.Add(this.dtpHasta);
            this.gpCondiciones.Controls.Add(this.btnGenerar);
            this.gpCondiciones.Controls.Add(this.dtpDesde);
            this.gpCondiciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gpCondiciones.Location = new System.Drawing.Point(12, 12);
            this.gpCondiciones.Name = "gpCondiciones";
            this.gpCondiciones.Size = new System.Drawing.Size(894, 98);
            this.gpCondiciones.TabIndex = 3;
            this.gpCondiciones.TabStop = false;
            this.gpCondiciones.Text = "Condiciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha desde: ";
            // 
            // gpReporte
            // 
            this.gpReporte.Controls.Add(this.rvPlanesEstudio);
            this.gpReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gpReporte.Location = new System.Drawing.Point(12, 126);
            this.gpReporte.Name = "gpReporte";
            this.gpReporte.Size = new System.Drawing.Size(894, 502);
            this.gpReporte.TabIndex = 5;
            this.gpReporte.TabStop = false;
            this.gpReporte.Text = "Reporte";
            // 
            // rvPlanesEstudio
            // 
            this.rvPlanesEstudio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSCarrera";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rvPlanesEstudio.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPlanesEstudio.LocalReport.ReportEmbeddedResource = "ReporteCarrera.Reportes.rptCarreras.rdlc";
            this.rvPlanesEstudio.Location = new System.Drawing.Point(3, 19);
            this.rvPlanesEstudio.Name = "rvPlanesEstudio";
            this.rvPlanesEstudio.ServerReport.BearerToken = null;
            this.rvPlanesEstudio.Size = new System.Drawing.Size(888, 480);
            this.rvPlanesEstudio.TabIndex = 5;
            // 
            // FrmReportePlanesEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 640);
            this.Controls.Add(this.gpReporte);
            this.Controls.Add(this.gpCondiciones);
            this.Name = "FrmReportePlanesEstudio";
            this.Text = "Planes de Estudio";
            this.Load += new System.EventHandler(this.FrmReportePlanesEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCarreras)).EndInit();
            this.gpCondiciones.ResumeLayout(false);
            this.gpCondiciones.PerformLayout();
            this.gpReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox gpCondiciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvPlanesEstudio;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSCarreras DSCarreras;
    }
}