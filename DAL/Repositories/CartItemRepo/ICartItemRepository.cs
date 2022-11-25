using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace DAL.Repositories.CartItemRepo
{
    public interface ICartItemRepository
    {
        Task<List<CartItem>> GetCartItems(Expression<Func<CartItem, bool>>? expression = null);

        Task<List<CartItem>> GetCartItemsByUser(string userId);


        Task<CartItem> GetCartItem(int id);


        Task<CartItem> CreateCartItem(CreateUpdateCartItemDto cartItemDto, string userId);

        Task<CartItem> UpdateCartItem(CreateUpdateCartItemDto cartItemDto, int productId, string userId);

        Task<bool> DeleteCartItem(int id);

        Task<bool> DeleteCartItemByUser(int id, string userId);

    }
}
