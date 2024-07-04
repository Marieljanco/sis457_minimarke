using System;
using System.Collections.Generic;

namespace WebMinimarke.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string CedulaIdentidad { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string Direccion { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public long Celular { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public string Salario { get; set; } = null!;

    public DateOnly FechaContratacion { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
