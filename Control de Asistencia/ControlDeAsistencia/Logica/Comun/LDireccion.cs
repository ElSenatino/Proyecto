
using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Comun
{
    public class LDireccion 
    {

        //public LDireccion() { }
        //public bool Add(EDireccion direccion)
        //{
        //    bool blResultado = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                direccion.Id = Guid.NewGuid();
        //                direccion.NombreVia = direccion.NombreVia.Trim().ToUpper();
        //                direccion.Numero = direccion.Numero.Trim().ToUpper();
        //                direccion.Urbanizacion = direccion.Urbanizacion.Trim().ToUpper();
        //                direccion.Referencia = direccion.Referencia.Trim().ToUpper();

        //                direccion.Actualizacion = DateTime.Now;

                       
        //                    blResultado = this.Crear(direccion);
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
        //public bool Edit(EDireccion direccion)
        //{
        //    bool blResultado = false;

        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var direccionAnterior = Obtener(x => x.Id == direccion.Id);
        //                if (direccionAnterior == null)
        //                    throw new Exception("Dato seleccionado no existe!");


        //                direccionAnterior.TipoDireccion = direccion.TipoDireccion;
        //                direccionAnterior.NombreVia = direccion.NombreVia;
        //                direccionAnterior.Numero = direccion.Numero;
        //                direccionAnterior.Urbanizacion = direccion.Urbanizacion;
        //                direccionAnterior.Referencia = direccion.Referencia;
        //                direccionAnterior.UbigeoId = direccion.UbigeoId;
        //                direccionAnterior.Habilitado = direccion.Habilitado;
        //                direccionAnterior.Actualizacion = DateTime.Now;
                       
                       
        //                    blResultado = this.Modificar(direccionAnterior);
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
        //public bool Delete(EDireccion direccion)
        //{
        //    bool blResultaodo = false;
        //    using (EContext context = new EContext())
        //    {
        //        using (var trans = context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var datoObtenido = this.Obtener(x => x.Id == direccion.Id);
        //                if (datoObtenido == null)
        //                    throw new Exception("Dato seleccionado no existe!");

                     
        //                    this.Eliminar(direccion);
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
        //public EDireccion GetbyId(Guid Id)
        //{
        //    EDireccion entidad = new EDireccion();
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
        //public List<EDireccion> ToLis()
        //{
        //    List<EDireccion> Lista = new List<EDireccion>();

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
