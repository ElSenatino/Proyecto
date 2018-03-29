
using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{ 
    public class LReporteModulo 
    {

        //public LReporteModulo() { }
        //public bool Add(EReporteModulo reporteModulo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                reporteModulo.Id = Guid.NewGuid();
        //                reporteModulo.Nombre = reporteModulo.Nombre.Trim().ToUpper();
        //                reporteModulo.Actualizacion = DateTime.Now;

                      
        //                    blResultado = this.Crear(reporteModulo);
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
        //public bool Edit(EReporteModulo reporteModulo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var reporteModuloAnterior = Obtener(x => x.Id == reporteModulo.Id);
        //                if (reporteModuloAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                reporteModuloAnterior.Nombre = reporteModulo.Nombre.Trim().ToUpper();
        //                reporteModuloAnterior.ReporteId = reporteModulo.ReporteId;
        //                reporteModuloAnterior.ModuloId = reporteModulo.ModuloId;
        //                reporteModuloAnterior.Actualizacion = DateTime.Now;

                      
        //                    blResultado = this.Modificar(reporteModuloAnterior);
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
        //public bool Delete(EReporteModulo reporteModulo)
        //{
        //    bool blResultaodo = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == reporteModulo.Id);

        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

                        
        //                    this.Eliminar(reporteModulo);
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
        //public EReporteModulo GetbyId(Guid Id)
        //{
        //    EReporteModulo entidad = new EReporteModulo();
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
        //public List<EReporteModulo> ToLis()
        //{
        //    List<EReporteModulo> Lista = new List<EReporteModulo>();

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
