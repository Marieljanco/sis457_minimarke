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
    
    public partial class Inventario
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public int idEmpleado { get; set; }
        public int cantidadStock { get; set; }
        public System.DateTime fechaUltimaRepocision { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
