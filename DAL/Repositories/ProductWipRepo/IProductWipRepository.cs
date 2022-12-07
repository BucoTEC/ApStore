using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.ProductWipRepo
{
    public interface IProductWipRepository
    {
        Task<ProductWip> Create(int productId, string userId);

        Task<ProductWip> GetByProductId(int productId);

        Task<bool> Delete(int id);

    }
}
