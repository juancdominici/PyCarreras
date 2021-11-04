using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraReporte
{
    public partial class FrmReporte : Form
    {
        
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();

            object val = DBNull.Value;
                val = dtpFechaDesde.Value;
                filtros.Add(new Parametro("@FECHADESDE", val));
                val = dtpFechaHasta.Value;
                filtros.Add(new Parametro("@FECHAHASTA", val));

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44373/api/Carrera/consultar";
            //SEGUIR ACÁ

            var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, filtrosJSON);
            List<Carrera> lst = JsonConvert.DeserializeObject<List<Carrera>>(resultado);



            dsCarreraBindingSource.DataSource = lst;


            this.RwCarrera.RefreshReport();
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

    internal class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;
        private ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton GetInstancia()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }


        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }


    }
    internal class DetalleCarrera
    {
        //PROPIEDADES  
        public int Id { get; set; }
        public DateTime AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Materia Materia { get; set; }
    }

    internal class Carrera
    {
        //PROPIEDADES
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }

        //CONSTRUCTOR
        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        public void AgregarDetalle(DetalleCarrera detalleCarrera)
        {
            Detalles.Add(detalleCarrera);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
    }
    internal class Materia
    {
        //PROPIEDADES
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Materia(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
