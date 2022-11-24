using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace DAL.Repositories.OrderItemRepo
{
    public interface IOrderItemRepository
    {
        Task<OrderItem> CreateOrderItem(CreateOrderItemDto createOrderItemDto);
    }
}
