
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LModulo
    {
        //public LModulo() { }
        //public bool Add(EModulo modulo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                modulo.Id = Guid.NewGuid();
        //                modulo.Codigo = modulo.Codigo.Trim().ToUpper();
        //                modulo.Nombre = modulo.Nombre.Trim().ToUpper();
        //                modulo.Descripcion = modulo.Descripcion.Trim().ToUpper();
        //                modulo.Actualizacion = DateTime.Now;

        //                if (ValidateFields(modulo))
        //                {
        //                    blResultado = this.Crear(modulo);
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
        //public bool Edit(EModulo modulo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var moduloAnterior = Obtener(x => x.Id == modulo.Id);
        //                if (moduloAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                moduloAnterior.Codigo = modulo.Codigo.Trim().ToUpper();
        //                moduloAnterior.Nombre = modulo.Nombre.Trim().ToUpper();
        //                moduloAnterior.Descripcion = modulo.Descripcion.Trim().ToUpper();
        //                moduloAnterior.Habilitado = modulo.Habilitado;
        //                moduloAnterior.Actualizacion = DateTime.Now;

        //                if (ValidateFields(moduloAnterior))
        //                {
        //                    blResultado = this.Modificar(moduloAnterior);
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
        //public bool Delete(EModulo modulo)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == modulo.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

                        
        //                    this.Eliminar(modulo);
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
        //public EModulo GetbyId(Guid Id)
        //{
        //    EModulo entidad = new EModulo();
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
        //public List<EModulo> ToLis()
        //{
        //    List<EModulo> Lista = new List<EModulo>();

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


        //public bool ValidateFields(EModulo modulo)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (modulo.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");


        //        if (modulo.Codigo.Length <= 0)
        //            throw new Exception("Debe ingresar un còdigo vàlida vàlido!");

        //        ValidateModification(modulo);

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(EModulo modulo)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brModulo = new BaseRepositorio<EModulo>();

        //        var verificarCodigo = brModulo.Obtener(x => x.Codigo == modulo.Codigo && x.Id != modulo.Id);
        //        if (verificarCodigo == null)
        //            throw new Exception("Còdigo ingresado ya se encuentra registrado!");

        //        var verificarNombre = brModulo.Obtener(x => x.Nombre== modulo.Nombre && x.Id != modulo.Id);
        //        if (verificarNombre == null)
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
