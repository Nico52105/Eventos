using Datos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.Contratos;
using Negocio.Procesos.Clases;
using Negocio.Procesos.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        IProcesosEventos procesosEventos;
        public EventosController(IProcesosEventos procesosEventos)
        {
            this.procesosEventos = procesosEventos;
        }

        [HttpGet("[Action]")]
        public ActionResult<RespuestaGeneral<List<ContratoEvento>>> ObtenerEventos()
        {
            return Ok(this.procesosEventos.ObtenerEventos());
        }

        [HttpGet("[Action]")]
        public IActionResult MisEventos(int idUsuario)
        {
            return Ok(this.procesosEventos.MisEventos(idUsuario));
        }

        [HttpPost("[Action]")]
        public IActionResult CrearEvento(ContratoEvento contratoEvento)
        {
            return Ok(this.procesosEventos.CrearEvento(contratoEvento));
        }

        [HttpPost("[Action]")]
        public IActionResult EditarEvento(ContratoEvento contratoEvento)
        {
            return Ok(this.procesosEventos.EditarEvento(contratoEvento));
        }

        [HttpPost("[Action]")]
        public IActionResult EliminarEvento(int idEvento)
        {
            return Ok(this.procesosEventos.EliminarEvento(idEvento));
        }
    }
}
