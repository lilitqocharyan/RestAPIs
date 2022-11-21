using Core.Domains;
using DLL.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.RequestModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;


namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// get all products
        /// </summary>
        /// <returns>Product list</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_productService.GetAllProducts());
        }

        /// <summary>
        /// get product by id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult Get([FromRoute] int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                //throw new ObjectNotFoundException("not fount product by that specific id");
                return Ok("not fount product by that specific id");
            }

            return Ok(product);
        }

        /// <summary>
        /// add product
        /// </summary>
        /// <param name="model">Product model</param>
        /// <returns>message</returns>
        [HttpPost]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] ProductAddRequest model)
        {
            if (model == null) { throw new ArgumentNullException("product can not be null"); }
            var product = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                ProductTypeID = model.ProductTypeID,
                CategoryID = model.CategoryID
            };
            _productService.InsertProduct(product);

            return Ok("Product successfully added");
        }

        /// <summary>
        /// update product
        /// </summary>
        /// <param name="model">Product model</param>
        /// <returns>message</returns>
        [HttpPut]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] ProductUpdateRequest model)
        {
            if (model == null) { throw new ArgumentNullException("product can not be null"); }
            var product = new Product()
            {
                ID = model.Id,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                ProductTypeID = model.ProductTypeID,
                CategoryID = model.CategoryID
            };
            _productService.UpdateProduct(product);

            return Ok("Product successfully updated");
        }

        /// <summary>
        /// delete product
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>message</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);

            return Ok("Product successfully deleted");
        }
    }
}
