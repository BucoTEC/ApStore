using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.CartItemRepo
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AppDbContext _context;
        public CartItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<CartItem> CreateCartItem(object cartItmeDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
            }

            throw new Exception("no cart item with this id");
        }

        public async Task<bool> DeleteCartItemByUser(int id, string userId)
        {

            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem == null)
            {
                throw new Exception("no cart item with this id");
            }

            if (cartItem.AppUserId != userId)
            {

                throw new Exception("You are not owner of this cart item");
            }

            _context.CartItems.Remove(cartItem);

            return true;

        }

        public Task<CartItem> GetCartItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            return await _context.CartItems.ToListAsync();
        }

        public async Task<List<CartItem>> GetCartItemsByUser(string userId)
        {
            return await _context.CartItems.Where(c => c.AppUserId == userId).ToListAsync();

        }

        public Task<CartItem> UpdateCartItem(object productDto, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
