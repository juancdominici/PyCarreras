using CarreraBackend.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarreraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private IService servicio;

        public CarreraController()
        {
            servicio = new ServiceFactoryImp().CrearCarreraService();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(servicio.ObtenerCarreraPorId(id));
        }

        [HttpPost("consultar")]
        public IActionResult GetCarreras(List<Parametro> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(servicio.ConsultarCarrera(lst));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(servicio.RegistrarBajaCarrera(id));
        }
    }
}
