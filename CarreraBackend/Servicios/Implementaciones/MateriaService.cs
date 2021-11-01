using CarreraBackend.Datos.Implementaciones;
using CarreraBackend.Datos.Interfaces;
using CarreraBackend.Entidades;
using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios.Implementaciones
{
    class MateriaService : IMateriaService
    {
        private IMateriaDao dao;

        public MateriaService()
        {
            dao = new MateriaDao();
        }

        public List<Materia> ConsultarAsignatura()
        {
            return dao.GetMaterias();
        }

        public int ObtenerUltimoIdMateria()
        {
            return dao.GetNumeroMateria();
        }
        public bool GrabarMateria(Materia materia)
        {
            return dao.SaveMateria(materia);
        }

    }
}
