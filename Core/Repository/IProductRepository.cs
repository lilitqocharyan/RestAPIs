using Core.Domains;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public interface IProductRepository: IDisposable
    {
        IEnumerable<Product> Products();
        Product GetByID(int productId);
        void Insert(Product product);
        void Delete(int productId);
        void Update(Product product);
        void Save();
    }
}
