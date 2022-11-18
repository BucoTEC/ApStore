using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.ProductRepo;

namespace BLL.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _repository.GetProducts();
        }
    }
}
