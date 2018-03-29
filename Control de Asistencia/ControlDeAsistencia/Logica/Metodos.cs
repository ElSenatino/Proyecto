using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Metodos
    {

        public static bool SesionActiva(ESesion sesionIniciada ) 
        {
            bool blResultado = false;
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var Activo = context.Sesiones.Where(x => x.SesionId == sesionIniciada.Id).FirstOrDefault();

                    if (Activo == null)
                        throw new Exception("Excepción: La sesion No existe vuelva a ingresar");

                    if (Activo.Habilitado == false)
                        throw new Exception("Excepción: La sesion se encuentra deshabilitada vuelva a ingresar");
                }

                    blResultado = true;
            }
            catch (Exception ex)
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;
        }
        public static bool Modulos(Guid usuarioId , Guid ModuloId)
        {
            bool blResultado = false;
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var VerificarUsuario = context.Usuarios.Where(x => x.UsuarioId == usuarioId).FirstOrDefault();
                    var VerificarModulo = context.Modulos.Where(x => x.ModuloId== ModuloId).FirstOrDefault();
                    var VerificarUsuarioModulo = context.UsuarioModulos.Where(x => x.ModuloId == ModuloId && x.UsuarioId ==usuarioId).FirstOrDefault();


                    if (VerificarModulo == null)
                        throw new Exception("Excepción: Modulo no existe vuelva a ingresar");

                    if (VerificarModulo.Habilitado == false)
                        throw new Exception("Exceptión: El módulo esta deshabilitado");

                    if (VerificarUsuario == null)
                        throw new Exception("Excepción: Usuario ingresado no existe ");

                    if (VerificarUsuario.Habilitado == false)
                        throw new Exception("Excepción: Usuario ingresado se encuentra deshabilitado");


                    if (VerificarUsuarioModulo == null)
                        throw new Exception("Excepción: Usuario ingresado no tiene permiso para ingresar al este módulo");

                   

                }

                blResultado = true;
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
