using Core.Domains;
using System.Collections.Generic;

namespace Core.Services.Categories
{
    public interface ICategoryService
    {
        #region Categories

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Category collection</returns>
        IList<Category> GetAllCategories();
        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns></returns>
        Category GetCategoryById(int id);
        /// <summary>
        /// Insert a new category
        /// </summary>
        /// <param name="category">Category</param>
        void InsertCategory(Category category);
        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="category">Category</param>
        void UpdateCategory(Category category);
        /// <summary>
        /// Delete category by id
        /// </summary>
        /// <param name="id">Category id</param>
        void DeleteCategoryById(int id);

        #endregion
    }

}
