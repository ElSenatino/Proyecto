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
    
    public partial class Auditorias
    {
        public System.Guid AuditoriaId { get; set; }
        public System.Guid SesionId { get; set; }
        public System.DateTime Registro { get; set; }
        public string Metodo { get; set; }
        public string CodigoRegistro { get; set; }
        public System.DateTime Actualizacion { get; set; }
    }
}
