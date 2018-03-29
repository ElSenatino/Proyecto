using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class ECorreo
    {
        public ECorreo() { }

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public String CorreoElectronico { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EPersona Persona { get; set; }

    }
}   
