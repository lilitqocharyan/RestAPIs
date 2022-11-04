using Core;
using Core.Domains;
using Core.Repository;
using Core.Services.Products;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            _productRepository.Save();
        }

        public IList<Product> GetAllProducts()
        {
            return _productRepository.Products().ToList();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetByID(id);
        }

        public void InsertProduct(Product product)
        {
            _productRepository.Insert(product);
            _productRepository.Save();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }
    }
}
