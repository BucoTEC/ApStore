using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;
using DAL.UOW;

namespace BLL.Services.CartItemServices
{
    public class CartItemService : ICartItemService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CartItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CartItem> CreateCartItem(CreateUpdateCartItemDto cartItemDto)
        {
            return await _unitOfWork.CartItem.CreateCartItem(cartItemDto);
        }

        public async Task<bool> DeleteCartItem(int id)
        {
            return await _unitOfWork.CartItem.DeleteCartItem(id);
        }

        public async Task<bool> DeleteCartItemByUser(int id, string userId)
        {
            return await _unitOfWork.CartItem.DeleteCartItemByUser(id, userId);
        }

        public async Task<CartItem> GetCartItem(int id)
        {
            return await _unitOfWork.CartItem.GetCartItem(id);
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            return await _unitOfWork.CartItem.GetCartItems();
        }

        public async Task<List<CartItem>> GetCartItemsByUser(string userId)
        {
            return await _unitOfWork.CartItem.GetCartItemsByUser(userId);
        }

        public async Task<CartItem> UpdateCartItem(CreateUpdateCartItemDto cartItemDto, int productId, string userId)
        {
            return await _unitOfWork.CartItem.UpdateCartItem(cartItemDto, productId, userId);
        }
    }
}
