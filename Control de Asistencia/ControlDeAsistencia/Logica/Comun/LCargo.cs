
using DataModel;
using Entidad.Comun;
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LCargo 
    {
        //private ESesion _sesion;
        //public LCargo() { }
        //public LCargo(ESesion eSesion)
        //{
        //    this._sesion = eSesion;
        //}

        //public bool Add(ECargo eCargo)
        //{
        //    bool blResultado = false;
        //    using (var context = new DataModel.ControlDeAsistenciaEntities())
        //    {

        //        try
        //        {

        //            DataModel.Cargos cargo = new Cargos();
        //            cargo.CargoId = Guid.NewGuid();
        //            cargo.Codigo = eCargo.Codigo.Trim().ToUpper();
        //            cargo.Nombre = eCargo.Nombre.Trim().ToUpper();
        //            cargo.Actualizacion = DateTime.Now;
        //            if (ValidateFields(eCargo))
        //            {
        //                context.Cargos.Add(cargo);
        //                blResultado = true;
        //            }

        //        } catch (Exception ex)
        //        {
        //            blResultado = true;
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //    return blResultado;
        //}
        //public bool Edit(ECargo eCargo)
        //{
        //    bool blResultado =false;
           
        //        using (var context = new DataModel.ControlDeAsistenciaEntities())
        //        {
        //            try
        //            {
        //                var cargoAnterior = context.Cargos.Where(x => x.CargoId == eCargo.Id).FirstOrDefault();
        //                if (cargoAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateFields(eCargo))
        //                {
        //                    cargoAnterior.Codigo = eCargo.Codigo.Trim().ToUpper();
        //                    cargoAnterior.Nombre = eCargo.Nombre.Trim().ToUpper();
        //                    cargoAnterior.Habilitado = eCargo.Habilitado;
        //                    cargoAnterior.Actualizacion = DateTime.Now;

        //                    context.SaveChanges();
        //                    blResultado = true;
        //                }
        //            }   

        //        catch (Exception ex)
        //        {
        //            blResultado = false;
        //            throw new Exception(ex.Message);
        //        }
                
        //    }

        //    return blResultado;
        //}
        //public bool Delete(Guid Id)
        //{
        //    bool blResultaodo = false;

        //        using (var context = new DataModel.ControlDeAsistenciaEntities())
        //        {
        //            try
        //            {

        //                var datoObtenido = context.Cargos.Where(x => x.CargoId == Id).FirstOrDefault();
        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateElimination(Id))
        //                {
        //                    context.Cargos.Remove(datoObtenido);
        //                    blResultaodo = true;
                        
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                blResultaodo = false;
        //                throw new Exception(ex.Message);
        //            }
        //        }

        //    return blResultaodo;
        //}
        //public ECargo GetbyId(Guid Id)
        //{
        //    ECargo entidad = new ECargo();
          
        //        using (var context = new DataModel.ControlDeAsistenciaEntities())
        //        {
        //            try
        //            {
        //                var cargoObtenido = context.Cargos.Where(x => x.CargoId == Id).FirstOrDefault();
        //                if (cargoObtenido == null)
        //                throw new Exception("Dato seleccionado no existe!");

        //                entidad.Id = cargoObtenido.CargoId;
        //                entidad.Nombre = cargoObtenido.Nombre;
        //                entidad.Codigo = cargoObtenido.Codigo;
        //                entidad.Actualizacion = cargoObtenido.Actualizacion;
        //                entidad.Habilitado = cargoObtenido.Habilitado;

        //            }
        //            catch (Exception ex)
        //            {
        //                entidad = null;
        //                throw new Exception(ex.Message);
        //            }
        //        }
        //    return entidad;
        //}
        //public List<ECargo> ToLis()
        //{
        //    using (var context = new DataModel.ControlDeAsistenciaEntities())
        //    {
        //        try
        //        {
        //            var Lista = (from n in context.Cargos
        //                         select new ECargo
        //                         {
        //                             Id = n.CargoId,
        //                             Codigo = n.Codigo,
        //                             Nombre = n.Nombre,
        //                             Habilitado = n.Habilitado,
        //                             Actualizacion = n.Actualizacion

        //                         }
        //                         ).ToList();


        //            return Lista;

        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //}
        

        //public bool ValidateFields(ECargo cargo)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (cargo.Codigo.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un còdigo vàlido!");


        //       if (cargo.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");

        //        ValidateModification(cargo);

        //         blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(ECargo cargo)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        using (var context = new DataModel.ControlDeAsistenciaEntities())
        //        {
        //            var verificarCodigo = context.Cargos.Where(x => x.Codigo == cargo.Codigo && x.CargoId != cargo.Id);
        //            if (verificarCodigo != null)
        //                throw new Exception("Còdigo ingresado ya se encuentra registrado!");

        //            var verificarNombre = context.Cargos.Where(x => x.Nombre == cargo.Nombre && x.CargoId != cargo.Id);
        //            if (verificarNombre != null)
        //                throw new Exception("Nombre ingresado ya se encuentra registrado!");


        //            blResultado = true;
        //        }
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

        //        using (var context = new DataModel.ControlDeAsistenciaEntities())
        //        {
        //            var verificarPersona = context.Cargos.Where(x => x.CargoId == Id).ToList();

        //            if (verificarPersona.Count <= 0)
        //                throw new Exception("No se puede eliminar el cargo seleccionado , se encuentra relacionado a una persona");

        //            blResultado = true;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message) ;
        //    }

        //    return blResultado;
        //}
        
    }

}
