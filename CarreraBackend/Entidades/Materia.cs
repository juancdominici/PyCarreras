using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Entidades
{
    public class Materia
    {
        //PROPIEDADES
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
