using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISSesion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISSesion
    {
        //[OperationContract]
        //void DoWork();


        [OperationContract]
        bool InciarSesion(String Codigo, String Contraseña , EEquipo equipo);
        bool CerrarSesion(Guid IdSesion);


    }
}
