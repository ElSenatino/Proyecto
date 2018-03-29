using Entidad.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Comun
{
    public class EDireccion
    {
        public EDireccion() { }

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public Int32 TipoDireccion { get; set; }
        public String NombreVia { get; set; }
        public String Numero { get; set; }
        public String Urbanizacion { get; set; }
        public String Referencia { get; set; }
        public Guid UbigeoId { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

        public virtual EUbigeo Ubigeo { get; set; } 
        public virtual EPersona Persona { get; set; }
    }
}
