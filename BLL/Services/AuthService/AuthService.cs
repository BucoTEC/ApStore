using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Repositories.AuthRepository;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repo;
        public AuthService(IAuthRepository repo)
        {
            _repo = repo;
        }


        public async Task<IdentityResult> Signup(SignUpModel data)
        {

            return await _repo.Signup(data);
        }

        public async Task<string> Login(SignInModel data)
        {

            return await _repo.LoginAsync(data);
        }

    }
}
