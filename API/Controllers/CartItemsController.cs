using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemsController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public async Task<JwtSecurityToken> GetCartItems()
        {
            Console.WriteLine(User.Identity);
            var token = await HttpContext.GetTokenAsync("access_token");

            var handler = new JwtSecurityTokenHandler();
            var dec = handler.ReadJwtToken(token);

            return dec;
        }
    }
}
