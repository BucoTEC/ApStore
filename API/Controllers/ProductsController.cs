using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.ProductServices;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var prods = await _productService.GetProducts();

            return Ok(prods);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProduct(int id)

        {

            var product = await _productService.DeleteProduct(id);

            if (product != true)
            {
                return NotFound("No product with this id");
            }

            return Ok(product);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)

        {
            var product = await _productService.GetProduct(id);

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(CreateProductDto productDto)
        {
            var createdProduct = await _productService.CreateProduct(productDto);

            return Ok(createdProduct);
        }


    }
}
