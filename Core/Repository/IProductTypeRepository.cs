using Core.Domains;
using System;
using System.Collections.Generic;

namespace Core.Repository
{
    public interface IProductTypeRepository: IDisposable
    {
        IEnumerable<ProductType> ProductTypes();
        ProductType GetByID(int productTypeId);
        void Insert(ProductType productType);
        void Delete(int productTypeId);
        void Update(ProductType productType);
        void Save();
    }
}
