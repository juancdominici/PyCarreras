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
        private ICarreraDao carreraDao;

        public CarreraService()
        {
            carreraDao = new CarreraDao();
        }

        public List<Carrera> ConsultarCarrera(List<Parametro> criterios)
        {
            return carreraDao.GetByFilters(criterios);
        }

        public bool GrabarCarrera(Carrera carrera)
        {
            return carreraDao.SaveCarrera(carrera);
        }

        public Carrera ObtenerCarreraPorId(int nro)
        {
            return carreraDao.GetById(nro);
        }

        public bool RegistrarBajaCarrera(int carrera)
        {
            return carreraDao.Delete(carrera);
        }

        public int ObtenerUltimoIdCarrera()
        {
            return carreraDao.GetNumeroCarrera();
        }

        public bool ModificarCarrera(Carrera carrera)
        {
            return carreraDao.UpdateCarrera(carrera);
        }
        public bool Login(string User, string Password)
        {
            return carreraDao.Login(User, Password);
        }
    }
}
