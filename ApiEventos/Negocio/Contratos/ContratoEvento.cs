using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public class ContratoEvento
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public DateTime? Fecha { get; set; }

        public string? Ubicacion { get; set; }

        public int? Capacidad { get; set; }

        public string? Imagen { get; set; }
    }
}
