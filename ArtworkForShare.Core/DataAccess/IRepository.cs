using ArtworkForShare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArtworkForShare.Core.DataAccess
{
    public interface IRepository<T>
        where T:BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>> filter,params Expression<Func<T, object>>[] include);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter=null, params Expression<Func<T, object>>[] include);
    }
}
