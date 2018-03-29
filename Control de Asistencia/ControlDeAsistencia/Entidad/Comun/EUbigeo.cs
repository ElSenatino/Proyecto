using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class EUbigeo
    {
        public EUbigeo(){}

        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public String Pais { get; set; }
        public String Departamento { get; set; }
        public String Provincia { get; set; }
        public String Distrito { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        [InverseProperty("Ubigeo")]
        public virtual List<EDireccion> Direccion { get; set; }

    }
}
