using Core.Domains;
using Core.Repository;
using System.Collections.Generic;


namespace DLL.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void DeleteCategoryById(int id)
        {
            _categoryRepository.Delete(id);
            _categoryRepository.SaveChanges();
        }

        public IList<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void InsertCategory(Category category)
        {
            _categoryRepository.Add(category);
            _categoryRepository.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();
        }
    }
}
