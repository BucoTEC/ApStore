using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.ProductWipRepo
{
    public class ProductWipRepository : IProductWipRepository
    {
        private readonly AppDbContext _context;
        public ProductWipRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(int id)
        {
            var productWip = await _context.ProductWips.FirstOrDefaultAsync(c => c.ProductId == id);

            if (productWip != null)
            {

                _context.ProductWips.Remove(productWip);

                return true;
            }


            throw new Exception("No wip for product with this id");
        }

        public async Task<ProductWip> GetByProductId(int productId)
        {

            var productWip = await _context.ProductWips.FirstOrDefaultAsync(c => c.ProductId == productId);


            return productWip;


        }

        public async Task<ProductWip> Create(int productId, string userId)
        {
            var newProductWip = new ProductWip()
            {
                EditorId = userId,
                ProductId = productId
            };

            await _context.ProductWips.AddAsync(newProductWip);

            return newProductWip;
        }
    }
}
