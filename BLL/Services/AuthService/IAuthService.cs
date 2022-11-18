using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Dtos;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services.Auth
{
    public interface IAuthService
    {
        Task<IdentityResult> Signup(SignUpModel data);
        Task<string> Login(SignInModel data);

    }
}
