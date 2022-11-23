using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.CartItemServices;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemsController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;
        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpGet("jwt-test")]
        [Authorize]
        public async Task<JwtSecurityToken> JwtTest()
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            var handler = new JwtSecurityTokenHandler();
            var dec = handler.ReadJwtToken(token);

            return dec;
        }


        [HttpGet]
        public async Task<ActionResult<List<CartItem>>> GetCartItems()
        {
            var cartItems = await _cartItemService.GetCartItems();

            return Ok(cartItems);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CartItem>> GetCartItem([FromRoute] int id)
        {
            var cartItems = await _cartItemService.GetCartItem(id);

            return Ok(cartItems);
        }


        [HttpGet("by-user/{id}")]
        public async Task<ActionResult<CartItem>> GetCartItemsByUser([FromRoute] string userId)
        {
            var cartItems = await _cartItemService.GetCartItemsByUser(userId);

            return Ok(cartItems);
        }

        [HttpPost]
        public async Task<ActionResult<CartItem>> CreateCartItem(CreateUpdateCartItemDto cartItemDto)
        {
            var cartItem = await _cartItemService.CreateCartItem(cartItemDto);

            return Ok(cartItem);
        }

        [HttpPatch("{productId}")]
        public async Task<ActionResult<CartItem>> UpdateCartItem([FromBody] CreateUpdateCartItemDto cartItemDto, [FromRoute] int productId, string userId)
        {
            var cartItem = await _cartItemService.UpdateCartItem(cartItemDto, productId, userId);

            return Ok(cartItem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCartItem(int id)
        {
            var cartItem = await _cartItemService.DeleteCartItem(id);

            return Ok(cartItem);
        }

    }
}
