using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    interface IRepositorio<T> where T:class
    {
        List<T> Listar();
        List<T> Listar(List<Expression<Func<T, object>>> incluir);

        T Obtener(Expression<Func<T, bool>> predicado);
        T Obtener(Expression<Func<T, bool>> predicado, List<Expression<Func<T, object>>> incluir);

        List<T> Filtrar(Expression<Func<T, bool>> Predicado);
        List<T> Filtrar(Expression<Func<T, bool>> Predicado, List<Expression<Func<T, object>>> incluir);

        bool Crear(T entity);
        bool Modificar(T entity);
        bool Eliminar(T entity);
        bool Eliminar(Expression<Func<T, bool>> Predicado);
    }
}
