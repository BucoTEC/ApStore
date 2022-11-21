using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }



        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Products.Where(d => d.DeletedAt == null).FirstOrDefaultAsync(p => p.ProductId == id);

            if (product != null)
            {
                product.DeletedAt = DateTime.Now;

                return true;
            }

            return false;

        }



        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Where(d => d.DeletedAt == null).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.Where(d => d.DeletedAt == null).FirstOrDefaultAsync(p => p.ProductId == id);

            if (product != null)
            {
                return product;
            }
            throw new Exception("No product with this id");
        }
        public Task UpdateProduct()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> CreateProduct(CreateUpdateProductDto productDto)
        {
            var existingProduct = await _context.Products.Where(d => d.DeletedAt == null).FirstOrDefaultAsync(p => p.Name == productDto.Name);

            if (existingProduct != null)
            {
                throw new Exception("Product already exists");
            }

            var category = await _context.Products.FindAsync(productDto.CategoryId);

            if (category == null)
            {
                throw new Exception("No valid category selected");

            }

            var newProduct = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Image = productDto.Image,
                Price = productDto.Price,
                AvailbleAmount = productDto.AvailbleAmount,
                CategoryId = productDto.CategoryId

            };

            await _context.Products.AddAsync(newProduct);

            return newProduct;
        }
    }
}
