using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteCarrera.Reportes
{
    public partial class FrmReportePlanesEstudio : Form
    {
        public FrmReportePlanesEstudio()
        {
            InitializeComponent();
        }

        private void FrmReportePlanesEstudio_Load(object sender, EventArgs e)
        {

        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> criterios = new List<Parametro>();

            object val;

            val = dtpDesde.Value;
            criterios.Add(new Parametro("@DESDE", val));

            val = dtpHasta.Value;
            criterios.Add(new Parametro("@HASTA", val));


            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cnn.ConnectionString = @"Data Source=DESKTOP-37D06RA;Initial Catalog=DB_CARRERA;Integrated Security=True";
            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PLANES_DE_ESTUDIO";

            foreach (Parametro p in criterios)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            table.Load(cmd.ExecuteReader());
            cnn.Close();


            rvPlanesEstudio.LocalReport.DataSources.Clear();
            rvPlanesEstudio.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSCarrera", table));
            rvPlanesEstudio.RefreshReport();

        }
    }

    internal class Parametro
    {
        public Parametro()
        {
        }

        public string Nombre { get; set; }
        public object Valor { get; set; }

        public Parametro(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
