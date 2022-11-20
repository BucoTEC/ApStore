using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
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

        public Task CreateProduct()
        {
            throw new NotImplementedException();
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
    }
}
