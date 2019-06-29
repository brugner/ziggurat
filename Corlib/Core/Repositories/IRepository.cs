using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Corlib.Core.Repositories
{
   public interface IRepository<TEntity> where TEntity : class
   {
      /// <summary>
      /// Devuelve una entidad buscando por Id.
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      TEntity Get(int id);

      /// <summary>
      /// Devuelve una entidad buscando por un predicado. Permite incluir entidades relacionadas.
      /// </summary>
      /// <param name="predicate"></param>
      /// <param name="includes"></param>
      /// <returns></returns>
      TEntity Get(Expression<Func<TEntity, bool>> predicate, params string[] includes);

      /// <summary>
      /// Devuelve una lista de entidades buscando por un predicado. Permite incluir entidades relacionadas.
      /// </summary>
      /// <param name="predicate"></param>
      /// <param name="includes"></param>
      /// <returns></returns>
      IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params string[] includes);

      /// <summary>
      /// Devuelve todas las entidades.
      /// </summary>
      /// <returns></returns>
      IEnumerable<TEntity> GetAll();

      /// <summary>
      /// Devuelve todas las entidades. Permite incluir entidades relacionadas.
      /// </summary>
      /// <param name="includes"></param>
      /// <returns></returns>
      IEnumerable<TEntity> GetAll(params string[] includes);

      /// <summary>
      /// Devuelve una lista de entidades ordenadas por un predicado. Permite limitarlas a determinada cantidad. Permite incluir entidades relacionadas.
      /// </summary>
      /// <typeparam name="TKey"></typeparam>
      /// <param name="orderBy"></param>
      /// <param name="ascending"></param>
      /// <param name="limit"></param>
      /// <param name="includes"></param>
      /// <returns></returns>
      IEnumerable<TEntity> GetAll<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool ascending = true, int limit = 0, params string[] includes);

      void Add(TEntity entity);
      void AddRange(IEnumerable<TEntity> entities);
      void Remove(TEntity entity);
      void RemoveRange(IEnumerable<TEntity> entities);
   }
}
