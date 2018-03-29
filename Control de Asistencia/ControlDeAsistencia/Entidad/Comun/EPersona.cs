using Entidad.Asistencia;
using Entidad.Enumeradores;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class EPersona
    {
        public EPersona() { }

        public Guid Id { get; set; }
        public String NombreGenerado { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public Int32 TipoDocumento { get; set; }
        public String NroDocumento { get; set; }
        public Int32 TipoSexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public byte[] Imagen { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Acutalizacion { get; set; } 

        [InverseProperty("Persona")]
        public virtual List <EAsistencia> Asistencia { get; set; }
        [InverseProperty("Persona")]
        public virtual List<EControlPersonal> ControlPersonal { get; set; }
        [InverseProperty("Persona")]
        public virtual List<EJustificacion> Justificacion { get; set; }
        [InverseProperty("Persona")]
        public virtual List<EPermiso> Permiso { get; set; }
        [InverseProperty("Persona")]
        public virtual List<ESanciones> Sancion { get; set; }
        [InverseProperty("Persona")]
        public virtual List<EVacaciones> Vacacion { get; set; }
        [InverseProperty("Persona")]
        public virtual List<ECargoPersona> CargoPersona { get; set; }
        [InverseProperty("Persona")]
        public virtual List<ECorreo> Correo { get; set; }
        [InverseProperty("Persona")]
        public virtual List<EDireccion> Direccion { get; set; }
        [InverseProperty("Persona")]
        public virtual List<ETelefono> Telefono { get; set; }
       
    }
}
