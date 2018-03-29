
using Entidad.Comun;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LUsuarioEquipo
    {

        //public LUsuarioEquipo() { }

        //public bool Add(EUsuarioEquipo usuarioEquipo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                usuarioEquipo.Id = Guid.NewGuid();
        //                usuarioEquipo.Nombre = usuarioEquipo.Nombre.Trim().ToUpper();
                        
                     
        //                    blResultado = this.Crear(usuarioEquipo);
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
        //public bool Delete(EUsuarioEquipo usuarioEquipo)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == usuarioEquipo.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateElimination(usuarioEquipo.Id))
        //                {
        //                    this.Eliminar(usuarioEquipo);
        //                    blResultaodo = true;
        //                    trans.Commit();

        //                }
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
        //public EUsuarioEquipo GetbyId(Guid Id)
        //{
        //    EUsuarioEquipo entidad = new EUsuarioEquipo();
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
        //public List<EUsuarioEquipo> ToLis()
        //{
        //    List<EUsuarioEquipo> Lista = new List<EUsuarioEquipo>();

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


      
        //public bool ValidateModification(EUsuarioEquipo usuarioEquipo)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brCargo = new BaseRepositorio<EUsuarioEquipo>();

        //        var verificarUsuarioEquipo = brCargo.Obtener(x => x.UsuarioId == usuarioEquipo.UsuarioId && x.EquipoId == usuarioEquipo.EquipoId  &&   x.Id != usuarioEquipo.Id);
        //        if (verificarUsuarioEquipo != null)
        //            throw new Exception("Còdigo ingresado ya se encuentra registrado!");
        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateElimination(Guid Id)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        var brCargoPersona = new BaseRepositorio<ECargoPersona>();
        //        var verificarPersona = brCargoPersona.Filtrar(x => x.CargoId == Id);

        //        if (verificarPersona.Count <= 0)
        //            throw new Exception("No se puede eliminar el cargo seleccionado , se encuentra relacionado a una persona");

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }

        //    return blResultado;
        //}
    }
}
