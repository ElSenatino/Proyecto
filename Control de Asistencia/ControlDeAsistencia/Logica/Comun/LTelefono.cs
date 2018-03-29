using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LTelefono
    {

        //public LTelefono() { }
        //public bool Add(ETelefono telefono)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                telefono.Id = Guid.NewGuid();
        //                telefono.Observacion = telefono.Observacion.Trim().ToUpper();
        //                telefono.Actualizacion = DateTime.Now;

                       
        //                    blResultado = this.Crear(telefono);
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
        //public bool Edit(ETelefono telefono)
        //{
        //    bool blResultado = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var telefonoAnterior = Obtener(x => x.Id == telefono.Id);
        //                if (telefonoAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                telefonoAnterior.TipoTelefono = telefono.TipoTelefono;
        //                telefonoAnterior.NroTelefono = telefono.NroTelefono;
        //                telefonoAnterior.Observacion = telefono.Observacion;
        //                telefonoAnterior.Habilitado = telefono.Habilitado;
        //                telefonoAnterior.Actualizacion = DateTime.Now;
                       

        //                if (ValidateModification(telefonoAnterior))
        //                {
        //                    blResultado = this.Modificar(telefonoAnterior);
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
        //public bool Delete(ETelefono telefono)
        //{
        //    bool blResultaodo = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == telefono.Id);
        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

                        
        //                    this.Eliminar(telefono);
        //                    trans.Commit();
        //                    blResultaodo = true;

                        

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
        //public ETelefono GetbyId(Guid Id)
        //{
        //    ETelefono entidad = new ETelefono();
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
        //public List<ETelefono> ToLis()
        //{
        //    List<ETelefono> Lista = new List<ETelefono>();

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


      
        //public bool ValidateModification(ETelefono telefono)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brTelefono = new BaseRepositorio<ETelefono>();

        //        var verificarCodigo = brTelefono.Obtener(x => x.NroTelefono == telefono.NroTelefono && x.Id != telefono.Id);
        //        if (verificarCodigo == null)
        //            throw new Exception("Nùmero ingresado ya se encuentra registrado!");

                

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
