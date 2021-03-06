using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using CarreraBackend.Servicios.Interfaces;
using CarreraFrontend.Cliente;
using Newtonsoft.Json;
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
            servicio = new ServiceFactoryImp().CrearCarreraService();
            this.modo = modo;
            lblNro.Text = "Carrera #" + nro + ":";


            if (modo.Equals(Accion.READ))
            {
                txtNombre.Enabled = false;
                txtTitulo.Enabled = false;
                gpbMaterias.Enabled = false;
                btnAceptar.Enabled = false;
                this.Text = "Viendo Carrera";
                CargarCarreraAsync(nro);
            }
            if (modo.Equals(Accion.UPDATE))
            {
                this.Text = "Actualizando Carrera";
                CargarCarreraAsync(nro);
            }

        }
        private async Task CargarCarreraAsync(int nro)
        {
            string url = "https://localhost:44373/api/Carrera/" + nro.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            this.carrera = JsonConvert.DeserializeObject<Carrera>(resultado);
            this.carrera.Id = nro.ToString();

            txtNombre.Text = carrera.Nombre;
            txtTitulo.Text = carrera.Titulo;
            

            dtvDetalles.Rows.Clear();
            foreach (DetalleCarrera oDetalle in carrera.Detalles)
            {
                dtvDetalles.Rows.Add(new object[] { "", oDetalle.AnioCursado, oDetalle.Cuatrimestre, oDetalle.Materia.Nombre}); ;
            }
        }
        private void FrmConsultaCarreraLoad(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private async void CargarCombo()
        {
            List<Materia> list = null;
            string url = "https://localhost:44373/api/Materia/consultar";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);

            list = JsonConvert.DeserializeObject<List<Materia>>(resultado);

            cboMateria.DataSource = list;
            cboMateria.ValueMember = "Id";
            cboMateria.DisplayMember = "Nombre";
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ExisteProductoEnGrilla(cboMateria.Text))
            {
                MessageBox.Show("La materia ya esta agregada como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCuatrimestre.Text.Trim() == "")
            {
                MessageBox.Show("El cuatrimestre no puede ser nulo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuatrimestre.Focus();
                return;
            }

            DetalleCarrera item = new DetalleCarrera();
            item.AnioCursado = dtpAnioCursado.Value;
            item.Cuatrimestre = Convert.ToInt32(txtCuatrimestre.Text);
            item.Materia = new Materia((int)cboMateria.SelectedValue, cboMateria.SelectedItem.ToString());

            carrera.AgregarDetalle(item);

            dtvDetalles.Rows.Add(carrera.Detalles.Count + 1, item.AnioCursado, item.Cuatrimestre, item.Materia);

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
                dtvDetalles.Rows.RemoveAt(dtvDetalles.CurrentRow.Index);
            } 
            else
            {
                dtpAnioCursado.Value = Convert.ToDateTime(dtvDetalles.CurrentRow.Cells[1].Value);
                txtCuatrimestre.Text = dtvDetalles.CurrentRow.Cells[2].Value.ToString();
                cboMateria.SelectedIndex = cboMateria.FindString(dtvDetalles.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dtvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un detalle", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtTitulo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el titulo de la carrera", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
                return;
            }

            carrera.Nombre = txtNombre.Text;
            carrera.Titulo = txtTitulo.Text;

            if (modo.Equals(Accion.UPDATE))
            {
                ///
                List<Parametro> parametros = new List<Parametro>();

                var val1 = carrera.Id;
                parametros.Add(new Parametro("Id", val1));

                var val2 = txtNombre.Text;
                parametros.Add(new Parametro("Nombre", val2));

                var val3 = txtTitulo.Text;
                parametros.Add(new Parametro("Titulo", val3));

                var val4 = JsonConvert.SerializeObject(carrera.Detalles, Formatting.Indented);
                parametros.Add(new Parametro("Detalles", val4));

                string json = JsonConvert.SerializeObject(parametros);
                string url = "https://localhost:44373/api/Carrera/modificar";
                var res = await ClienteSingleton.GetInstancia().PostAsync(url, json);

                bool respuesta = JsonConvert.DeserializeObject<bool>(res);

                if (respuesta)
                {
                    MessageBox.Show("Carrera modificada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ///
                List<Parametro> parametros = new List<Parametro>();

                var val1 = servicio.ObtenerUltimoIdCarrera();
                parametros.Add(new Parametro("Id", val1));

                var val2 = txtNombre.Text;
                parametros.Add(new Parametro("Nombre", val2));

                var val3 = txtTitulo.Text;
                parametros.Add(new Parametro("Titulo", val3));

                var val4 = JsonConvert.SerializeObject(carrera.Detalles, Formatting.Indented);
                parametros.Add(new Parametro("Detalles", val4));

                string json = JsonConvert.SerializeObject(parametros);
                string url = "https://localhost:44373/api/Carrera/cargar";
                var res = await ClienteSingleton.GetInstancia().PostAsync(url, json);

                bool respuesta = JsonConvert.DeserializeObject<bool>(res);

                if (respuesta)
                {
                    MessageBox.Show("Carrera guardada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
