using Core.Domains;
using Core.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status404NotFound)]
        public IActionResult Get([FromRoute] int id)
        {
            if (id == 0) { return Ok(_productService.GetAllProducts()); }

            var product = _productService.GetProductById(id);
            if (product == null)
            {
                throw new ObjectNotFoundException("not fount product by that specific id");
            }

            return Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] Product product)
        {
            if (product == null) { throw new ArgumentNullException("product can not be null"); }

            _productService.InsertProduct(product);

            return Ok("Product successfully added");
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] Product product)
        {
            if (product == null) { throw new ArgumentNullException("product can not be null"); }

            _productService.UpdateProduct(product);

            return Ok("Product successfully updated");
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);

            return Ok("Product successfully deleted");
        }
    }
}
