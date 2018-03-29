using Entidad.Seguridad;
using Logica.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SSesion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SSesion.svc o SSesion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SSesion : ISSesion
    {

        LSSesion _sesion = null;
        //public void DoWork()
        //{
        //}


        public bool InciarSesion(String Codigo , String Contraseña , EEquipo equipo)
        {
            _sesion = new LSSesion();
            return _sesion.IniciarSesionMovil(Codigo , Contraseña , equipo);
        }

     
        public bool CerrarSesion(Guid Id)
        {
            _sesion = new LSSesion();
            return _sesion.CerrarSesion(Id);
        }

    }
}
