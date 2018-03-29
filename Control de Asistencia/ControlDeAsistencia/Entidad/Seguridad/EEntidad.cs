using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EEntidad
    {
        public EEntidad() { }

        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public String NombreMostrado { get; set; }
        public String NombreMostradoPlural { get; set; }
        public Guid ModuloId { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EModulo Modulo { get; set; }
        [InverseProperty("Entidad")]
        public virtual List<EAuditoria> Auditoria { get; set; }

    }
}
