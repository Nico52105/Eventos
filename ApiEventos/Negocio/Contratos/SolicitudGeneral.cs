using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public class SolicitudGeneral<T>
    {
        [FromBody]
        public T Data { get; set; }
    }
}
