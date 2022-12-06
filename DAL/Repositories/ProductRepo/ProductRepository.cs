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
            return await _context.Products.Where(d => d.DeletedAt == null).Include(c => c.Category).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {

            var product = await _context.Products.Where(d => d.DeletedAt == null).Include(p => p.Category).FirstOrDefaultAsync(p => p.ProductId == id);

            if (product != null)
            {
                return product;
            }
            throw new Exception("No product with this id");
        }


        public async Task<Product> CreateProduct(CreateUpdateProductDto productDto)
        {


            var existingProduct = await _context.Products.Where(d => d.DeletedAt == null).FirstOrDefaultAsync(p => p.Name == productDto.Name);

            if (existingProduct != null)
            {
                throw new Exception("Product already exists");
            }

            var category = await _context.Categories.FindAsync(productDto.CategoryId);

            if (category == null)
            {
                throw new Exception("No valid category selected");

            }

            var newProduct = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Image = productDto.Image,
                ShippingPrice = productDto.ShippingPrice,
                Price = productDto.Price,
                AvailableAmount = productDto.AvailableAmount,
                CategoryId = productDto.CategoryId

            };

            await _context.Products.AddAsync(newProduct);

            return newProduct;
        }

        public async Task<Product> UpdateProduct(CreateUpdateProductDto productDto, int productId)
        {

            var category = await _context.Categories.FindAsync(productDto.CategoryId);

            if (category == null)
            {
                throw new Exception("No valid category selected");

            }

            var product = await _context.Products.Where(d => d.DeletedAt == null).FirstOrDefaultAsync(p => p.ProductId == productId);

            if (product != null)
            {

                product.Name = productDto.Name;
                product.Description = productDto.Description;
                product.Image = productDto.Image;
                product.Price = productDto.Price;
                product.ShippingPrice = productDto.ShippingPrice;
                product.AvailableAmount = productDto.AvailableAmount;
                product.CategoryId = productDto.CategoryId;
                product.UpdatedAt = DateTime.Now;

                return product;
            }
            throw new Exception("No product with this id");
        }
    }
}
