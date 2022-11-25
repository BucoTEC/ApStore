using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace DAL.Repositories.AuthRepository
{
    public interface IAuthRepository
    {
        Task<IdentityResult> Signup(SignUpModel data);

        Task<AppUser> Login(SignInModel signInModel);
    }
}
