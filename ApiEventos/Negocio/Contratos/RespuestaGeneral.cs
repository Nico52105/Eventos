using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public class RespuestaGeneral
    {
        public Boolean Error { get; set; }
        public string Mensaje { get; set; }
        public int StatusCode { get; set; }
        

        public class Exitosa<T>: RespuestaGeneral
        {
            public T? Resultado { get; set; }
        }

        public class Fallida : RespuestaGeneral
        {
        }
    }
}
