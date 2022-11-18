using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.AppUserRepo;

namespace BLL.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        public AppUserService(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }


        public async Task<List<AppUser>> GetAppUsers()
        {
            return await _appUserRepository.GetAppUsers();
        }
    }
}
