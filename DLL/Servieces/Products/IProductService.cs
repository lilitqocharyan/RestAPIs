using Core.Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DLL.Services.Products
{
    public interface IProductService
    {
        #region Products

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Product collection</returns>
        IList<Product> GetAllProducts();
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id">Product identifier</param>
        /// <returns></returns>
        Product GetProductById(int id);
        /// <summary>
        /// Insert a new product
        /// </summary>
        /// <param name="product">Product</param>
        void InsertProduct(Product product);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product</param>
        void UpdateProduct(Product product);
        /// <summary>
        /// Delete product by id
        /// </summary>
        /// <param name="id">Product id</param>
        void DeleteProduct(int id);

        #endregion
    }
}
