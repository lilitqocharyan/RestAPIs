using AutoMapper;
using Core.Domains;
using BLL.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.RequestModels;
using System;
using System.Collections.Generic;


namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        /// <summary>
        /// get all products
        /// </summary>
        /// <returns>Product list</returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_productService.GetAll());
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
            var product = _productService.GetById(id);
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
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult Add([FromBody] ProductAddRequestModel model)
        {
            if (model == null) { throw new ArgumentNullException("product can not be null"); }

            var product = _mapper.Map<Product>(model);
            var newProduct = _productService.Insert(product);

            return Ok(newProduct);
        }

        /// <summary>
        /// update product
        /// </summary>
        /// <param name="model">Product model</param>
        /// <returns>message</returns>
        [HttpPut]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] ProductEditRequestModel model)
        {
            if (model == null) { throw new ArgumentNullException("product can not be null"); }

            var product = _mapper.Map<Product>(model);
            var newProduct = _productService.Update(product);
            return Ok(newProduct);
        }

        /// <summary>
        /// delete product
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>message</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);

            return Ok("Product successfully deleted");
        }
    }
}
