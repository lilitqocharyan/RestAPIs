using Core.Domains;
using Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Delete(int id)
        {
            _productRepository.Delete(id);
            _productRepository.SaveChanges();
        }

        public IList<Product> GetAll()
        {
            return _productRepository.GetAllWithCategories().ToList();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product Insert(Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveChanges();
            var newProduct = _productRepository.GetById(product.ID);
            return newProduct;
        }

        public Product Update(Product product)
        {
            _productRepository.Update(product);
            _productRepository.SaveChanges();
            var newProduct = _productRepository.GetById(product.ID);
            return newProduct;
        }
    }
}
