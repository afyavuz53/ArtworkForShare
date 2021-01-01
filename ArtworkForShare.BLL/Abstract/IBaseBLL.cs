using System;
using System.Collections.Generic;
using System.Text;
using ArtworkForShare.Core.Entity;

namespace ArtworkForShare.BLL.Abstract
{
    public interface IBaseBLL<T>
        where T:BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        T Get(int id);
        ICollection<T> GetAll();
    }
}
