
using Entidad.Comun;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LUsuario
    {

        private ESesion sesionIniciada { get; set; }
        public LUsuario() { }
        public LUsuario(ESesion _sesion) { this.sesionIniciada = _sesion; }

        public bool Add(EUsuario eUsuario)
        {
            bool blResultado = false;
            using (var  context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        DataModel.Usuarios usuario = new DataModel.Usuarios();

                        usuario.UsuarioId = Guid.NewGuid();
                        usuario.PersonaId = eUsuario.PersonaId;
                        usuario.Codigo = eUsuario.Codigo.Trim().ToUpper();
                        usuario.Clave = eUsuario.Clave.Trim().ToUpper();
                        usuario.CambiaContraseña = eUsuario.CambiaContraseña;
                        usuario.UltimaOperacion = eUsuario.UltimaOperacion;
                        usuario.EnLinea = eUsuario.EnLinea;
                        usuario.Administracion = eUsuario.Administrador;
                        usuario.Habilitado = eUsuario.Habilitado;
                        usuario.Actualizacion = DateTime.Now;

                        if (ValidateFields(eUsuario))
                        {
                            context.Usuarios.Add(usuario);
                            trans.Commit();
                            blResultado = true;
                        }


                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        blResultado = false;
                        throw new Exception(ex.Message);
                    }
                }
            }
            return blResultado;
        }
        public bool Edit(EUsuario eUsuario)
        {
            bool blResultado = false;
            using (var context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (ValidateFields(eUsuario))
                        {
                            var usuarioAnterior = context.Usuarios.Where(x => x.UsuarioId == eUsuario.Id).FirstOrDefault();

                            if (usuarioAnterior == null)
                            throw new Exception("Dato seleccionado no existe!");

                            usuarioAnterior.PersonaId = eUsuario.PersonaId;
                            usuarioAnterior.Codigo = eUsuario.Codigo.Trim().ToUpper();
                            usuarioAnterior.Clave = eUsuario.Clave.Trim().ToUpper();
                            usuarioAnterior.CambiaContraseña = eUsuario.CambiaContraseña;
                            usuarioAnterior.UltimaOperacion = eUsuario.UltimaOperacion;
                            usuarioAnterior.EnLinea = eUsuario.EnLinea;
                            usuarioAnterior.Administracion = eUsuario.Administrador;
                            usuarioAnterior.Habilitado = eUsuario.Habilitado;
                            usuarioAnterior.Actualizacion = DateTime.Now;

                            context.SaveChanges();
                            trans.Commit();
                        }

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        blResultado = false;
                        throw new Exception(ex.Message);

                    }
                }
            }

            return blResultado;
        }
        public bool Delete(EUsuario usuario)
        {
            bool blResultaodo = false;

            using (var  context = new DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        var datoObtenido = context.Usuarios.Where(x => x.UsuarioId == usuario.Id).FirstOrDefault();

                        if (datoObtenido == null)
                            throw new Exception("Dato seleccionado no existe!");

                        if (ValidateElimination(usuario.Id))
                        {
                            context.Usuarios.Remove(datoObtenido);
                            context.SaveChanges();
                            trans.Commit();
                            blResultaodo = true;
                            

                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        blResultaodo = false;
                        throw new Exception(ex.Message);
                    }
                }
            }

            return blResultaodo;
        }
        public EUsuario GetbyId(Guid Id)
        {
            
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {

                    var obtenerDato = context.Usuarios.Where(x => x.UsuarioId == Id).FirstOrDefault();
                    EUsuario entidad = new EUsuario();

                    entidad.Id = obtenerDato.UsuarioId;
                    entidad.PersonaId = obtenerDato.PersonaId;
                    entidad.Codigo = obtenerDato.Codigo;
                    entidad.Clave = obtenerDato.Clave;
                    entidad.CambiaContraseña = obtenerDato.CambiaContraseña;
                    entidad.UltimaOperacion = obtenerDato.UltimaOperacion;
                    entidad.EnLinea = obtenerDato.EnLinea;
                    entidad.Administrador = obtenerDato.Administracion;
                    entidad.Habilitado = obtenerDato.Habilitado;
                    entidad.Actualizacion = obtenerDato.Actualizacion;

                    return entidad;
                }
                 
            }
            catch (Exception ex)
            {
               
                throw new Exception(ex.Message);
            }

        }
        public List<EUsuario> ToLis()
        {
          
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var Lista = (from n in context.Usuarios
                                 select new EUsuario
                                 {
                                     Id = n.PersonaId,
                                     PersonaId = n.PersonaId,
                                     Codigo = n.Codigo,
                                     Clave = n.Clave,
                                     CambiaContraseña = n.CambiaContraseña,
                                     UltimaOperacion = n.UltimaOperacion,
                                     EnLinea = n.EnLinea,
                                     Administrador = n.Administracion,
                                     Habilitado = n.Habilitado,
                                     Actualizacion = n.Actualizacion
                                 }
                                 ).ToList();

                    return Lista;
                                
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool ValidateFields(EUsuario usuario)
        {
            bool blResultado = false;
            try
            {
                if (usuario.Codigo.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un còdigo vàlido!");

                ValidateModification(usuario);

                blResultado = true;
            }
            catch (Exception ex)
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;
        }
        public bool ValidateModification(EUsuario usuario)
        {
            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var obtenerDato = context.Usuarios.Where(x => x.UsuarioId == usuario.Id).FirstOrDefault();
                    if (obtenerDato != null)
                        throw new Exception("Còdigo ingresado ya se encuentra registrado!");

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
        public bool ValidateElimination(Guid Id)
        {
            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var verificarRolUsuario = context.RolUsuarios.Where(x => x.UsuarioId == Id).ToList();

                    if (verificarRolUsuario.Count <= 0)
                        throw new Exception("No se puede eliminar el usuario seleccionado , se encuentra relacionado a una entidad");


                    var verificarUsuarioEquipo = context.UsuarioEquipo.Where(x => x.UsuarioId == Id).ToList();
                    if (verificarUsuarioEquipo.Count <= 0)
                        throw new Exception("No se puede eliminar el usuario seleccionado , se encuentra relacionado a una entidad");

                    var verificarUsuarioModulo = context.UsuarioModulos.Where(x => x.UsuarioId == Id).ToList();

                    if (verificarUsuarioModulo.Count <= 0)
                        throw new Exception("No se puede eliminar el usuario seleccionado , se encuentra relacionado a una entidad");

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
