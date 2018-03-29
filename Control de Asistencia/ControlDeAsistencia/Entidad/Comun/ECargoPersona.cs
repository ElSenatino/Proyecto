using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class ECargoPersona
    {
        public ECargoPersona() { }

        public Guid Id { get; set;}
        public Guid CargoId { get; set;}
        public Guid PersonaId { get; set; }
        public Guid DepartamentoId { get; set; }
        public Guid JornadaId { get; set; }
        public DateTime Actualizacion { get; set;}

 
        public virtual ECargo Cargo { get; set;}
        public virtual EPersona Persona { get; set; }
        public virtual EDepartamento Departamento { get; set; }
        public virtual EJornada Jornada { get; set; }
    }
}
