using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.OrderServices;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var orders = await _service.GetAllOrders();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetSingleOrder([FromRoute] int id)
        {
            var order = await _service.GetSingleOrder(id);

            return order;
        }

        [HttpGet("by-user")]
        [Authorize]
        public async Task<ActionResult<List<Order>>> GetOrdersByUser()
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            var handler = new JwtSecurityTokenHandler();

            var decodedToken = handler.ReadJwtToken(token);

            var orders = await _service.GetOrdersByUser(token);

            return Ok(orders);

        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] CreateOrderDto createOrderDto)
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            var handler = new JwtSecurityTokenHandler();

            var decodedToken = handler.ReadJwtToken(token);

            var createdOrder = await _service.CreateOrder(createOrderDto, token);

            return Ok(createdOrder);
        }
    }
}
