using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    public class DetalleCarrera
    {
        //PROPIEDADES  
        public DateTime AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Materia Materia { get; set; }
    }
}
