using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EEquipo
    {
        public EEquipo() { }

        public Guid Id { get; set; }
        public String Nombre { get; set; }       
        public String NumeroIp { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        [InverseProperty("Equipo")]
        public virtual List<EUsuarioEquipo> UsuarioEquipo { get; set; }
    }
}
