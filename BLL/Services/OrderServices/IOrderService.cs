using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;

namespace BLL.Services.OrderServices
{
    public interface IOrderService
    {

        Task<List<Order>> GetAllOrders();



        Task<Order> GetSingleOrder(int id, string token);



        Task<List<Order>> GetOrdersByUser(string token);



        Task<Order> CreateOrder(CreateOrderDto createOrderDto, string token);

    }
}
