using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
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

        public async Task<bool> DeleteProduct(int id)
        {
            var DeleteProduct = await _unitOfWork.Product.DeleteProduct(id);

            if (DeleteProduct == true)
            {

                await _unitOfWork.CompleteAsync();
            }

            return DeleteProduct;
        }

        public async Task<Product> CreateProduct(CreateUpdateProductDto productDto)
        {
            var createdProduct = await _unitOfWork.Product.CreateProduct(productDto);

            await _unitOfWork.CompleteAsync();

            return createdProduct;
        }
    }
}
