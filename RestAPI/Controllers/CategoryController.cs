using Core.Domains;
using DLL.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.RequestModels;
using System;
using System.Collections.Generic;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Category list</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAllCategories());
        }

        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns>Category</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public IActionResult Get([FromRoute] int id)
        {
            var category = _categoryService.GetCategoryById(id);
            if (category == null)
            {
                //throw new ObjectNotFoundException("not fount category by that specific id");
                return Ok("not fount category by that specific id");
            }

            return Ok(category);
        }

        /// <summary>
        /// add category
        /// </summary>
        /// <param name="model">Category name and description</param>
        /// <returns>message</returns>
        [HttpPost]
        public IActionResult Add([FromBody] CategoryAddRequest model)
        {
            if (model == null) { throw new ArgumentNullException("category can not be null"); }
            var category = new Category()
            {
                Name = model.Name,
                Description = model.Description
            };
            _categoryService.InsertCategory(category);

            return Ok("Category successfully added");
        }

        /// <summary>
        /// update category
        /// </summary>
        /// <param name="model">Category Id, name and description</param>
        /// <returns>message</returns>
        [HttpPut]
        public IActionResult Update([FromBody] CategoryUpdateRequest model)
        {
            if (model == null) { throw new ArgumentNullException("category can not be null"); }
            var category = new Category()
            {
                ID = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            _categoryService.UpdateCategory(category);

            return Ok("Category successfully updated");
        }
        /// <summary>
        /// delete category by id
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>message</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategoryById(id);

            return Ok("Category successfully deleted");
        }
    }
}
