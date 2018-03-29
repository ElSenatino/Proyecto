using Controlador.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public  class BaseRepositorio<T> : IRepositorio<T> where  T :class
    {
        public List<T> Listar()
        {
            using (EContext context = new EContext())
            {
                return (List<T>)context.Set<T>().ToList();
            }
        }

        public List<T> Listar(List<Expression<Func<T, object>>> includes)
        {
            List<string> includelist = new List<string>();

            foreach (var item in includes)
            {
                MemberExpression body = item.Body as MemberExpression;
                if (body == null)
                    throw new ArgumentException("The body must be a member expression");

                includelist.Add(body.Member.Name);
            }

            using (EContext context = new EContext())
            {
                DbQuery<T> query = context.Set<T>();

                includelist.ForEach(x => query = query.Include(x));

                return (List<T>)query.ToList();
            }

        }


        public T Obtener(Expression<Func<T, bool>> predicate)
        {
            using (EContext context = new EContext())
            {
                return context.Set<T>().FirstOrDefault(predicate);
            }
        }

        public T Obtener(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes)
        {
            List<string> includelist = new List<string>();

            foreach (var item in includes)
            {
                MemberExpression body = item.Body as MemberExpression;
                if (body == null)
                    throw new ArgumentException("The body must be a member expression");

                includelist.Add(body.Member.Name);
            }

            using (EContext context = new EContext())
            {
                DbQuery<T> query = context.Set<T>();

                includelist.ForEach(x => query = query.Include(x));

                return query.FirstOrDefault(predicate);
            }
        }


        public List<T> Filtrar(Expression<Func<T, bool>> predicate)
        {
            using (EContext context = new EContext())
            {
                return (List<T>)context.Set<T>().Where(predicate).ToList();
            }
        }

        public List<T> Filtrar(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes)
        {
            List<string> includelist = new List<string>();

            foreach (var item in includes)
            {
                MemberExpression body = item.Body as MemberExpression;
                if (body == null)
                    throw new ArgumentException("The body must be a member expression");

                includelist.Add(body.Member.Name);
            }

            using (EContext context = new EContext())
            {
                DbQuery<T> query = context.Set<T>();

                includelist.ForEach(x => query = query.Include(x));

                return (List<T>)query.Where(predicate).ToList();
            }
        }


        public bool Crear(T entity)
        {
            bool blResultado = false;
                using (EContext context = new EContext())
                {
                    
                        try
                        {
                            context.Set<T>().Add(entity);
                            context.SaveChanges();
                          
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

        public bool Modificar(T entity)
        {

            bool blResultado = false;
            using (EContext context = new EContext())
            {
              try
              {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
                      
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

        public bool Eliminar(T entity)
        {
            bool blResultado = false;
            using (EContext context = new EContext())
            {

               
                    try
                    {
                        context.Entry(entity).State = EntityState.Deleted;
                        context.SaveChanges();
                   
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

        public bool Eliminar(Expression<Func<T, bool>> predicate)
        {
            bool blResultado = false;
            using (EContext context = new EContext())
            {
                    try
                    {
                        var entities = context.Set<T>().Where(predicate).ToList();
                        entities.ForEach(x => context.Entry(x).State = EntityState.Deleted);
                        context.SaveChanges();
                        blResultado = true;
                    }
                    catch (Exception ex )
                    {
                        blResultado = false;
                        throw new Exception(ex.Message);
                    }
            }
            return blResultado;
        }

    }
}
