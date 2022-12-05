using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.ProductServices;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("paged")]
        public async Task<ActionResult<List<Product>>> GetPagedProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 6, [FromQuery] string? search = null)
        {
            // TODO finish implementation of paging including total pages count
            var prods = await _productService.GetProducts();
            if (search != null)
            {

                var pagedProds = prods.Where(c => c.Name.Contains(search)).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                return Ok(pagedProds);
            }

            var pp = prods.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pp);


        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]

        public async Task<ActionResult<Product>> CreateProduct(CreateUpdateProductDto productDto)
        {
            var createdProduct = await _productService.CreateProduct(productDto);

            return Ok(createdProduct);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Product>> UpdateProduct([FromBody] CreateUpdateProductDto productDto, [FromRoute] int id)

        {
            var product = await _productService.UpdateProduct(productDto, id);

            return Ok(product);
        }


    }
}
