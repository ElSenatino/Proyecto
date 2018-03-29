using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EReporte
    {
        public EReporte() { }

        public Guid Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String ReportServer { get; set; }
        public String Ruta { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }
       
        [InverseProperty("Reporte")]
        public virtual List<EReporteModulo> ReporteModulo { get; set; }
  
    }
}
