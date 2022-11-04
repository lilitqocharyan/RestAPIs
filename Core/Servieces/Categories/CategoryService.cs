using Core.Domains;
using Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void DeleteCategoryById(int id)
        {
            _categoryRepository.Delete(id);
            _categoryRepository.Save();
        }

        public IList<Category> GetAllCategories()
        {
            return _categoryRepository.Categories().ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetByID(id);
        }

        public void InsertCategory(Category category)
        {
            _categoryRepository.Insert(category);
            _categoryRepository.Save();
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
            _categoryRepository.Save();
        }
    }
}
