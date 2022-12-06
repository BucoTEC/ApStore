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
        public async Task<ActionResult<PaginationResDto>> GetPagedProducts(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 4,
            [FromQuery] string? search = null,
            [FromQuery] int? categoryId = null,
            [FromQuery] string? orderByPrice = null,
            [FromQuery] string? orderCreatedAt = null


            )
        {

            var products = await _productService.GetProducts();
            if (search != null)
            {
                products = products.Where(c => c.Name.Contains(search)).ToList();

            }

            if (categoryId != null)
            {
                products = products.Where(c => c.CategoryId == categoryId).ToList();

            }

            if (orderByPrice != null)
            {

                if (orderByPrice == "DESC")
                {

                    products = products.OrderByDescending(p => p.Price).ToList();
                }

                if (orderByPrice == "ASC")
                {

                    products = products.OrderBy(p => p.Price).ToList();
                }

            }

            if (orderCreatedAt != null)
            {

                if (orderCreatedAt == "DESC")
                {

                    products = products.OrderByDescending(p => p.CreatedAt).ToList();
                }

                if (orderCreatedAt == "ASC")
                {

                    products = products.OrderBy(p => p.CreatedAt).ToList();
                }

            }
            var pageCount = (products.Count() + pageSize - 1) / pageSize;
            products = products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return Ok(
                new PaginationResDto()
                {
                    NumOfPages = pageCount,
                    Data = products
                }
            );


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
