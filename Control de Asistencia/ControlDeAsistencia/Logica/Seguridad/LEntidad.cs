using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LEntidad
    {
        //public LEntidad() { }
        //public bool Add(EEntidad eEntidad)
        //{
        //    bool blResultado = false;
        //    using (var context = new  DataModel.ControlDeAsistenciaEntities())
        //    {
        //        try
        //        {
        //            DataModel.Entidades entidad = new DataModel.Entidades();

        //            entidad.EntidadId = Guid.NewGuid();
        //            entidad.Nombre = entidad.Nombre.Trim().ToUpper();
        //            entidad.NombreMostrado = entidad.NombreMostrado.Trim().ToUpper();
        //            entidad.NombreMostradoPlural = entidad.NombreMostradoPlural.Trim().ToUpper();
        //            entidad.Actualizacion = DateTime.Now; 


        //            if (ValidateFields(eEntidad))
        //            {
        //                context.Entidades.Add(entidad);
        //                blResultado = true;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            blResultado = false;
        //            throw new Exception(ex.Message);
        //        }
                
        //    }
        //    return blResultado;
        //}
        //public bool Edit(EEntidad eEntidad)
        //{
        //    bool blResultado = false;
        //    using (var context = new  DataModel.ControlDeAsistenciaEntities())
        //    {
                
        //        try
        //        {
        //            var entidadAnterior = context.Entidades.Where(x => x.EntidadId == entidad.Id).FirstOrDefault();
        //            if (entidadAnterior == null)
        //                throw new Exception("Dato seleccionado no existe!");

        //            entidadAnterior.Nombre = eEntidad.Nombre.Trim().ToUpper();
        //            entidadAnterior.NombreMostrado = eEntidad.NombreMostrado.Trim().ToUpper();
        //            entidadAnterior.NombreMostradoPlural= eEntidad.NombreMostradoPlural.Trim().ToUpper();
        //            entidadAnterior.ModuloId = eEntidad.ModuloId;
        //            entidadAnterior.Habilitado = eEntidad.Habilitado;
        //            entidadAnterior.Actualizacion = DateTime.Now;

        //            if (ValidateFields(entidadAnterior))
        //            {
        //                context.Entidades.Add(entidadAnterior);
        //                blResultado = true;
        //            }

        //        }
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

        //    using (var  context = new DataModel.ControlDeAsistenciaEntities())
        //    {
                
        //        try
        //        {
        //            var datoObtenido = context.Entidades.Where(x => x.EntidadId == Id).FirstOrDefault();

        //            if (datoObtenido == null)
        //                throw new Exception("Dato seleccionado no existe!");

        //            context.Entidades.Remove(datoObtenido);
        //            context.SaveChanges();

        //        }
        //        catch (Exception ex)
        //        {
        //            blResultaodo = false;
        //            throw new Exception(ex.Message);
        //        }
        //    }
            

        //    return blResultaodo;
        //}
        //public EEntidad GetbyId(Guid Id)
        //{
        //    EEntidad entidad = new EEntidad();
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
        //public List<EEntidad> ToLis()
        //{
        //    List<EEntidad> Lista = new List<EEntidad>();

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


        //public bool ValidateFields(EEntidad entidad)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (entidad.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");


        //        if (entidad.NombreMostrado.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");

        //        if (entidad.NombreMostradoPlural.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");

        //        ValidateModification(entidad);

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(EEntidad entidad)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brEntidad = new BaseRepositorio<EEntidad>();

        //        var verificarNombre = brEntidad.Obtener(x => x.Nombre == entidad.Nombre && x.Id != entidad.Id);
        //        if (verificarNombre == null)
        //            throw new Exception("Còdigo ingresado ya se encuentra registrado!");

        //        var verificarNombreMostrado = brEntidad.Obtener(x => x.Nombre == entidad.Nombre && x.Id != entidad.Id);
        //        if (verificarNombreMostrado == null)
        //            throw new Exception("Nombre ingresado ya se encuentra registrado!");


        //        var verificarNombreMostradoPlural = brEntidad.Obtener(x => x.Nombre == entidad.Nombre && x.Id != entidad.Id);
        //        if (verificarNombreMostradoPlural == null)
        //            throw new Exception("Nombre ingresado ya se encuentra registrado!");


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
