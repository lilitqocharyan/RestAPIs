using Core.Domains;
using BLL.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.RequestModels;
using System;
using System.Collections.Generic;
using AutoMapper;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>Category list</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAll());
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
            var category = _categoryService.GetById(id);
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
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] CategoryAddRequestModel model)
        {
            if (model == null) { throw new ArgumentNullException("category can not be null"); }

            var category = _mapper.Map<Category>(model);

            var newCategory = _categoryService.Insert(category);

            return Ok(newCategory);
        }

        /// <summary>
        /// update category
        /// </summary>
        /// <param name="model">Category Id, name and description</param>
        /// <returns>message</returns>
        [HttpPut]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] CategoryEditRequestModel model)
        {
            if (model == null) { throw new ArgumentNullException("category can not be null"); }
            
            var category = _mapper.Map<Category>(model);
            var newCategory =  _categoryService.Update(category);

            return Ok(newCategory);
        }
        /// <summary>
        /// delete category by id
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>message</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteById(id);

            return Ok("Category successfully deleted");
        }
    }
}
