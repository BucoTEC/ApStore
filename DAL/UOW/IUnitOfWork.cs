using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Repositories.AppUserRepo;
using DAL.Repositories.AuthRepository;
using DAL.Repositories.CartItemRepo;
using DAL.Repositories.CategoryRepo;
using DAL.Repositories.OrderItemRepo;
using DAL.Repositories.OrderRepo;
using DAL.Repositories.ProductRepo;

namespace DAL.UOW
{
    public interface IUnitOfWork
    {
        IAppUserRepository AppUser { get; }

        IProductRepository Product { get; }

        IAuthRepository Auth { get; }

        ICartItemRepository CartItem { get; }

        IOrderRepository Order { get; }

        IOrderItemRepository OrderItem { get; }

        ICategoryRepository Category { get; }

        Task CompleteAsync();

        void Dispose();
    }
}
