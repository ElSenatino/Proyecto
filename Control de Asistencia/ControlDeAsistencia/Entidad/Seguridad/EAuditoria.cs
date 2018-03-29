using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EAuditoria
    {
        public EAuditoria() { }

        public Guid Id { get; set; }
        public Guid SesionId { get; set; }
        public Guid EntidadId { get; set; }
        public DateTime Registro { get; set; }
        public String Metodo { get; set; }
        public String CodigoRegistro { get; set; }
        public DateTime Actualizacion { get; set; }


        public virtual ESesion Sesion { get; set; }
        public virtual EEntidad  Entidad { get; set; }

    }
}
