using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Interfaces
{
    public interface IMateriaService
    {
        List<Materia> ConsultarAsignatura();
        int ObtenerUltimoIdMateria();
        bool GrabarMateria(Materia materia);
        bool ModificarMateria(Materia materia);
        bool BorrarMateria(Materia materia);
    }
}
