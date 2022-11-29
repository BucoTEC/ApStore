using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Services.Auth;
using DAL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("signup")]
        public async Task<ActionResult> Signup([FromBody] SignUpModel data)
        {
            var res = await _authService.Signup(data);

            if (res.Succeeded)
            {
                return Ok(res.Succeeded);
            }

            return Unauthorized(res);
        }


        [HttpPost("login")]
        public async Task<ActionResult<LoginResDto>> Login([FromBody] SignInModel signInModel)
        {
            var result = await _authService.Login(signInModel);

            return Ok(result);
        }
    }
}
