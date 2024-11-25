using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Entidades;

public partial class Evento
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Ubicacion { get; set; }

    public int? Capacidad { get; set; }

    public string? Imagen { get; set; }

    public int? IdUsuario { get; set; }

    public virtual ICollection<Confirmacione> Confirmaciones { get; set; } = new List<Confirmacione>();

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
