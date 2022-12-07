using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Entities;

namespace DAL.Repositories.ProductWipRepo
{
    public class ProductWipRepository : IProductWipRepository
    {
        private readonly AppDbContext _context;
        public ProductWipRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductWip> GetByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductWip> Create(int productId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
