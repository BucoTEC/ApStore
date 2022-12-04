using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.AppUserServices;
using DAL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public UsersController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public async Task<List<AppUser>> GetUsers()
        {
            return await _appUserService.GetAppUsers();
        }


        [HttpGet("current-user")]
        [Authorize]
        public async Task<UserDataDto> GetCurrentUser()
        {
            var token = await HttpContext.GetTokenAsync("access_token");

            if (token == null)
            {
                throw new Exception("No token provided");
            }

            return await _appUserService.GetCurrentUser(token);
        }
    }
}
