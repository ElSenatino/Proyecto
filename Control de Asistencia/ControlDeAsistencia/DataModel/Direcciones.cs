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
    
    public partial class Direcciones
    {
        public System.Guid DireccionId { get; set; }
        public System.Guid PersonaId { get; set; }
        public int TipoDireccion { get; set; }
        public string NombreVia { get; set; }
        public string Numero { get; set; }
        public string Urbanizacion { get; set; }
        public string Referencia { get; set; }
        public System.Guid UbigeoId { get; set; }
        public bool Habilitado { get; set; }
        public System.DateTime Actualizacion { get; set; }
    
        public virtual Personas Personas { get; set; }
        public virtual Ubigeos Ubigeos { get; set; }
    }
}