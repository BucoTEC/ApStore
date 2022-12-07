using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Utils;
using DAL.Dtos;
using DAL.Entities;
using DAL.Repositories.ProductRepo;
using DAL.UOW;

namespace BLL.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtHandler _jwtHandler;
        public ProductService(IUnitOfWork unitOfWork, IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> ProductWip(int productId, string token)
        {
            var productWip = await _unitOfWork.ProductWip.GetByProductId(productId);

            if (productWip != null)
            {
                return productWip.EditorId;
            }

            var userId = _jwtHandler.DecodeToken(token).UserId;

            var newProductWip = await _unitOfWork.ProductWip.Create(productId, userId);

            return newProductWip.EditorId;
        }

        public async Task<Boolean> ProductWipDelete(int productId, string token)
        {
            var productWip = await _unitOfWork.ProductWip.GetByProductId(productId);
            var userId = _jwtHandler.DecodeToken(token).UserId;

            if (productWip.EditorId != userId)
            {
                throw new Exception("Not ownr of work in progress");
            }


            await _unitOfWork.ProductWip.Delete(productId);

            return true;


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

            await _unitOfWork.CartItem.DeleteCartItemByProduct(id);

            if (DeleteProduct == true)
            {

                await _unitOfWork.CompleteAsync();
            }

            return DeleteProduct;
        }

        public async Task<Product> CreateProduct(CreateUpdateProductDto productDto)
        {
            var createdProduct = await _unitOfWork.Product.CreateProduct(productDto);

            if (createdProduct != null)
            {

                await _unitOfWork.CompleteAsync();
                return createdProduct;
            }

            _unitOfWork.Dispose();

            throw new Exception("Something went wrong");

        }

        public async Task<Product> UpdateProduct(CreateUpdateProductDto productDto, int productId)
        {
            // TODO move existing category check to service
            var updatedProduct = await _unitOfWork.Product.UpdateProduct(productDto, productId);

            await _unitOfWork.CompleteAsync();

            return updatedProduct;
        }
    }
}
