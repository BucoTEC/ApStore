using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.ProductRepo
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProduct(int id);


        Task CreateProduct();

        Task UpdateProduct();

        Task DeleteProduct();






    }
}
