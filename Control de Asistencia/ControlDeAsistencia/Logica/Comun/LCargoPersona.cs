
using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LCargoPersona
    {
        public LCargoPersona() { }
        //public bool Add(ECargoPersona cargoPersona)
        //{

        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                cargoPersona.Id = Guid.NewGuid();
        //                cargoPersona.Actualizacion = DateTime.Now;

        //                blResultado = this.Crear(cargoPersona);
        //                trans.Commit();
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
        //public bool Edit(ECargoPersona cargoPersona)
        //{
        //    bool blResultado = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var cargoPersonaAnterior = Obtener(x => x.Id == cargoPersona.Id);
        //                if (cargoPersonaAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");


        //                cargoPersonaAnterior.CargoId = cargoPersona.CargoId;
        //                cargoPersonaAnterior.PersonaId = cargoPersona.PersonaId;
        //                cargoPersonaAnterior.DepartamentoId = cargoPersona.DepartamentoId;
        //                cargoPersonaAnterior.Actualizacion = DateTime.Now;

        //                blResultado = this.Modificar(cargoPersonaAnterior);
        //                trans.Commit();

        //            }
        //            catch (Exception ex)
        //            {
        //                trans.Rollback();
        //                blResultado = false;
        //                throw new Exception(ex.Message);
        //                throw;
        //            }
        //        }
        //    }
        //    return blResultado;
        //}
        //public bool Delete(ECargoPersona cargo)
        //{
        //    bool blResultaodo = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == cargo.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                this.Eliminar(cargo);
        //                trans.Commit();
        //                blResultaodo = true;

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
        //public ECargoPersona GetbyId(Guid Id)
        //{
        //    ECargoPersona entidad = new ECargoPersona();
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
        //public List<ECargoPersona> ToLis()
        //{
        //    List<ECargoPersona> Lista = new List<ECargoPersona>();

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
