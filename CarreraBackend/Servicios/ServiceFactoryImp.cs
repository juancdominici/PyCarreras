using CarreraBackend.Servicios.Implementaciones;
using CarreraBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraBackend.Servicios
{
    public class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IService CrearCarreraService()
        {
            return new CarreraService();
        }
        public override IMateriaService CrearMateriaService()
        {
            return new MateriaService();
        }
    }
}
