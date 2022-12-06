using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.AppUserRepo
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly UserManager<AppUser> _userManager;
        public AppUserRepository(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<AppUser>> GetAppUsers()
        {
            return await _userManager.Users.Include(c => c.CartItems).Include(o => o.Orders).ToListAsync();
        }

        public async Task<AppUser> GetCurrentUser(string userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user != null)
            {
                return user;
            }
            throw new Exception("No user with this id");
        }
    }
}
