using Entidad.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class ESesion
    {
        public ESesion() { }

        public Guid Id { get; set; }
        public Guid UsuarioEquipoId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Final { get; set; }
        public bool Habilitado { get; set; }
        public Int32 TipoEntrada { get; set; }
        public DateTime Actualizacion { get; set; }

        [InverseProperty("Sesion")]
        public virtual List<EAuditoria> Auditoria { get; set; }

        public virtual EUsuarioEquipo UsuarioEquipo { get; set; }


    }
}
