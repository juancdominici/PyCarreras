using CarreraBackend.Servicios;
using CarreraBackend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Datos.Interfaces
{
    interface ICarreraDao
    {
        bool Delete(int nro);
        List<Carrera> GetByFilters(List<Parametro> criterios);
        bool SaveCarrera(Carrera carrera);
        bool UpdateCarrera(Carrera carrera);
        Carrera GetById(int id);
        int GetNumeroCarrera();
        bool Login(string User, string Password);
    }
}
