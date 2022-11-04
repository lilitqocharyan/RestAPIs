using Core.Domains;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public interface ICategoryRepository: IDisposable
    {
        IEnumerable<Category> Categories();
        Category GetByID(int categoryId);
        void Insert(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        void Save();
    }
}
