using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios.Comun
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICPersona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICPersona
    {
        [OperationContract]
        bool CrearCuenta(Entidad.Comun.EPersona persona);
    }
}
