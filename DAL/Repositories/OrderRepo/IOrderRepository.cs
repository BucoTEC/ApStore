using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace DAL.Repositories.OrderRepo
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders();


        void CreateOrderItem(OrderItem orderItem);

        Task<Order> GetSingleOrder(int id);



        Task<List<Order>> GetOrdersByUser(string userId);



        Task<Order> CreateOrder(CreateOrderDto createOrderDto, string userId);
    }
}
