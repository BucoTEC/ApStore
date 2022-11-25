using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace BLL.Services.CartItemServices
{
    public interface ICartItemService
    {
        Task<List<CartItem>> GetCartItems();

        Task<List<CartItem>> GetCartItemsByUser(string token);


        Task<CartItem> GetCartItem(int id);


        Task<CartItem> CreateCartItem(CreateUpdateCartItemDto cartItemDto, string token);

        Task<CartItem> UpdateCartItem(CreateUpdateCartItemDto cartItemDto, int productId, string userId);

        Task<bool> DeleteCartItem(int id);

        Task<bool> DeleteCartItemByUser(int id, string userId);
    }
}
