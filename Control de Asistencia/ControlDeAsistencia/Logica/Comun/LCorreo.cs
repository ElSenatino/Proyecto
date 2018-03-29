
using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LCorreo
    {

        //public LCorreo() { }
        //public bool Add(ECorreo correo)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                correo.Id = Guid.NewGuid();
        //                correo.CorreoElectronico = correo.CorreoElectronico.Trim().ToUpper();
        //                correo.Actualizacion = DateTime.Now;
        //                if (ValidateFields(correo))
        //                {
        //                    blResultado = this.Crear(correo);
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
        //public bool Edit(ECorreo correo)
        //{
        //    bool blResultado = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var correoAnterior = Obtener(x => x.Id == correo.Id);
        //                if (correoAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");

        //                correoAnterior.CorreoElectronico = correo.CorreoElectronico;
        //                correoAnterior.Habilitado = correo.Habilitado;
        //                correoAnterior.Actualizacion = DateTime.Now;

        //                if (ValidateFields(correoAnterior))
        //                {
        //                    blResultado = this.Modificar(correoAnterior);
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
        //public bool Delete(ECorreo correo)
        //{
        //    bool blResultaodo = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == correo.Id);
        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

                      
        //                    this.Eliminar(correo);
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
        //public ECorreo GetbyId(Guid Id)
        //{
        //    ECorreo entidad = new ECorreo();
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
        //public List<ECorreo> ToLis()
        //{
        //    List<ECorreo> Lista = new List<ECorreo>();

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

   
        //public bool ValidateFields(ECorreo correo)
        //{
        //    bool blResultado = false;
        //    try
        //    {
        //        if (correo.CorreoElectronico.Trim().Length <= 0)
        //            throw new Exception("Debe ingresar un correo vàlido!");

        //        ValidateModification(correo);

        //        ValidateEmail(correo.CorreoElectronico);

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateModification(ECorreo correo)
        //{
        //    bool blResultado = false;
        //    try
        //    {

        //        var brCorreo = new BaseRepositorio<ECorreo>();

        //        var verificarCorreo = brCorreo.Obtener(x => x.CorreoElectronico == correo.CorreoElectronico && x.Id != correo.Id);
        //        if (verificarCorreo != null)
        //            throw new Exception("Correo ingresado ya se encuentra registrado!");

        //        blResultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        blResultado = false;
        //        throw new Exception(ex.Message);
        //    }
        //    return blResultado;
        //}
        //public bool ValidateEmail(String email)
        //{
        //    try
        //    {
        //        new MailAddress(email);
        //        return true;
                  
        //    }
        //    catch (Exception )
        //    {
        //        return false;
        //        throw new Exception("Formato correo invalido");
        //    }
        //}
        
    }
}
