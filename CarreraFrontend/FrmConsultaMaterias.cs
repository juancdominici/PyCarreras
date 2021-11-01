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
                newRow.Cells[0].Value = list[i].Id;
                newRow.Cells[1].Value = list[i].Nombre;
                dtvDetalles.Rows.Add(newRow);
            }
            btnCancelar.Enabled = false;
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
            if (!flag) CargarMateria();
            else ModificarMateria();
        }

        private void ModificarMateria()
        {
            if (servicio.ModificarMateria(new Materia((int)dtvDetalles.CurrentRow.Cells[0].Value, txtNombre.Text)))
            {
                MessageBox.Show("Materia modificada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtvDetalles.CurrentCell.Value = txtNombre.Text;

                txtNombre.Text = "";
                btnAgregar.Text = "Agregar";
                dtvDetalles.ClearSelection();
            }
            else
            {
                MessageBox.Show("Error al intentar modificar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarMateria()
        {
            if (servicio.GrabarMateria(new Materia(servicio.ObtenerUltimoIdMateria(), txtNombre.Text)))
            {
                MessageBox.Show("Materia guardada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dtvDetalles);
                newRow.Cells[0].Value = servicio.ObtenerUltimoIdMateria() - 1;
                newRow.Cells[1].Value = txtNombre.Text;
                dtvDetalles.Rows.Add(newRow);

                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Error al intentar grabar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




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
            
            if (dtvDetalles.CurrentCell.ColumnIndex == 2)
            {
                if (servicio.BorrarMateria(new Materia((int)dtvDetalles.CurrentRow.Cells[0].Value, txtNombre.Text)))
                {
                    MessageBox.Show("Materia borrada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtvDetalles.Rows.RemoveAt(dtvDetalles.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                
                    txtNombre.Text = dtvDetalles.SelectedCells[0].Value.ToString();
                    btnAgregar.Text = "Modificar";
                    flag = true;
                    btnCancelar.Enabled = true;
                
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            btnAgregar.Text = "Agregar";
            flag = false;
            btnCancelar.Enabled = false;
            dtvDetalles.ClearSelection();
        }
    }
}
