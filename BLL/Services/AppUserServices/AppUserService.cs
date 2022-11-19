using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.AppUserRepo;
using DAL.UOW;

namespace BLL.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }


        public async Task<List<AppUser>> GetAppUsers()
        {
            return await _unitOfWork.AppUser.GetAppUsers();
        }
    }
}
