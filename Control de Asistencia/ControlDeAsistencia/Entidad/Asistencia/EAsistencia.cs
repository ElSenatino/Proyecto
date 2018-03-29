using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Asistencia
{
    public class EAsistencia
    {
        public EAsistencia() { }

        public Guid Id { get; set;}
        public Int32 Mes { get; set; }
        public Int32 Año { get; set; }
        public Guid PersonaId { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime? InicioAlmuerzo { get; set;}
        public DateTime? FinalAlmuerzo { get; set; }
        public DateTime? Salida { get; set; }
       
        public virtual EPersona Persona { get; set; }
    }
}
