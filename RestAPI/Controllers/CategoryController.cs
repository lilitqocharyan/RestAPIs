using Core.Domains;
using Core.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;

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

        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAllCategories());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status404NotFound)]
        public IActionResult Get([FromRoute] int id)
        {
            if (id == 0) { return Ok(_categoryService.GetAllCategories()); }

            var category = _categoryService.GetCategoryById(id);
            if (category == null)
            {
                throw new ObjectNotFoundException("not fount category by that specific id");
            }

            return Ok(category);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] Category category)
        {
            if (category == null) { throw new ArgumentNullException("category can not be null"); }

            _categoryService.InsertCategory(category);

            return Ok("Category successfully added");
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] Category category)
        {
            if (category == null) { throw new ArgumentNullException("category can not be null"); }

            _categoryService.UpdateCategory(category);

            return Ok("Category successfully updated");
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategoryById(id);

            return Ok("Category successfully deleted");
        }
    }
}
