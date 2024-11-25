using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public string? Mail { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Confirmacione> Confirmaciones { get; set; } = new List<Confirmacione>();

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();
}
