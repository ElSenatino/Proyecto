
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LEquipo 
    {

        public LEquipo() { }
        public bool Add(EEquipo eEquipo)
        {
            bool blResultado = false;
            using (var context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        DataModel.Equipos equipo = new DataModel.Equipos();

                        equipo.EquipoId = Guid.NewGuid();
                        equipo.Nombre = eEquipo.Nombre.Trim().ToUpper();
                        equipo.NumeroIP = eEquipo.NumeroIp.Trim().ToUpper();
                        equipo.Habilitado = eEquipo.Habilitado;
                        equipo.Actualizacion = DateTime.Now;

                        if (ValidateFields(eEquipo))
                        {
                            context.Equipos.Add(equipo);
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
        public bool Edit(EEquipo eEquipo)
        {
            bool blResultado = false;
            using (var context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        var equipoAnterior = context.Equipos.Where(x => x.EquipoId == eEquipo.Id).FirstOrDefault();
                        if (equipoAnterior == null)
                            throw new Exception("Dato seleccionado no existe!");
                        if (ValidateFields(eEquipo))
                        {
                            equipoAnterior.Nombre = eEquipo.Nombre.Trim().ToUpper();
                            equipoAnterior.NumeroIP= eEquipo.NumeroIp.Trim().ToUpper();
                            equipoAnterior.Habilitado = eEquipo.Habilitado;
                            equipoAnterior.Actualizacion = DateTime.Now;

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

                    }
                }
            }

            return blResultado;
        }
        public bool Delete(EEquipo eEquipo)
        {
            bool blResultaodo = false;

            using (var  context = new  DataModel.ControlDeAsistenciaEntities())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        var datoObtenido = context.Equipos.Where(x => x.EquipoId== eEquipo.Id).FirstOrDefault();

                        if (datoObtenido == null)
                            throw new Exception("Dato seleccionado no existe!");

                        if (ValidateElimination(eEquipo.Id))
                        {
                            context.Equipos.Remove(datoObtenido);
                            trans.Commit();
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
        public EEquipo GetbyId(Guid Id)
        {
            EEquipo entidad = new EEquipo();
            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var datoObtenido = context.Equipos.Where(x => x.EquipoId == Id).FirstOrDefault();

                    entidad.Id = datoObtenido.EquipoId;
                    entidad.Nombre = datoObtenido.Nombre;
                    entidad.NumeroIp = datoObtenido.NumeroIP;
                    entidad.Habilitado = datoObtenido.Habilitado;
                    entidad.Actualizacion = datoObtenido.Actualizacion;

                    return entidad;
                }
            }
            catch (Exception ex)
            {
                entidad = null;
                throw new Exception(ex.Message);
            }
        }
        public List<EEquipo> ToLis()
        {
            

            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {

                    var Lista = (from n in context.Equipos
                                 select new EEquipo
                                 {
                                     Id = n.EquipoId,
                                     Nombre = n.Nombre,
                                     NumeroIp = n.NumeroIP ,
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


        public bool ValidateFields(EEquipo equipo)
        {
            bool blResultado = false;
            try
            {
                if (equipo.Nombre.Trim().Length <= 0)
                    throw new Exception("Debe ingresar un nombre vàlido!");

                ValidateModification(equipo);

                blResultado = true;
            }
            catch (Exception ex)
            {
                blResultado = false;
                throw new Exception(ex.Message);
            }
            return blResultado;
        }
        public bool ValidateModification(EEquipo equipo)
        {
            bool blResultado = false;
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {
                    var verificarNombre = context.Equipos.Where(x => x.Nombre == equipo.Nombre && x.EquipoId != equipo.Id).FirstOrDefault();
                    if (verificarNombre != null)
                        throw new Exception("Còdigo ingresado ya se encuentra registrado!");

                    var verificarIp = context.Equipos.Where(x => x.NumeroIP== equipo.NumeroIp && x.EquipoId!= equipo.Id);
                    if (verificarIp != null)
                        throw new Exception("Nombre ingresado ya se encuentra registrado!");

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
                    
                    var verificarEquipo = context.UsuarioEquipo.Where(x => x.EquipoId == Id).ToList();

                    if (verificarEquipo.Count <= 0)
                        throw new Exception("No se puede eliminar el equipo seleccionado , se encuentra relacionado a una entidad");

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
