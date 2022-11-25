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




        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<CartItem>>> GetCartItems()
        {
            var cartItems = await _cartItemService.GetCartItems();

            return Ok(cartItems);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CartItem>> GetCartItem([FromRoute] int id)
        {
            var cartItems = await _cartItemService.GetCartItem(id);

            return Ok(cartItems);
        }


        [HttpGet("by-user")]
        [Authorize]
        public async Task<ActionResult<CartItem>> GetCartItemsByUser()
        {


            // TODO add get cart items by user that were selected 

            var token = await HttpContext.GetTokenAsync("access_token");

            if (token == null)
            {
                throw new Exception("No token provided");
            }
            var cartItems = await _cartItemService.GetCartItemsByUser(token);

            return Ok(cartItems);
        }

        [HttpPost]
        [Authorize(Roles = "Customer")]
        public async Task<ActionResult<CartItem>> CreateCartItem(CreateUpdateCartItemDto cartItemDto)
        {

            var token = await HttpContext.GetTokenAsync("access_token");

            if (token == null)
            {
                throw new Exception("No token provided");
            }
            var cartItem = await _cartItemService.CreateCartItem(cartItemDto, token);

            return Ok(cartItem);
        }

        [HttpPatch("{productId}")]
        [Authorize]
        public async Task<ActionResult<CartItem>> UpdateCartItem([FromBody] CreateUpdateCartItemDto cartItemDto, [FromRoute] int productId)
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            if (token == null)
            {
                throw new Exception("No token provided");
            }

            var cartItem = await _cartItemService.UpdateCartItem(cartItemDto, productId, token);

            return Ok(cartItem);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<bool>> DeleteCartItem(int id)
        {
            var cartItem = await _cartItemService.DeleteCartItem(id);

            return Ok(cartItem);
        }

        [HttpDelete("by-user/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<bool>> DeleteCartItemByUser(int id)
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            if (token == null)
            {
                throw new Exception("No token provided");
            }
            var cartItem = await _cartItemService.DeleteCartItemByUser(id, token);

            return Ok(cartItem);
        }

    }
}
