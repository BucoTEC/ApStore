using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Dtos;
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

        public async Task<CartItem> CreateCartItem(CreateUpdateCartItemDto cartItemDto, string userId)
        {
            var existingCartItem = await _context.CartItems.Where(c => c.ProductId == cartItemDto.ProductId).FirstOrDefaultAsync();

            if (existingCartItem != null)
            {
                throw new Exception("cart item already exists");
            }

            var newCartItem = new CartItem()
            {
                Quantity = cartItemDto.Quantity,
                ProductId = cartItemDto.ProductId,
                AppUserId = userId
            };

            await _context.CartItems.AddAsync(newCartItem);

            return newCartItem;
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

        public async Task<CartItem> GetCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);

            if (cartItem == null)
            {
                throw new Exception("No cart item with this id");
            }

            return cartItem;
        }

        public async Task<List<CartItem>> GetCartItems(Expression<Func<CartItem, bool>>? expression = null)
        {
            IQueryable<CartItem> query = _context.Set<CartItem>();

            if (expression != null)
            {
                query = query.Where(expression);
            }

            return await query.ToListAsync();
        }

        public async Task<List<CartItem>> GetCartItemsByUser(string userId)
        {
            return await _context.CartItems.Where(c => c.AppUserId == userId).Include(p => p.Product).ToListAsync();
        }

        public async Task<CartItem> UpdateCartItem(CreateUpdateCartItemDto cartItemDto, int productId, string userId)
        {
            var cartItem = await _context.CartItems.FindAsync(productId);

            if (cartItem == null)
            {
                throw new Exception("No cart item with this id");
            }

            if (cartItem.AppUserId != userId)
            {

                throw new Exception("You are not owner of this cart item");
            }

            cartItem.Quantity = cartItemDto.Quantity;
            cartItem.UpdatedAt = DateTime.Now;


            return cartItem;
        }
    }
}
