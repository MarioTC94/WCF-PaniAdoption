using Adoption.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Adoption.Persistence.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void AddRange(ICollection<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public ICollection<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public ICollection<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(ICollection<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }
    }
}