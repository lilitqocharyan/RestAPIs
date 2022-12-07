using Core.Domains;
using System.Collections.Generic;

namespace BLL.Services.ProductTypes
{
    public interface IProductTypes
    {
        #region ProductTypes

        /// <summary>
        /// Get all Product Types
        /// </summary>
        /// <returns>Product Types collection</returns>
        IList<ProductType> GetAll();
        /// <summary>
        /// Get Product Type by id
        /// </summary>
        /// <param name="id">Product Type identifier</param>
        /// <returns></returns>
        ProductType GetById(int id);
        /// <summary>
        /// Insert a new Product Type
        /// </summary>
        /// <param name="productType">Product Type</param>
        void Insert(ProductType productType);
        /// <summary>
        /// Update Product Type
        /// </summary>
        /// <param name="productType">Product Type</param>
        void Update(ProductType productType);
        /// <summary>
        /// Delete Product Type by id
        /// </summary>
        /// <param name="id">Product Type id</param>
        void DeleteById(int id);

        #endregion
    }

}
