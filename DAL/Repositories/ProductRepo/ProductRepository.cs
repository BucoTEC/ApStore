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

        public Task DeleteProduct()
        {
            throw new NotImplementedException();
        }



        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.Include(c => c.Category).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

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
