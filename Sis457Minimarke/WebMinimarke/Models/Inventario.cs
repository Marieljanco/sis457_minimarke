using System;
using System.Collections.Generic;

namespace WebMinimarke.Models;

public partial class Inventario
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public int IdProveedor { get; set; }

    public int IdEmpleado { get; set; }

    public int CantidadStock { get; set; }

    public DateOnly FechaUltimaRepocision { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
