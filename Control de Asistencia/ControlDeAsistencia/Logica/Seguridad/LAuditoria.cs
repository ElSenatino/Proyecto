using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Seguridad
{
    public class LAuditoria 
    {
        public LAuditoria() { }
        public bool Add(EAuditoria Eauditoria)
        {
            bool blResultado = false;
            using (var  context = new DataModel.ControlDeAsistenciaEntities())
            {
                try
                {
                    DataModel.Auditorias auditoria = new DataModel.Auditorias();

                    auditoria.AuditoriaId = Guid.NewGuid();
                    auditoria.Registro = DateTime.Now;
                    auditoria.Metodo = Eauditoria.Metodo;
                    auditoria.Actualizacion = DateTime.Now;

                    context.Auditorias.Add(auditoria);
                    blResultado = true;
                }
                catch (Exception ex)
                {
                       
                    blResultado = false;
                    throw new Exception(ex.Message);
                }
                
            }
            return blResultado;
        }
        public EAuditoria GetbyId(Guid Id)
        {
            EAuditoria entidad = new EAuditoria();
            try
            {

                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {

                    var obtenerAuditoria = context.Auditorias.Where(x => x.AuditoriaId == Id).FirstOrDefault();

                    entidad.Id = obtenerAuditoria.AuditoriaId;
                    entidad.Metodo = obtenerAuditoria.Metodo;
                    entidad.Registro = obtenerAuditoria.Registro;
                    entidad.SesionId = obtenerAuditoria.SesionId;
                    entidad.CodigoRegistro = obtenerAuditoria.CodigoRegistro;
                    entidad.Actualizacion = obtenerAuditoria.Actualizacion;

                    return entidad;
                }


            }
            catch (Exception ex)
            {
                entidad = null;
                throw new Exception(ex.Message);
            }

        }
        public List<EAuditoria> ToLis()
        {
            

            try
            {
                using (var context = new DataModel.ControlDeAsistenciaEntities())
                {

                    var Lista = (from n in context.Auditorias
                                 select new EAuditoria
                                 {
                                     Id = n.AuditoriaId,
                                      Actualizacion = n.Actualizacion,
                                      CodigoRegistro = n.CodigoRegistro,
                                      Metodo = n.Metodo,
                                      Registro = n.Registro,
                                      SesionId = n.SesionId 
                                 }
                                  ).ToList();

                    return Lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
 
        }

    }
}
