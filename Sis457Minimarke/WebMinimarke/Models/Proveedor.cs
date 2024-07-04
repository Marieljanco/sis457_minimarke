using System;
using System.Collections.Generic;

namespace WebMinimarke.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreEmpresa { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public long Celular { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
