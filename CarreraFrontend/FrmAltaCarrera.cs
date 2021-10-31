using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraFrontend
{
    public enum Accion
    {
        CREATE,
        READ,
        UPDATE,
        DELETE
    }
    public partial class FrmAltaCarrera : Form
    {
        private IService servicio;
        private Accion modo;
        Carrera carrera = new Carrera();
        DetalleCarrera dc = new DetalleCarrera();

        public FrmAltaCarrera(Accion modo, int nro)
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
            this.modo = modo;

            if (modo.Equals(Accion.READ))
            {
                btnAceptar.Enabled = false;
                this.Text = "VER CARRERA";
                this.Cargar_carrera(nro);
            }
        }

        private void Cargar_carrera(int nro)
        {
            this.carrera = servicio.ObtenerCarreraPorId(nro);
            txtNombre.Text = carrera.Nombre;
            txtTitulo.Text = carrera.Titulo;
            dtpAnioCursado.Value = DateTime.Today;
            cboMateria.Text = dc.Materia.Nombre;

            dtvDetalles.Rows.Clear();
            foreach (DetalleCarrera detalleCarrera in carrera.Detalles)
            {
                dtvDetalles.Rows.Add(new object[] { "", detalleCarrera.AnioCursado.ToString(), detalleCarrera.Materia.Nombre, detalleCarrera.Cuatrimestre.ToString() }); ;
            }
        }

        private void FrmAltaCarreraLoad(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE))
            {
                CargarCombo();
                txtNombre.Text = "JUAN";
                txtTitulo.Text = "TECNICO ELECTRONICO";
                dtpAnioCursado.Value = DateTime.Now;
            }
        }
        private void CargarCombo()
        {
            List<Materia> lst = servicio.ConsultarAsignatura();
            cboMateria.DataSource = lst;
            cboMateria.DisplayMember = "N_MATERIA";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ExisteProductoEnGrilla(cboMateria.Text))
            {
                MessageBox.Show("La materia ya esta agregado como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleCarrera item = new DetalleCarrera();


            Materia oMateria = (Materia)cboMateria.SelectedItem;
            item.Materia = oMateria;

            carrera.AgregarDetalle(item);

            dtvDetalles.Rows.Add(item.AnioCursado, item.Cuatrimestre, item.Materia);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dtvDetalles.Rows)
            {
                if (fila.Cells["materias"].Value.Equals(text))
                    return true;
            }
            return false;
        }
        private void dtvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvDetalles.CurrentCell.ColumnIndex == 4)
            {
                carrera.QuitarDetalle(dtvDetalles.CurrentRow.Index);
                dtvDetalles.Rows.Remove(dtvDetalles.CurrentRow);
            }
        }
    }
}
