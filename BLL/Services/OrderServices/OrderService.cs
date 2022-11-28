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

        public async Task<Order> CreateOrder(CreateOrderDto createOrderDto, string token)
        {


            var userId = _jwtHandler.DecodeToken(token).UserId;

            var newOrder = await _unitOfWork.Order.CreateOrder(createOrderDto, userId);


            var cartItems = await _unitOfWork.CartItem.GetCartItemsByUser(userId);

            if (cartItems.Count < 1)
            {
                throw new Exception("No cart items for this user");
            }
            else
            {
                foreach (var cartItem in cartItems)
                {
                    if (cartItem.Quantity > cartItem.Product.AvailbleAmount)
                    {
                        _unitOfWork.Dispose();

                        throw new Exception("The amount of selected product is over the availble amount");
                    }

                    var newOrderItem = new OrderItem()
                    {
                        ProductId = cartItem.ProductId,
                        Price = cartItem.Product.Price,
                        ShippingPrice = cartItem.Product.ShippingPrice,
                        Quantity = cartItem.Quantity,
                        Name = cartItem.Product.Name,
                        OrderId = newOrder.OrderId

                    };

                    _unitOfWork.Order.CreateOrderItem(newOrderItem);
                }
            }

            await _unitOfWork.CompleteAsync();

            return newOrder;
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


            if (order.AppUserId != decodedToken.UserId && decodedToken.UserRole != "Admin")
            {
                throw new Exception("You are not allowed to view this order");
            }

            return order;
        }
    }
}
