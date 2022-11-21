using Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IList<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SaveChanges();
        T FindByCondition(Expression<Func<T, bool>> predicate);
    }
}
