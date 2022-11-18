using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();

    }
}
