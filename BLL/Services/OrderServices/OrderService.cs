using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;
using DAL.UOW;

namespace BLL.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Order> CreateOrder(CreateOrderDto createOrderDto, string? token)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _unitOfWork.Order.GetAllOrders();
        }

        public async Task<List<Order>> GetOrdersByUser(string? token)
        {
            return await _unitOfWork.Order.GetOrdersByUser(token);
        }

        public Task<Order> GetSingleOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
