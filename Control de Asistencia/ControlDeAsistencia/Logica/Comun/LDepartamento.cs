
using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LDepartamento
    {

        //public LDepartamento() { }

        //public bool Add(EDepartamento departamento)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                departamento.Id = Guid.NewGuid();
        //                departamento.Codigo = departamento.Codigo.Trim().ToUpper();
        //                departamento.Nombre = departamento.Nombre.Trim().ToUpper();
        //                departamento.Actualizacion = DateTime.Now;

        //                if (ValidateFields(departamento))
        //                {
        //                    blResultado = this.Crear(departamento);
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
        //public bool Edit(EDepartamento departamento)
        //{
        //    bool blResultado = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var departamentoAnterior = Obtener(x => x.Id == departamento.Id);
        //                if (departamentoAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                departamentoAnterior.Codigo = departamento.Codigo.Trim().ToUpper();
        //                departamentoAnterior.Nombre = departamento.Nombre.Trim().ToUpper();
        //                departamentoAnterior.Actualizacion = DateTime.Now;

        //                if (ValidateFields(departamentoAnterior))
        //                {
        //                    blResultado = this.Modificar(departamentoAnterior);
        //                    trans.Commit();
        //                }
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
        //public bool Delete(EDepartamento departamento)
        //{
        //    bool blResultaodo = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == departamento.Id);
        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateElimination(departamento.Id))
        //                {
        //                    this.Eliminar(departamento);
        //                    trans.Commit();
        //                    blResultaodo = true;

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
        //public EDepartamento GetbyId(Guid Id)
        //{
        //    EDepartamento entidad = new EDepartamento();
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
        //public List<EDepartamento> ToLis()
        //{
        //    List<EDepartamento> Lista = new List<EDepartamento>();

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


        //public bool ValidateFields(EDepartamento departamento)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (departamento.Codigo.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un còdigo vàlido!");

        //        if (departamento.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");

        //        ValidateModification(departamento);

               

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(EDepartamento departamento)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brDepartamento = new BaseRepositorio<EDepartamento>();

        //        var verificarCodigo = brDepartamento.Obtener(x => x.Codigo == departamento.Codigo && x.Id != departamento.Id);
        //        if (verificarCodigo != null)
        //            throw new Exception("Còdigo ingresado ya se encuentra registrado!");

        //        var verificarNombre = brDepartamento.Obtener(x => x.Nombre == departamento.Nombre && x.Id != departamento.Id);
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
        //        var brPersona = new BaseRepositorio<ECargoPersona>();
        //        var verificarCargoPersona = brPersona.Filtrar(x => x.DepartamentoId == Id);

        //        if (verificarCargoPersona.Count <= 0)
        //            throw new Exception("No se puede eliminar el departamento seleccionado , se encuentra relacionad;");

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
