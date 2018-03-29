using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class ERolUsuario
    {
        public ERolUsuario() { }

        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid RolId { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EUsuario Usuario { get; set; }
        public virtual ERol Rol { get; set; }
    }
}
