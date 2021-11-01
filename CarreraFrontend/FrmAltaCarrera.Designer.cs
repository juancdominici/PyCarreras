
namespace CarreraFrontend
{
    partial class FrmAltaCarrera
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtvDetalles = new System.Windows.Forms.DataGridView();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniodecursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.dtpAnioCursado = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.gpbMaterias = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetalles)).BeginInit();
            this.gpbMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(365, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 31);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(231, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 31);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtvDetalles
            // 
            this.dtvDetalles.AllowUserToAddRows = false;
            this.dtvDetalles.AllowUserToDeleteRows = false;
            this.dtvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.aniodecursado,
            this.cuatrimestre,
            this.materias,
            this.acciones});
            this.dtvDetalles.Location = new System.Drawing.Point(53, 131);
            this.dtvDetalles.Name = "dtvDetalles";
            this.dtvDetalles.ReadOnly = true;
            this.dtvDetalles.RowHeadersWidth = 51;
            this.dtvDetalles.RowTemplate.Height = 24;
            this.dtvDetalles.Size = new System.Drawing.Size(638, 149);
            this.dtvDetalles.TabIndex = 35;
            this.dtvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDetalles_CellContentClick);
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            this.detalle.Width = 125;
            // 
            // aniodecursado
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.aniodecursado.DefaultCellStyle = dataGridViewCellStyle1;
            this.aniodecursado.HeaderText = "Año de Cursado";
            this.aniodecursado.MinimumWidth = 6;
            this.aniodecursado.Name = "aniodecursado";
            this.aniodecursado.ReadOnly = true;
            this.aniodecursado.Width = 175;
            // 
            // cuatrimestre
            // 
            this.cuatrimestre.HeaderText = "Cuatrimestre";
            this.cuatrimestre.MinimumWidth = 6;
            this.cuatrimestre.Name = "cuatrimestre";
            this.cuatrimestre.ReadOnly = true;
            this.cuatrimestre.Width = 135;
            // 
            // materias
            // 
            this.materias.HeaderText = "Materias";
            this.materias.MinimumWidth = 6;
            this.materias.Name = "materias";
            this.materias.ReadOnly = true;
            this.materias.Width = 135;
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.acciones.Text = "Quitar";
            this.acciones.UseColumnTextForButtonValue = true;
            this.acciones.Width = 140;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(572, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 31);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(333, 82);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(233, 23);
            this.cboMateria.TabIndex = 33;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Location = new System.Drawing.Point(169, 43);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(176, 23);
            this.dtpAnioCursado.TabIndex = 32;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(441, 86);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(262, 23);
            this.txtTitulo.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 23);
            this.txtNombre.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Año de Cursado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(393, 89);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 15);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNro.Location = new System.Drawing.Point(100, 39);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(89, 20);
            this.lblNro.TabIndex = 26;
            this.lblNro.Text = "Carrera #:";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(169, 82);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(160, 23);
            this.txtCuatrimestre.TabIndex = 38;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(83, 85);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(78, 15);
            this.lblCuatrimestre.TabIndex = 39;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // gpbMaterias
            // 
            this.gpbMaterias.Controls.Add(this.lblCuatrimestre);
            this.gpbMaterias.Controls.Add(this.dtvDetalles);
            this.gpbMaterias.Controls.Add(this.txtCuatrimestre);
            this.gpbMaterias.Controls.Add(this.label4);
            this.gpbMaterias.Controls.Add(this.btnCancelar);
            this.gpbMaterias.Controls.Add(this.dtpAnioCursado);
            this.gpbMaterias.Controls.Add(this.btnAceptar);
            this.gpbMaterias.Controls.Add(this.cboMateria);
            this.gpbMaterias.Controls.Add(this.btnAgregar);
            this.gpbMaterias.Location = new System.Drawing.Point(12, 131);
            this.gpbMaterias.Name = "gpbMaterias";
            this.gpbMaterias.Size = new System.Drawing.Size(749, 335);
            this.gpbMaterias.TabIndex = 40;
            this.gpbMaterias.TabStop = false;
            this.gpbMaterias.Text = "Materias";
            // 
            // FrmAltaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 484);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.gpbMaterias);
            this.Name = "FrmAltaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Carreras";
            this.Load += new System.EventHandler(this.FrmConsultaCarreraLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetalles)).EndInit();
            this.gpbMaterias.ResumeLayout(false);
            this.gpbMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtvDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.DateTimePicker dtpAnioCursado;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.GroupBox gpbMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniodecursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materias;
        private System.Windows.Forms.DataGridViewButtonColumn acciones;
    }
}