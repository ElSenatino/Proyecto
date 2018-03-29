
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LRol
    {

        //public LRol() { }

        //public bool Add(ERol rol)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                rol.Id = Guid.NewGuid();
        //                rol.Nombre = rol.Nombre.Trim().ToUpper();
        //                rol.Descripcion = rol.Descripcion.Trim().ToUpper();
        //                rol.Actualizacion = DateTime.Now;
        //                if (ValidateFields(rol))
        //                {
        //                    blResultado = this.Crear(rol);
        //                    trans.Commit();
        //                }


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
        //public bool Edit(ERol rol)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var rolAnterior = Obtener(x => x.Id == rol.Id);
        //                if (rolAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                rolAnterior.Nombre = rol.Nombre.Trim().ToUpper();
        //                rolAnterior.Descripcion = rol.Descripcion.Trim().ToUpper();
        //                rolAnterior.Habilitado = rol.Habilitado;
        //                rolAnterior.Actualizacion = DateTime.Now;

        //                if (ValidateFields(rol))
        //                {
        //                    blResultado = this.Modificar(rolAnterior);
        //                    trans.Commit();
        //                }

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
        //public bool Delete(ERol rol)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == rol.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateElimination(rol.Id))
        //                {
        //                    this.Eliminar(rol);
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
        //public ERol GetbyId(Guid Id)
        //{
        //    ERol entidad = new ERol();
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
        //public List<ERol> ToLis()
        //{
        //    List<ERol> Lista = new List<ERol>();

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


        //public bool ValidateFields(ERol rol)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (rol.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");


               

        //        ValidateModification(rol);

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(ERol rol)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brRol = new BaseRepositorio<ERol>();
           
        //        var verificarNombre = brRol.Obtener(x => x.Nombre == rol.Nombre && x.Id != rol.Id);
        //        if (verificarNombre != null)
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
        //public bool ValidateElimination(Guid Id)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        var brRol = new BaseRepositorio<ERolUsuario>();
        //        var verificarRol = brRol.Filtrar(x => x.RolId == Id);

        //        if (verificarRol.Count <= 0)
        //            throw new Exception("No se puede eliminar el rol seleccionado , se encuentra relacionado a una entidad");

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
