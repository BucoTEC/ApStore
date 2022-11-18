using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.ProductRepository
{
    public interface IProductInterface
    {
        Task<List<Product>> GetProducts();
    }
}
