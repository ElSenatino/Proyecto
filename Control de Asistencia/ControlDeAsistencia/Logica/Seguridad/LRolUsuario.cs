
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LRolUsuario
    {

        //public LRolUsuario() { }

        //public bool Add(ERolUsuario rolUsuario)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                rolUsuario.Id = Guid.NewGuid();
        //                rolUsuario.Actualizacion = DateTime.Now;

        //                    blResultado = this.Crear(rolUsuario);
        //                    trans.Commit();
                        
        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                blResultado = false;
        //                throw new Exception(ex.Message);
        //            }
        //        }
        //    }
        //    return blResultado;
        //}
        //public bool Edit(ERolUsuario rol)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var rolUsusuarioAnterior = Obtener(x => x.Id == rol.Id);
        //                if (rolUsusuarioAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                rolUsusuarioAnterior.UsuarioId = rol.UsuarioId;
        //                rolUsusuarioAnterior.RolId = rol.RolId;
        //                rolUsusuarioAnterior.Actualizacion = DateTime.Now;

        //                 blResultado = this.Modificar(rolUsusuarioAnterior);
        //                 trans.Commit();
                        
        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                blResultado = false;
        //                throw new Exception(ex.Message);

        //            }
        //        }
        //    }

        //    return blResultado;
        //}
        //public bool Delete(ERolUsuario rolUsuario)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == rolUsuario.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

  
        //                    this.Eliminar(rolUsuario);
        //                    blResultaodo = true;
        //                    trans.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                blResultaodo = false;
        //                throw new Exception(ex.Message);
        //            }
        //        }
        //    }

        //    return blResultaodo;
        //}
        //public ERolUsuario GetbyId(Guid Id)
        //{
        //    ERolUsuario entidad = new ERolUsuario();
        //    try
        //    {
        //        entidad = this.Obtener(x => x.Id == Id);

        //        if (entidad == null)
        //            throw new Exception("Dato seleccionado no existe!");


        //        entidad = this.Obtener(x => x.Id == Id);
        //    }
        //    catch (Exception ex)
        //    {
        //        entidad = null;
        //        throw new Exception(ex.Message);
        //    }

        //    return entidad;
        //}
        //public List<ERolUsuario> ToLis()
        //{
        //    List<ERolUsuario> Lista = new List<ERolUsuario>();

        //    try
        //    {
        //        Lista = this.Listar();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return Lista;
        //}


    }
}
