using CarreraBackend.Datos.Implementaciones;
using CarreraBackend.Datos.Interfaces;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios
{
    class CarreraService : IService
    {
        private ICarreraDao dao;

        public CarreraService()
        {
            dao = new CarreraDao();
        }

        public List<Carrera> ConsultarCarrera(List<Parametro> criterios)
        {
            return dao.GetByFilters(criterios);
        }

        public List<Materia> ConsultarAsignatura()
        {
            return dao.GetMaterias();
        }

        public bool GrabarCarrera(Carrera carrera)
        {
            return dao.Save(carrera);
        }

        public Carrera ObtenerCarreraPorId(int nro)
        {
            return dao.GetById(nro);
        }

        public bool RegistrarBajaCarrera(int carrera)
        {
            return dao.Delete(carrera);
        }

        public int ObtenerUltimoIdMateria()
        {
            return dao.GetNumeroMateria();
        }
    }
}
