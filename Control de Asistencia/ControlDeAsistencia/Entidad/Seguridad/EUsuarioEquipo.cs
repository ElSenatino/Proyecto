using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EUsuarioEquipo
    {
        public EUsuarioEquipo() { }

        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid EquipoId { get; set; }

        [InverseProperty("UsuarioEquipo")]
        public virtual List<ESesion> Sesion{ get; set; }

        public virtual EUsuario Usuario { get; set; }
        public virtual EEquipo Equipo { get; set; }
        


      
    }
}
