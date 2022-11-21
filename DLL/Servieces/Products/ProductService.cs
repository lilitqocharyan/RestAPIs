using Core.Domains;
using Core.Repository;
using System.Collections.Generic;

namespace DLL.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            _productRepository.SaveChanges();
        }

        public IList<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void InsertProduct(Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }
    }
}
