using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public class RespuestaGeneral<T>
    {
        public Boolean Error { get; set; }
        public string Mensaje { get; set; }
        public int StatusCode { get; set; }
        public T? Resultado { get; set; }
    }
}
