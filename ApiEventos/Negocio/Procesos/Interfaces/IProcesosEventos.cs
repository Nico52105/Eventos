using Negocio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procesos.Interfaces
{
    public interface IProcesosEventos
    {
        RespuestaGeneral<List<ContratoEvento>> ObtenerEventos();

        RespuestaGeneral<List<ContratoEvento>> MisEventos(int idUsuario);

        RespuestaGeneral<List<ContratoEvento>> CrearEvento(ContratoEvento contratoEvento);

        RespuestaGeneral<List<ContratoEvento>> EditarEvento(ContratoEvento contratoEvento);
        
        RespuestaGeneral<List<ContratoEvento>> EliminarEvento(int idEvento);
    }
}
