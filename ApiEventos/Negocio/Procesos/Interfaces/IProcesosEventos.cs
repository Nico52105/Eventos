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
        RespuestaGeneral.Exitosa<object> ObtenerEventos();

        RespuestaGeneral.Exitosa<object> MisEventos(int idUsuario);

        RespuestaGeneral.Exitosa<object> CrearEvento(ContratoEvento contratoEvento);

        RespuestaGeneral.Exitosa<object> EditarEvento(ContratoEvento contratoEvento);

        RespuestaGeneral.Exitosa<object> EliminarEvento(int idEvento);
    }
}
