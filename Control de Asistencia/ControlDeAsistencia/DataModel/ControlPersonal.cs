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
    
    public partial class ControlPersonal
    {
        public System.Guid ControlPersonaId { get; set; }
        public System.Guid PersonaId { get; set; }
        public System.DateTime Desde { get; set; }
        public System.DateTime Hasta { get; set; }
        public int DiasAsistidos { get; set; }
        public int DiasFaltados { get; set; }
    
        public virtual Personas Personas { get; set; }
    }
}
