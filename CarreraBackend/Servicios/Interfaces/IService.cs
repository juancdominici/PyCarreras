using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios
{
    public interface IService
    {
        bool RegistrarBajaCarrera(int carrera);
        List<Carrera> ConsultarCarrera(List<Parametro> criterios);
        bool GrabarCarrera(Carrera carrera);
        Carrera ObtenerCarreraPorId(int nro);
        int ObtenerUltimoIdCarrera();

    }
}
