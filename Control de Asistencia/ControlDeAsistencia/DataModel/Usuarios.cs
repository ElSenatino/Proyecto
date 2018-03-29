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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.RolUsuarios = new HashSet<RolUsuarios>();
            this.UsuarioEquipo = new HashSet<UsuarioEquipo>();
            this.UsuarioModulos = new HashSet<UsuarioModulos>();
        }
    
        public System.Guid UsuarioId { get; set; }
        public System.Guid PersonaId { get; set; }
        public string Codigo { get; set; }
        public string Clave { get; set; }
        public bool CambiaContraseña { get; set; }
        public System.DateTime UltimaOperacion { get; set; }
        public bool EnLinea { get; set; }
        public bool Administracion { get; set; }
        public bool Habilitado { get; set; }
        public System.DateTime Actualizacion { get; set; }
    
        public virtual Personas Personas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolUsuarios> RolUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioEquipo> UsuarioEquipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioModulos> UsuarioModulos { get; set; }
    }
}
