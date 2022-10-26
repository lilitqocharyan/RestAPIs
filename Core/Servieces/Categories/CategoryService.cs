using Core.Domains;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        public void DeleteCategoryById(int id)
        {
            var category = Lists.categories.Where(c => c.ID == id).FirstOrDefault();
            Lists.categories.Remove(category);
        }

        public IList<Category> GetAllCategories()
        {
            return Lists.categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = Lists.categories.Where(c => c.ID == id).FirstOrDefault();
            return category;
        }

        public void InsertCategory(Category category)
        {
            Lists.categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var oldCategory = Lists.categories.Where(c => c.ID == category.ID).FirstOrDefault();
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;
        }
    }
}
