//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReporteModulos
    {
        public System.Guid ReporteModuloId { get; set; }
        public string Nombre { get; set; }
        public System.Guid ReporteId { get; set; }
        public System.Guid ModuloId { get; set; }
        public System.DateTime Actualizacion { get; set; }
    
        public virtual Modulos Modulos { get; set; }
        public virtual Reportes Reportes { get; set; }
    }
}
