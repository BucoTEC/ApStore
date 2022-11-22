using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.CartItemRepo
{
    public interface ICartItemRepository
    {
        Task<List<CartItem>> GetCartItems();

        Task<List<CartItem>> GetCartItemsByUser(string userId);


        Task<CartItem> GetCartItem(int id);


        Task<CartItem> CreateCartItem(object cartItmeDto);

        Task<CartItem> UpdateCartItem(object productDto, int productId);

        Task<bool> DeleteCartItem(int id);

        Task<bool> DeleteCartItemByUser(int id, string userId);

    }
}
