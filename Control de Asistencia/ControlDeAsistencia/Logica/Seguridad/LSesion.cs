
using Entidad;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LSSesion
    {

        public bool IniciarSesionMovil(String  Codigo , String Contraseña , EEquipo equipo)
        {

            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var ObtenerUsuario = context.Usuarios.Where(x => x.Codigo == Codigo && x.Clave == Contraseña).FirstOrDefault();
                    var ObtenerEquipo = context.Equipos.Where(x => x.NumeroIP == equipo.NumeroIp).FirstOrDefault();
                    var ObtenerUsuarioEquipo = context.UsuarioEquipo.Where(x => x.UsuarioId == ObtenerUsuario .UsuarioId && x.EquipoId == ObtenerEquipo.EquipoId).FirstOrDefault();

                    if (ObtenerUsuario == null)
                        throw new Exception("Error al Ingresar : Usuario y/o Contraseña inválidos!");

                    if (ObtenerUsuario.Habilitado == false)
                        throw new Exception("Error al Ingresar: Usuario se encuentra deshabilitado");

                    if (ObtenerEquipo == null)
                    {
                        LEquipo equipoLogica = new LEquipo();
                        equipoLogica.Add(equipo);
                    }

                    if (ObtenerEquipo.Habilitado == false)
                        throw new Exception("Error al Ingresar: Equipo se encuentra deshabilitado");

                    if(ObtenerUsuarioEquipo == null)
                        throw new Exception("Error al Ingresar: Usuario no tiene permiso para ingresar. Equipo no registrado");


                    DataModel.Sesiones sesion = new DataModel.Sesiones();

                    sesion.SesionId = Guid.NewGuid();
                    sesion.TipoEntrada = 1; // movil
                    sesion.UsuarioEquipoId = ObtenerUsuarioEquipo.EquipoId;
                    sesion.Inicio = DateTime.Now;
                    sesion.Final = DateTime.Now;
                    sesion.Habilitado = true;
                    sesion.Actualizacion = DateTime.Now;

                    ESesion sesionIngresada = new ESesion();
                    sesionIngresada.Id = sesion.SesionId;
                    sesionIngresada.TipoEntrada = sesion.TipoEntrada;
                    sesionIngresada.Inicio = sesion.Inicio;
                    sesionIngresada.Final = sesion.Final;
                    sesionIngresada.Actualizacion = sesion.Actualizacion;
                    Global.SesionActiva = sesionIngresada;

                    context.Sesiones.Add(sesion);
                    blResultado = true;
                }

            }
            catch (Exception ex ) 
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;
        }

        public bool CerrarSesion(Guid IdSesion)
        {
            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {

                    var obtenerSesion = context.Sesiones.Where(x => x.SesionId == IdSesion).FirstOrDefault();


                    if (obtenerSesion != null)
                        throw new Exception("Error : No se encuentra esta sesion ");

                    obtenerSesion.Final = DateTime.Now;
                    obtenerSesion.Habilitado = false;
                    obtenerSesion.Actualizacion = DateTime.Now;
                    context.SaveChanges();

                    blResultado = true;
                }
            }
            catch (Exception ex)
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;

        }

    }

}