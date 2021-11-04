using CarreraBackend.Entidades;
using CarreraBackend.Servicios;
using CarreraBackend.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarreraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private IMateriaService servicio;

        public MateriaController()
        {
            servicio = new ServiceFactoryImp().CrearMateriaService();
        }

        [HttpGet("consultar")]
        public IActionResult GetMaterias()
        {
            return Ok(servicio.ConsultarAsignatura());
        }

        [HttpGet("ultimoId")]
        public IActionResult Get()
        {
            return Ok(servicio.ObtenerUltimoIdMateria());
        }

        [HttpPost("cargar")]
        public IActionResult Post(List<Parametro> lst)
        {
            return Ok(servicio.GrabarMateria(new Materia(Convert.ToInt32(lst[0].Valor.ToString()), lst[1].Valor.ToString())));
        }

        [HttpPost("modificar")]
        public IActionResult Update(List<Parametro> lst)
        {
            return Ok(servicio.ModificarMateria(new Materia(Convert.ToInt32(lst[0].Valor.ToString()), lst[1].Valor.ToString())));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(servicio.BorrarMateria(id));
        }
    }
}
