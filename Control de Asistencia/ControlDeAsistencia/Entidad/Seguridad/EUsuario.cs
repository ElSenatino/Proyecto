using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Seguridad
{
    public class EUsuario
    {
        public EUsuario() { }

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public String Codigo { get; set; }
        public String Clave { get; set; }
        public bool CambiaContraseña { get; set; }
        public DateTime UltimaOperacion { get; set; }
        public bool EnLinea { get; set; }
        public bool Administrador { get; set; }
        public bool Habilitado { get; set; }
        public DateTime Actualizacion { get; set; }

       [InverseProperty("Usuario")]
       public virtual List<ERolUsuario> RolUsuario { get; set; }
       [InverseProperty("Usuario")]
       public virtual List<EUsuarioEquipo> UsuarioEquipo { get; set; }
       [InverseProperty("Usuario")]
       public virtual List<EUsuarioModulo> UsuarioModulo { get; set; }
       
       public virtual EPersona Persona { get; set; }


    }
}
