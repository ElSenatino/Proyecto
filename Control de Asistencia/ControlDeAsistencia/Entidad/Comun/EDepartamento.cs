using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class EDepartamento
    {
        public EDepartamento() { }

        public Guid Id { get; set; }
        public String Codigo { get; set;}
        public String Nombre { get; set; }
        public DateTime Actualizacion { get; set; }


        [InverseProperty("Departamento")]
        public virtual List<ECargoPersona> CargoPersona { get; set; }
        
       


    }
}
