using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using CarreraBackend.Servicios.Interfaces;
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
    public partial class FrmConsultaMaterias : Form
    {
        private IMateriaService servicio;
        private bool flag;

        public FrmConsultaMaterias()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearMateriaService();
            flag = false;
        }


        private void FrmConsultaMateriasLoad(object sender, EventArgs e)
        {
            var list = servicio.ConsultarAsignatura();
            for (int i = 0; i < list.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dtvDetalles);
                newRow.Cells[0].Value = list[i];
                dtvDetalles.Rows.Add(newRow);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (ExisteProductoEnGrilla(txtNombre.Text))
            {
                MessageBox.Show("Ya existe una materia con ese nombre...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (flag) CargarMateria();
            else ModificarMateria();
        }

        private void ModificarMateria()
        {
            //servicio.ModificarMateria(new Materia(txtNombre.Text));
            dtvDetalles.CurrentCell.Value = txtNombre.Text;

            txtNombre.Text = "";
        }

        private void CargarMateria()
        {
            //servicio.GrabarMateria(new Materia(txtNombre.Text));
            DataGridViewRow newRow = new DataGridViewRow();

            newRow.CreateCells(dtvDetalles);
            newRow.Cells[0].Value = txtNombre.Text;
            dtvDetalles.Rows.Add(newRow);

            txtNombre.Text = "";
        }

        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dtvDetalles.Rows)
            {
                if (fila.Cells["nombre"].Value.Equals(text))
                    return true;
            }
            return false;
        }
        private void dtvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvDetalles.CurrentCell.ColumnIndex == 0)
            {
                txtNombre.Text = dtvDetalles.SelectedCells[0].Value.ToString();
                btnAgregar.Text = "Modificar";
                flag = true;
                //modificar
            }
            if (dtvDetalles.CurrentCell.ColumnIndex == 1)
            {
                dtvDetalles.Rows.RemoveAt(dtvDetalles.CurrentRow.Index);
                //quitar
            }
        }


        private void dtvDetalles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            if (dtvDetalles.RowCount == 0)
            {
                txtNombre.Text = "";
                btnAgregar.Text = "Agregar";
                flag = false;
            }
        }
    }
}
