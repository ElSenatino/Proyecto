using Entidad.Comun;
using Entidad.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Asistencia
{
    public class EJornada
    {
        public EJornada() { }

        public Guid Id { get; set; }
        public Int32 TipoJornada { get; set; }
        public String Descripcion { get; set; }
        public String Ingreso { get; set; }
        public String Salida { get; set;}
        public DateTime Actualizacion { get; set; }

        [InverseProperty("Jornada")]
        public virtual List<ECargoPersona> CargoPersona { get; set; }


    }
}
