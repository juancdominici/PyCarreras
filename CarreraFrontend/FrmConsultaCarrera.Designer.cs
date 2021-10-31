
namespace CarreraFrontend
{
    partial class FrmConsultaCarrera
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
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(225, 414);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 23);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
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
            this.dtvDetalles.Location = new System.Drawing.Point(98, 227);
            this.dtvDetalles.Name = "dtvDetalles";
            this.dtvDetalles.ReadOnly = true;
            this.dtvDetalles.RowHeadersWidth = 51;
            this.dtvDetalles.RowTemplate.Height = 24;
            this.dtvDetalles.Size = new System.Drawing.Size(608, 159);
            this.dtvDetalles.TabIndex = 35;
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
            this.acciones.Width = 140;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(606, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 33);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboMateria
            // 
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(382, 193);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(218, 24);
            this.cboMateria.TabIndex = 33;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Location = new System.Drawing.Point(215, 151);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(200, 22);
            this.dtpAnioCursado.TabIndex = 32;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(215, 110);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(299, 22);
            this.txtTitulo.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 22);
            this.txtNombre.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Año de Cursado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(133, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(133, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(146, 14);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(128, 25);
            this.lblNro.TabIndex = 26;
            this.lblNro.Text = "Carrera #: 1";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(194, 193);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(182, 22);
            this.txtCuatrimestre.TabIndex = 38;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(96, 196);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(92, 17);
            this.lblCuatrimestre.TabIndex = 39;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // FrmConsultaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNro);
            this.Name = "FrmConsultaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaCarrera";
            this.Load += new System.EventHandler(this.FrmConsultaCarreraLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dtvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniodecursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materias;
        private System.Windows.Forms.DataGridViewButtonColumn acciones;
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
    }
}