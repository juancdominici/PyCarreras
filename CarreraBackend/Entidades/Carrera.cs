using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CarreraBackend.Entidades
{
    public class Carrera
    {
        //PROPIEDADES
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
}
