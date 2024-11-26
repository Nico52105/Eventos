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
        IRespuestas respuestas;
        IProcesosEventos procesosEventos;
        public EventosController(IRespuestas respuestas,IProcesosEventos procesosEventos)
        {
            this.respuestas = respuestas;
            this.procesosEventos = procesosEventos;
        }

        [HttpGet("[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral.Exitosa<List<ContratoEvento>>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 500)]
        public ActionResult<RespuestaGeneral.Exitosa<object>> ObtenerEventos()
        {
            return respuestas.Formato(this.procesosEventos.ObtenerEventos());
        }

        [HttpGet("[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral.Exitosa<List<ContratoEvento>>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 500)]
        public ActionResult<RespuestaGeneral.Exitosa<object>> MisEventos(int idUsuario)
        {
            return respuestas.Formato(this.procesosEventos.MisEventos(idUsuario));
        }

        [HttpPost("[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral.Exitosa<bool>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 500)]
        public ActionResult<RespuestaGeneral.Exitosa<object>> CrearEvento(ContratoEvento contratoEvento)
        {
            return respuestas.Formato(this.procesosEventos.CrearEvento(contratoEvento));
        }

        [HttpPost("[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral.Exitosa<bool>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 500)]
        public ActionResult<RespuestaGeneral.Exitosa<object>> EditarEvento(ContratoEvento contratoEvento)
        {
            return respuestas.Formato(this.procesosEventos.EditarEvento(contratoEvento));
        }

        [HttpPost("[Action]")]
        [ProducesResponseType(typeof(RespuestaGeneral.Exitosa<bool>), 200)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 401)]
        [ProducesResponseType(typeof(RespuestaGeneral.Fallida), 500)]
        public ActionResult<RespuestaGeneral.Exitosa<object>> EliminarEvento(int idEvento)
        {
            return respuestas.Formato(this.procesosEventos.EliminarEvento(idEvento));
        }
    }
}
