using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
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

        [HttpPost("cargar")]
        public IActionResult Post(List<Parametro> lst)
        {
            var carrera = new Carrera();
            var detalles = JsonConvert.DeserializeObject<List<DetalleCarrera>>(lst[3].Valor.ToString());
            carrera.Id = lst[0].Valor.ToString();
            carrera.Nombre = lst[1].Valor.ToString();
            carrera.Titulo = lst[2].Valor.ToString();
            carrera.Detalles = detalles;
            return Ok(servicio.GrabarCarrera(carrera));
        }

        [HttpPost("modificar")]
        public IActionResult Update(List<Parametro> lst)
        {
            var carrera = new Carrera();
            var detalles = JsonConvert.DeserializeObject<List<DetalleCarrera>>(lst[3].Valor.ToString());
            carrera.Id = lst[0].Valor.ToString();
            carrera.Nombre = lst[1].Valor.ToString();
            carrera.Titulo = lst[2].Valor.ToString();
            carrera.Detalles = detalles;
            return Ok(servicio.ModificarCarrera(carrera));
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
