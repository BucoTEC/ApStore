using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Repositories.AuthRepository;
using DAL.UOW;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IdentityResult> Signup(SignUpModel data)
        {

            return await _unitOfWork.Auth.Signup(data);
        }

        public async Task<string> Login(SignInModel data)
        {

            return await _unitOfWork.Auth.LoginAsync(data);
        }

    }
}
