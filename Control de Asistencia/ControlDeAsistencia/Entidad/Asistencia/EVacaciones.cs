using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Asistencia
{
    public class EVacaciones
    {
        public EVacaciones() { }

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public DateTime Inicio { get; set;}  
        public DateTime Final { get; set;}
        public String Descripcion { get; set; }
        public DateTime Actualizacion { get; set;}

        public virtual EPersona Persona { get; set; }


    }
}
