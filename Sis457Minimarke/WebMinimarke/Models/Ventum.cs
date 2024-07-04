using System;
using System.Collections.Generic;

namespace WebMinimarke.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpleado { get; set; }

    public int Transaccion { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
