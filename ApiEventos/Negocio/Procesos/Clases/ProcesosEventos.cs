using Datos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Negocio.Contratos;
using Negocio.Procesos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procesos.Clases
{
    public class ProcesosEventos: IProcesosEventos
    {
        AgendaContext agendaContext;
        IConfiguration configuration;
        public ProcesosEventos(IConfiguration iconfiguration,AgendaContext agendaContext)
        {
            this.configuration = iconfiguration;
            this.agendaContext = agendaContext;
        }

        public RespuestaGeneral.Exitosa<object> ObtenerEventos()
        {
            RespuestaGeneral.Exitosa<object> respuesta = new RespuestaGeneral.Exitosa<object>();
            try
            {
                List<ContratoEvento> eventos= agendaContext.Eventos.Select(e=>
                new ContratoEvento {
                    Id=e.Id,
                    Nombre=e.Nombre,
                    Descripcion = e.Descripcion,
                    Ubicacion = e.Ubicacion,
                    Fecha = e.Fecha,
                    Capacidad = e.Capacidad,
                    Imagen = e.Imagen
                }).ToList();
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al ObtenerEventos";
                respuesta.Error = false;
                respuesta.Resultado = eventos;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al ObtenerEventos";
                respuesta.Error = true;
                respuesta.Resultado = null;
            }
            return respuesta;
        }

        public RespuestaGeneral.Exitosa<object> MisEventos(int idUsuario)
        {
            RespuestaGeneral.Exitosa<object> respuesta = new RespuestaGeneral.Exitosa<object>();
            try
            {
                List<ContratoEvento> eventos = agendaContext.Eventos.Where(e=>e.IdUsuario== idUsuario).Select(e =>
                new ContratoEvento
                {
                    Id = e.Id,
                    Nombre = e.Nombre,
                    Descripcion = e.Descripcion,
                    Ubicacion = e.Ubicacion,
                    Fecha = e.Fecha,
                    Capacidad = e.Capacidad,
                    Imagen = e.Imagen
                }).ToList();
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al MisEventos";
                respuesta.Error = false;
                respuesta.Resultado = eventos;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al MisEventos";
                respuesta.Error = true;
                respuesta.Resultado = null;
            }
            return respuesta;
        }

        public RespuestaGeneral.Exitosa<object> CrearEvento(ContratoEvento contratoEvento)
        {
            RespuestaGeneral.Exitosa<object> respuesta = new RespuestaGeneral.Exitosa<object>();
            try
            {
                Evento evento = new Evento
                {
                    Nombre = contratoEvento.Nombre,
                    Descripcion = contratoEvento.Descripcion,
                    Ubicacion = contratoEvento.Ubicacion,
                    Fecha = contratoEvento.Fecha,
                    Capacidad = contratoEvento.Capacidad,
                    Imagen = contratoEvento.Imagen,
                    IdUsuario = 1
                };
                agendaContext.Eventos.Add(evento);
                agendaContext.SaveChanges();
                respuesta.StatusCode = StatusCodes.Status200OK;
                respuesta.Mensaje = "Operacion exitosa al CrearEvento";
                respuesta.Error = false;
                respuesta.Resultado = true;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al CrearEvento";
                respuesta.Error = true;
                respuesta.Resultado = false;
            }
            return respuesta;
        }

        public RespuestaGeneral.Exitosa<object> EditarEvento(ContratoEvento contratoEvento)
        {
            RespuestaGeneral.Exitosa<object> respuesta = new RespuestaGeneral.Exitosa<object>();
            try
            {                
                Evento evento = agendaContext.Eventos.Where(e => e.Id == contratoEvento.Id).FirstOrDefault();
                if (evento != null)
                { 
                    evento.Nombre = contratoEvento.Nombre;
                    evento.Descripcion = contratoEvento.Descripcion;
                    evento.Ubicacion = contratoEvento.Ubicacion;
                    evento.Fecha = contratoEvento.Fecha;
                    evento.Capacidad = contratoEvento.Capacidad;
                    evento.Imagen = contratoEvento.Imagen;
                    agendaContext.SaveChanges();
                    respuesta.StatusCode = StatusCodes.Status200OK;
                    respuesta.Mensaje = "Operacion exitosa al EditarEvento";
                    respuesta.Error = false;
                }
                else
                {
                    respuesta.StatusCode = StatusCodes.Status417ExpectationFailed;
                    respuesta.Mensaje = "Operacion fallida evento no encontrado";
                    respuesta.Error = true;
                } 
                respuesta.Resultado = true;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al EditarEvento";
                respuesta.Error = true;
                respuesta.Resultado = false;
            }
            return respuesta;
        }

        public RespuestaGeneral.Exitosa<object> EliminarEvento(int idEvento)
        {
            RespuestaGeneral.Exitosa<object> respuesta = new RespuestaGeneral.Exitosa<object>();
            try
            {
                Evento evento = agendaContext.Eventos.Where(e => e.Id == idEvento).FirstOrDefault();
                if (evento != null)
                {
                    agendaContext.Eventos.Remove(evento);
                    agendaContext.SaveChanges();
                    respuesta.StatusCode = StatusCodes.Status200OK;
                    respuesta.Mensaje = "Operacion exitosa al EliminarEvento";
                    respuesta.Error = false;
                }
                else
                {
                    respuesta.StatusCode = StatusCodes.Status417ExpectationFailed;
                    respuesta.Mensaje = "Operacion fallida evento no encontrado";
                    respuesta.Error = true;
                }
                respuesta.Resultado = true;
            }
            catch (Exception ex)
            {
                respuesta.StatusCode = StatusCodes.Status500InternalServerError;
                respuesta.Mensaje = "Operacion fallida al EliminarEvento";
                respuesta.Error = true;
                respuesta.Resultado = false;
            }
            return respuesta;
        }
    }    
}

