using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Dtos;
using DAL.Entities;

namespace DAL.Repositories.OrderItemRepo
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly AppDbContext _context;
        public OrderItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<OrderItem> CreateOrderItem(CreateOrderItemDto createOrderItemDto)
        {
            var orderItem = new OrderItem()
            {
                ProductId = createOrderItemDto.ProductId,
                Price = createOrderItemDto.Price,
                ShippingPrice = createOrderItemDto.ShippingPrice,
                Quantity = createOrderItemDto.Quantity,
                Name = createOrderItemDto.Name,
                OrderId = createOrderItemDto.OrderId,


            };

            await _context.OrderItems.AddAsync(orderItem);

            return orderItem;

        }
    }
}
