
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CadMinimarke
{

using System;
    using System.Collections.Generic;
    
public partial class Venta
{

    public int id { get; set; }

    public int idProducto { get; set; }

    public int idCliente { get; set; }

    public int idEmpleado { get; set; }

    public int transaccion { get; set; }

    public System.DateTime fecha { get; set; }



    public virtual Cliente Cliente { get; set; }

    public virtual Empleado Empleado { get; set; }

    public virtual Producto Producto { get; set; }

}

}
