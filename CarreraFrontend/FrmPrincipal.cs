using CarreraBackend.Servicios;
using CarreraFrontend.Cliente;
using Newtonsoft.Json;
using CarreraReporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReporteCarrera.Reportes;

namespace CarreraFrontend
{
    public partial class FrmPrincipal : Form
    {
        private IService servicio;

        public FrmPrincipal()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearCarreraService();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version Beta de la APP \n \n Integrantes:\n113231 - Barrera Dominici, Juan Cruz\n113103 - Bouchet, Julian\n113009 - Brosio, Emiliano\n113229 - Brugiafreddo, Benjamin\n112824 - Fiorelli, Facundo", "TP Final - Carreras");
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePlanesEstudio frmNuevo = new FrmReportePlanesEstudio();
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

        private void altaDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaCarrera frmNuevo = new FrmAltaCarrera(Accion.CREATE, servicio.ObtenerUltimoIdCarrera());
            frmNuevo.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.Enabled = true;
            soporteToolStripMenuItem.Enabled = false;
            transaccionToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;
            ayudaToolStripMenuItem.Enabled = false;
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            List<Parametro> lst = new List<Parametro>();


            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtContrasena.Text))
            {
                lst.Add(new Parametro("user", txtUsuario.Text));
                lst.Add(new Parametro("pass", txtContrasena.Text));
            }
            else
            {
                MessageBox.Show("Ingrese un usuario y una contraseña!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string obj = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:44373/api/Login/login";

            var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, obj);
            var res = JsonConvert.DeserializeObject(resultado);

            if (Convert.ToBoolean(res))
            {
                soporteToolStripMenuItem.Enabled = true;
                transaccionToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = true;
                ayudaToolStripMenuItem.Enabled = true;
                btnIniciarSesion.Visible = false;
                txtUsuario.Visible = false;
                txtContrasena.Visible = false;
                lblTitulo.Visible = false;
                linea1.Text = "Trabajo Final";
                linea1.Font = new Font("Segoe UI", 16, FontStyle.Italic);
                linea2.Text = "de Programación II";
                linea2.Font = new Font("Segoe UI", 16, FontStyle.Italic);


                MessageBox.Show("Conectado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("No tiene permisos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
