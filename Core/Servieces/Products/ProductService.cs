using Core;
using Core.Domains;
using Core.Services.Products;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Products
{
    public class ProductService : IProductService
    {
        public void DeleteProduct(int id)
        {
            var product = Lists.products.Where(p => p.ID == id).FirstOrDefault();
            Lists.products.Remove(product);
        }

        public IList<Product> GetAllProducts()
        {
            return Lists.products;
        }

        public Product GetProductById(int id)
        {
            var product = Lists.products.Where(c => c.ID == id).FirstOrDefault();
            return product;
        }

        public void InsertProduct(Product product)
        {
            Lists.products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var oldProduct = Lists.products.Where(c => c.ID == product.ID).FirstOrDefault();
            oldProduct.Name = product.Name;
            oldProduct.Description = product.Description;
            oldProduct.Price = product.Price;
            oldProduct.Type = product.Type;
            oldProduct.Category = product.Category;
            
        }
    }
}
