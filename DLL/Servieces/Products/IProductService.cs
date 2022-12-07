using Core.Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services.Products
{
    public interface IProductService
    {
        #region Products

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Product collection</returns>
        IList<Product> GetAll();
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id">Product identifier</param>
        /// <returns></returns>
        Product GetById(int id);
        /// <summary>
        /// Insert a new product
        /// </summary>
        /// <param name="product">Product</param>
        Product Insert(Product product);
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product</param>
        Product Update(Product product);
        /// <summary>
        /// Delete product by id
        /// </summary>
        /// <param name="id">Product id</param>
        void Delete(int id);

        #endregion
    }
}
