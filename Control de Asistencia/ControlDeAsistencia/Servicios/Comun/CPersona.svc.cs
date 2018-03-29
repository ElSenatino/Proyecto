using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Logica;
using Entidad;
namespace Servicios.Comun
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CPersona" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CPersona.svc o CPersona.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CPersona : ICPersona
    {

        Logica.Comun.LPersona lPersona = new Logica.Comun.LPersona();

        public bool CrearCuenta(Entidad.Comun.EPersona persona)
        {
            return lPersona.Add(persona);
        }
    }
}
