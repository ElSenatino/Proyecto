using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EReporteModulo 
    {
        public EReporteModulo() { }

        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public Guid ReporteId { get; set; }
        public Guid ModuloId { get; set; }
        public DateTime Actualizacion { get; set; }


        public virtual EReporte Reporte { get; set; }
        public virtual EModulo Modulo { get; set; }

    }
}
