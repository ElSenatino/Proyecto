using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Asistencia
{
    public class EPermiso
    {
        public EPermiso() { }

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public String Detalle { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EPersona Persona { get; set; }
    }
}
