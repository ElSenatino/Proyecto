using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class ECargo
    {
        public ECargo() { }

        public Guid Id { get; set; }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        [InverseProperty("Cargo")]
        public virtual List <ECargoPersona> CargoPersona { get; set; }


    }
}
