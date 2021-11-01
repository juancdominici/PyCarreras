using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Datos.Interfaces
{
    interface IMateriaDao
    {
        List<Materia> GetMaterias();
        bool SaveMateria(Materia materia);
        bool UpdateMateria(Materia materia);
        bool DeleteMateria(Materia materia);
        int GetNumeroMateria();

    }
}
