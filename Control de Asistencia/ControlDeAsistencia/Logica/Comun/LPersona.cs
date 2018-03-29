using Entidad.Comun;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LPersona
    {

        private ESesion sesionIniciada { get; set; }

        public LPersona() { }
        public LPersona(ESesion _sesion) { this.sesionIniciada = _sesion; }

        public bool Add(EPersona _persona)
        {
            bool blResultado = false;
            using (var context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        DataModel.Personas persona = new DataModel.Personas();

                        persona.PersonaId = Guid.NewGuid();
                        persona.NombreGenerado = _persona.Nombre.Trim().ToUpper() + " " + _persona.Apellidos.Trim().ToUpper();
                        persona.Nombre = _persona.Nombre.Trim().ToUpper();
                        persona.Apellidos = _persona.Apellidos.Trim().ToUpper();
                        persona.TipoDocumento = _persona.TipoDocumento;
                        persona.NroDocumento = _persona.NroDocumento;
                        persona.TipoSexo = _persona.TipoSexo;
                        persona.Nacimiento = _persona.Nacimiento;
                        persona.Imagen = _persona.Imagen;
                        persona.Habilitado = _persona.Habilitado;
                        persona.Actualizacion = DateTime.Now;

                        if (ValidateFields(_persona))
                        {
                            context.Personas.Add(persona);
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
        public bool Edit(EPersona _persona)
        {
            bool blResultado = false;

            using (var context = new DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (ValidateFields(_persona))
                        {
                            var personaAnterior = context.Personas.Where(x => x.PersonaId == _persona.Id).FirstOrDefault();
                            if (personaAnterior == null)
                                throw new Exception("Dato seleccionado no existe!");

                            personaAnterior.NombreGenerado = _persona.Nombre.Trim().ToUpper() + " " + _persona.Apellidos.Trim().ToUpper();
                            personaAnterior.Nombre = _persona.Nombre.Trim().ToUpper();
                            personaAnterior.Apellidos = _persona.Apellidos.Trim().ToUpper();
                            personaAnterior.TipoDocumento = _persona.TipoDocumento;
                            personaAnterior.NroDocumento = _persona.NroDocumento;
                            personaAnterior.TipoSexo = _persona.TipoSexo;
                            personaAnterior.Nacimiento = _persona.Nacimiento;
                            personaAnterior.Imagen = _persona.Imagen;
                            personaAnterior.Habilitado = _persona.Habilitado;
                            personaAnterior.Actualizacion = DateTime.Now;

                            context.SaveChanges();
                            trans.Commit();
                            blResultado = true;
                        
                        }       

                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        blResultado = false;
                        throw new Exception(ex.Message);
                        throw;
                    }
                }
            }
           
            return blResultado;
        }
        public bool Delete(Guid Id)
        {
            bool blResultaodo = false;

            using (var context = new DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        var personaObtenido = context.Personas.Where(x => x.PersonaId == Id).FirstOrDefault();

                        if (personaObtenido == null)
                            throw new Exception("Dato seleccionado no existe!");

                        if (ValidateElimination(Id))
                        {
                            context.Personas.Add(personaObtenido);
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
        public EPersona GetbyId(Guid Id)
        {
            EPersona entidad = new EPersona();
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var obtenerPersona = context.Personas.Where(x => x.PersonaId == Id).FirstOrDefault();

                    if (obtenerPersona == null)
                        throw new Exception("Dato seleccionado no existe!");

                    entidad.Id = obtenerPersona.PersonaId;
                    entidad.NombreGenerado = obtenerPersona.NombreGenerado;
                    entidad.Nombre = obtenerPersona.Nombre;
                    entidad.Apellidos = obtenerPersona.Apellidos;
                    entidad.TipoDocumento = obtenerPersona.TipoDocumento;
                    entidad.NroDocumento = obtenerPersona.NroDocumento;
                    entidad.TipoSexo = obtenerPersona.TipoSexo;
                    entidad.Nacimiento = obtenerPersona.Nacimiento;
                    entidad.Imagen = obtenerPersona.Imagen;
                    entidad.Habilitado = obtenerPersona.Habilitado;
                    entidad.Acutalizacion = obtenerPersona.Actualizacion;

                    return entidad;
                }
                
            }
            catch (Exception ex)
            {
                entidad = null;
                throw new Exception(ex.Message);
            }

        }
        public List<EPersona> ToLis()
        {  
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var Lista = (from n in context.Personas
                                 select new EPersona
                                 {
                                     Id = n.PersonaId ,
                                     NombreGenerado = n.NombreGenerado,
                                     Nombre = n.Nombre ,
                                     Apellidos = n.Apellidos ,
                                     TipoDocumento = n.TipoDocumento ,
                                     NroDocumento = n.NroDocumento,
                                     TipoSexo =n.TipoSexo ,
                                     Nacimiento = n.Nacimiento ,
                                     Imagen = n.Imagen , 
                                     Habilitado  = n.Habilitado,
                                     Acutalizacion = n.Actualizacion
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

        public bool ValidateFields(EPersona persona)
        {
            bool blResultado = false;
            try
            {
              
                if (persona.Nombre.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un nombre vàlido!");

                if (persona.Apellidos.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un apellido vàlido! ");

                if (persona.NroDocumento.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un Nro documento  vàlido! ");

                ValidateModification(persona);

                 blResultado = true;
            }
            catch (Exception ex)
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;
        }
        public bool ValidateModification(EPersona persona)
        {
            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    
                    
                    var verificarNombre = context.Personas.Where(x => x.NombreGenerado == persona.NombreGenerado && x.PersonaId != persona.Id);
                    if (verificarNombre != null)
                        throw new Exception("Nombre ingresado ya se encuentra registrado!");

                    var verificarNroDoc =context.Personas.Where(x => x.NroDocumento == persona.NroDocumento && x.PersonaId != persona.Id);
                    if (verificarNroDoc != null)
                        throw new Exception("Nro de documento ingresado ya se encuentra registrado!");

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
                    var verificarPersona = context.Personas.Where(x => x.PersonaId == Id).FirstOrDefault();

                    if (verificarPersona == null)
                        throw new Exception("No se puede eliminar la persona seleccionado , se encuentra relacionado;");

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
