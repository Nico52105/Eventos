using Microsoft.AspNetCore.Mvc;
using Negocio.Contratos;

namespace API
{
    public interface IRespuestas
    {
        public ActionResult<RespuestaGeneral.Exitosa<object>> Formato(RespuestaGeneral.Exitosa<object> respuesta);
    }
    public class Respuestas : ControllerBase, IRespuestas
    {
        public ActionResult<RespuestaGeneral.Exitosa<object>> Formato(RespuestaGeneral.Exitosa<object> respuesta)
        {
            switch (respuesta.StatusCode)
            {
                case StatusCodes.Status200OK:
                    return Ok(respuesta);
                case StatusCodes.Status401Unauthorized:
                    return Unauthorized(respuesta);
                case StatusCodes.Status500InternalServerError:
                    return StatusCode(StatusCodes.Status500InternalServerError, respuesta);
                default:
                    return NoContent();
            }
        }
    }
}
