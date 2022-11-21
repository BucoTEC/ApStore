using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace BLL.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);

        Task<bool> DeleteProduct(int id);

        Task<Product> CreateProduct(CreateProductDto productDto);


    }
}
