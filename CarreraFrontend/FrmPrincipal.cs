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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version Beta de la APP \n \n Integrantes:\n113231 - Barrera Dominici, Juan Cruz\n113103 - Bouchet, Julian\n113009 - Brosio, Emiliano\n113229 - Brugiafreddo, Benjamin\n112824 - Fiorelli, Facundo", "TP Final - Carreras");
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmNuevo = new FrmReporte();
            frmNuevo.ShowDialog();
        }


        private void consultaDeCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCarrera frmNuevo = new FrmConsultaCarrera();
            frmNuevo.ShowDialog();
        }

        private void consultarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMaterias frmNuevo = new FrmConsultaMaterias();
            frmNuevo.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
