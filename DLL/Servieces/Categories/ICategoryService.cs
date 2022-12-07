using Core.Domains;
using System.Collections.Generic;

namespace BLL.Services.Categories
{
    public interface ICategoryService
    {
        #region Categories

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Category collection</returns>
        IList<Category> GetAll();
        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns></returns>
        Category GetById(int id);
        /// <summary>
        /// Insert a new category
        /// </summary>
        /// <param name="category">Category</param>
        Category Insert(Category category);
        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="category">Category</param>
        Category Update(Category category);
        /// <summary>
        /// Delete category by id
        /// </summary>
        /// <param name="id">Category id</param>
        void DeleteById(int id);

        #endregion
    }

}
