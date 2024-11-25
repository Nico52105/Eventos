using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Confirmacione
{
    public int Id { get; set; }

    public int? IdEvento { get; set; }

    public int? IdUsuario { get; set; }

    public virtual Evento? IdEventoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
