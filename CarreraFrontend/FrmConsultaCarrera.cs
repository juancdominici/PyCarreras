using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
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
    public partial class FrmConsultaCarrera : Form
    {
        private IService servicio;

        public FrmConsultaCarrera()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearCarreraService();
        }


        private void FrmReporte_Load(object sender, EventArgs e)
        {

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();
            Parametro fecha_desde = new Parametro();
            fecha_desde.Nombre = "@fecha_desde";
            fecha_desde.Valor = dtpDesde.Value.ToShortDateString();
            filtros.Add(fecha_desde);
            filtros.Add(new Parametro("@fecha_hasta", dtpHasta.Value.ToShortDateString()));

            object val = DBNull.Value;
            if (!String.IsNullOrEmpty(txtNombre.Text))
                val = txtNombre.Text;
            filtros.Add(new Parametro("@nombre", val));

            if (!String.IsNullOrEmpty(txtTitulo.Text))
                val = txtTitulo.Text;
            filtros.Add(new Parametro("@titulo", val));



            List<Carrera> lst = null;

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44373/api/Carreras/consultar";

            var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, filtrosJSON);

            lst = JsonConvert.DeserializeObject<List<Carrera>>(resultado);



            dgvResultados.Rows.Clear();
            foreach (Carrera Carrera in lst)
            {
                dgvResultados.Rows.Add(new object[]{
                                        Carrera.Nombre,
                                        Carrera.Titulo
                 }); ;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nroCarrera = Convert.ToInt32(dgvResultados.CurrentRow.Cells["id"].Value.ToString());
            FrmAltaCarrera frm = new FrmAltaCarrera(Accion.UPDATE, nroCarrera);
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow;
            if (row != null)
            {
                int carrera = Int32.Parse(row.Cells["id"].Value.ToString());
                if (MessageBox.Show("Seguro que desea eliminar la carrera seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = servicio.RegistrarBajaCarrera(carrera);

                    if (respuesta)
                    {
                        MessageBox.Show("Carrera eliminada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("Error al intentar borrar la carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si el índice de la columna de la fila actual es 6: (botón Ver detalles)
            if (dgvResultados.CurrentCell.ColumnIndex == 6)
            {
                int nroCarrera = Convert.ToInt32(dgvResultados.CurrentRow.Cells["id"].Value.ToString());
                FrmAltaCarrera frm = new FrmAltaCarrera(Accion.READ, nroCarrera);
                frm.ShowDialog();
            }
        }

    }
}
