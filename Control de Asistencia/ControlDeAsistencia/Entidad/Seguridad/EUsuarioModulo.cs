using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EUsuarioModulo
    {
        public EUsuarioModulo() { }

        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid ModuloId { get; set; }
        public DateTime Actualizacion { get; set; }


        public virtual EUsuario Usuario { get; set; }
        public virtual EModulo Modulo { get; set; }

    }
}
