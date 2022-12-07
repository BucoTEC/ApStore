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
using DAL.Repositories.ProductWipRepo;

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

        IProductWipRepository ProductWip { get; }

        Task CompleteAsync();

        void Dispose();
    }
}
