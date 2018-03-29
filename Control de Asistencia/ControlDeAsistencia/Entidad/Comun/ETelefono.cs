using Entidad.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class ETelefono
    {
        public ETelefono() { }
        
        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public Int32 TipoTelefono { get; set; }
        public Int32 NroTelefono { get; set; }
        public String Observacion { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EPersona Persona { get; set; }


    }
}
