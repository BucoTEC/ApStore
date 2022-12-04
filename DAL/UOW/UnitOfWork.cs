using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Entities;
using DAL.Repositories.AppUserRepo;
using DAL.Repositories.AuthRepository;
using DAL.Repositories.CartItemRepo;
using DAL.Repositories.CategoryRepo;
using DAL.Repositories.OrderItemRepo;
using DAL.Repositories.OrderRepo;
using DAL.Repositories.ProductRepo;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace DAL.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;

        public IAppUserRepository AppUser { get; private set; }

        public IAuthRepository Auth { get; private set; }
        public IProductRepository Product { get; private set; }

        public ICartItemRepository CartItem { get; private set; }

        public IOrderRepository Order { get; private set; }

        public IOrderItemRepository OrderItem { get; private set; }

        public ICategoryRepository Category { get; private set; }



        private readonly UserManager<AppUser> _userManager;

        private readonly SignInManager<AppUser> _signInManager;

        private readonly IConfiguration _configuration;

        public UnitOfWork(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            IConfiguration configuration)
        {
            _signInManager = signInManager;
            _configuration = configuration;
            _userManager = userManager;
            _context = context;

            Product = new ProductRepository(context);

            AppUser = new AppUserRepository(userManager);

            Auth = new AuthRepository(userManager, signInManager, configuration);

            CartItem = new CartItemRepository(context);

            Order = new OrderRepository(context);

            OrderItem = new OrderItemRepository(context);

            Category = new CategoryRepository(context);
        }



        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
