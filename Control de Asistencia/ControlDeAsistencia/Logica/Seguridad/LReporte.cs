
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LReporte
    {
        //public LReporte() { }
        //public bool Add(EReporte reporte)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                reporte.Id = Guid.NewGuid();

        //                reporte.Codigo = reporte.Codigo.Trim().ToUpper();
        //                reporte.Nombre = reporte.Nombre.Trim().ToUpper();
        //                reporte.Descripcion = reporte.Descripcion.Trim().ToUpper();
        //                reporte.ReportServer = reporte.ReportServer.Trim().ToUpper();
        //                reporte.Ruta = reporte.Ruta.Trim().ToUpper();

        //                reporte.Actualizacion = DateTime.Now;
        //                if (ValidateFields(reporte))
        //                {
        //                    blResultado = this.Crear(reporte);
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
        //public bool Edit(EReporte reporte)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var  reporteAnterior = Obtener(x => x.Id == reporte.Id);
        //                if (reporteAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                reporteAnterior.Codigo = reporte.Codigo.Trim().ToUpper();
        //                reporteAnterior.Nombre = reporte.Nombre.Trim().ToUpper();
        //                reporteAnterior.Descripcion = reporte.Descripcion.Trim().ToUpper();
        //                reporteAnterior.ReportServer = reporte.ReportServer.Trim().ToUpper();
        //                reporteAnterior.Ruta = reporte.Ruta.Trim().ToUpper();
        //                reporteAnterior.Habilitado = reporte.Habilitado;
        //                reporteAnterior.Actualizacion = DateTime.Now;

        //                if (ValidateFields(reporte))
        //                {
        //                    blResultado = this.Modificar(reporteAnterior);
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
        //public bool Delete(EReporte reporte)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == reporte.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                if (ValidateElimination(reporte.Id))
        //                {
        //                    this.Eliminar(reporte);
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
        //public EReporte GetbyId(Guid Id)
        //{
        //    EReporte entidad = new EReporte();
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
        //public List<EReporte> ToLis()
        //{
        //    List<EReporte> Lista = new List<EReporte>();

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


        //public bool ValidateFields(EReporte reporte)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (reporte.Codigo.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un còdigo vàlido!");


        //        if (reporte.Nombre.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un nombre vàlido!");


        //        if (reporte.ReportServer.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un servidor  vàlido!");


        //        if (reporte.Ruta.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un ruta vàlido!");

                

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
        //        var brReporteModulo = new BaseRepositorio<EReporteModulo>();
        //        var verificarModulo = brReporteModulo.Filtrar(x => x.ModuloId == Id);

        //        if (verificarModulo.Count <= 0)
        //            throw new Exception("No se puede eliminar el módulo seleccionado , se encuentra relacionado a una entidad");

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
