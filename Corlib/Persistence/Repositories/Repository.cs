using Corlib.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Corlib.Persistence.Repositories
{
   public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
   {
      protected readonly DbContext Context;

      public Repository(DbContext context)
      {
         Context = context;
      }

      public TEntity Get(int id)
      {
         return Context.Set<TEntity>().Find(id);
      }

      public TEntity Get(Expression<Func<TEntity, bool>> predicate, params string[] includes)
      {
         var query = Context.Set<TEntity>().AsQueryable().Where(predicate);

         if (includes != null)
            query = includes.Aggregate(query, (current, include) => current.Include(include));

         return query.FirstOrDefault();
      }

      public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, params string[] includes)
      {
         var query = Context.Set<TEntity>().AsQueryable().Where(predicate);

         if (includes != null)
            query = includes.Aggregate(query, (current, include) => current.Include(include));

         return query.ToList();
      }

      public IEnumerable<TEntity> GetAll()
      {
         return Context.Set<TEntity>().ToList();
      }

      public IEnumerable<TEntity> GetAll(params string[] includes)
      {
         var query = Context.Set<TEntity>().AsQueryable();

         if (includes != null)
            query = includes.Aggregate(query, (current, include) => current.Include(include));

         return query.ToList();
      }

      public IEnumerable<TEntity> GetAll<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool ascending = true, int limit = 0, params string[] includes)
      {
         var query = Context.Set<TEntity>().AsQueryable();

         if (includes != null)
            query = includes.Aggregate(query, (current, include) => current.Include(include));

         if (ascending)
            query = query.OrderBy(orderBy);
         else
            query = query.OrderByDescending(orderBy);

         if (limit == 0)
            return query.ToList();
         else
            return query.Take(limit).ToList();
      }

      public void Add(TEntity entity)
      {
         Context.Set<TEntity>().Add(entity);
      }

      public void AddRange(IEnumerable<TEntity> entities)
      {
         Context.Set<TEntity>().AddRange(entities);
      }

      public void Remove(TEntity entity)
      {
         Context.Set<TEntity>().Remove(entity);
      }

      public void RemoveRange(IEnumerable<TEntity> entities)
      {
         Context.Set<TEntity>().RemoveRange(entities);
      }
   }
}
