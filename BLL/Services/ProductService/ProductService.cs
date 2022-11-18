using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.ProductRepository;

namespace BLL.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _repository.GetProducts();
        }
    }
}
