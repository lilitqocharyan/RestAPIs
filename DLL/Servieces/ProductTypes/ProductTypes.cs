using Core.Domains;
using Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services.ProductTypes
{
    public class ProductTypes : IProductTypes
    {
        private readonly IProductTypeRepository _productTypeRepository;
        public ProductTypes(IProductTypeRepository productTypeRepository)
        {
            _productTypeRepository = productTypeRepository;
        }
        public void DeleteById(int id)
        {
            _productTypeRepository.Delete(id);
            _productTypeRepository.SaveChanges();
        }

        public IList<ProductType> GetAll()
        {
            return _productTypeRepository.GetAll().ToList();
        }

        public ProductType GetById(int id)
        {
            return _productTypeRepository.GetById(id);
        }

        public void Insert(ProductType productType)
        {
            _productTypeRepository.Add(productType);
            _productTypeRepository.SaveChanges();
        }

        public void Update(ProductType productType)
        {
            _productTypeRepository.Update(productType);
            _productTypeRepository.SaveChanges();
        }

    }
}
