using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Utils;
using DAL.Dtos;
using DAL.Entities;
using DAL.UOW;

namespace BLL.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtHandler _jwtHandler;
        public OrderService(IUnitOfWork unitOfWork, IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
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

        public async Task<List<Order>> GetOrdersByUser(string token)
        {
            var userId = _jwtHandler.DecodeToken(token).UserId;

            return await _unitOfWork.Order.GetOrdersByUser(userId);
        }

        public async Task<Order> GetSingleOrder(int id, string token)
        {
            var order = await _unitOfWork.Order.GetSingleOrder(id);
            var decodedToken = _jwtHandler.DecodeToken(token);

            if (order.AppUserId != decodedToken.UserId || decodedToken.UserRole != "Admin")
            {
                throw new Exception("You are not allowed to view this order");
            }

            return order;
        }
    }
}
