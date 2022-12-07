using Core.Domains;
using Core.Repository;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BLL.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void DeleteById(int id)
        {
            _categoryRepository.Delete(id);
            _categoryRepository.SaveChanges();
        }

        public IList<Category> GetAll()
        {
            return _categoryRepository.GetAll().ToList();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category Insert(Category category)
        {
            _categoryRepository.Add(category);
            _categoryRepository.SaveChanges();
            var newCategory = _categoryRepository.GetById(category.ID);
            return newCategory;
        }

        public Category Update(Category category)
        {
            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();
            var newCategory = _categoryRepository.GetById(category.ID);
            return newCategory;
        }
    }
}
