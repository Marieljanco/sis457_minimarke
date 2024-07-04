using System;
using System.Collections.Generic;

namespace WebMinimarke.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string CedulaIdentidad { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
