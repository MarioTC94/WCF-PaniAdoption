using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Core.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(ICollection<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(ICollection<TEntity> entities);

        ICollection<TEntity> GetAll();
        ICollection<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
    }
}
