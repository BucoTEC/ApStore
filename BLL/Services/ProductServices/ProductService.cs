using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.ProductRepo;
using DAL.UOW;

namespace BLL.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _unitOfWork.Product.GetProducts();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _unitOfWork.Product.GetProduct(id);
        }

    }
}
