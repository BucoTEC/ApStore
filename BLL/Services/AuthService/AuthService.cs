using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Utils;
using DAL.Dtos;
using DAL.Repositories.AuthRepository;
using DAL.UOW;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace BLL.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtHandler _jwtHandler;
        public AuthService(IUnitOfWork unitOfWork, IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
            _unitOfWork = unitOfWork;
        }


        public async Task<IdentityResult> Signup(SignUpModel data)
        {

            return await _unitOfWork.Auth.Signup(data);
        }

        public async Task<LoginResDto> Login(SignInModel data)
        {

            var user = await _unitOfWork.Auth.Login(data);

            if (user == null)
            {
                throw new Exception("unauthorized");
            }

            var token = _jwtHandler.GenerateJwtToken(user);
            return new LoginResDto() { Token = token, Role = user.AppUserRoleId };
        }

    }
}
