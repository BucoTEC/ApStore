using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Utils;
using DAL.Dtos;
using DAL.Entities;
using DAL.Repositories.AppUserRepo;
using DAL.UOW;

namespace BLL.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtHandler _jwtHandler;

        public AppUserService(IUnitOfWork unitOfWork, IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
            _unitOfWork = unitOfWork;

        }


        public async Task<List<AppUser>> GetAppUsers()
        {
            return await _unitOfWork.AppUser.GetAppUsers();
        }

        public async Task<UserDataDto> GetCurrentUser(string token)
        {

            var userId = _jwtHandler.DecodeToken(token).UserId;

            var user = await _unitOfWork.AppUser.GetCurrentUser(userId);

            return new UserDataDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive,
                Email = user.Email,
                AppUserRoleId = user.AppUserRoleId,
                AppUserRole = user.AppUserRole,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
                DeletedAt = user.DeletedAt

            };
        }
    }
}
