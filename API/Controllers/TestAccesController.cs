using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestAccesController : ControllerBase
    {
        [HttpGet("authorized-user")]
        [Authorize]
        public string OnlyForLoggedIn()
        {
            return "Hello logged in user";
        }

        [HttpGet("all-users-access")]
        public string AllUsers()
        {
            // throw new Exception("Hello from the hideen one");
            return "Hello all users";
        }

        [HttpGet("admin-user")]
        [Authorize(Roles = "Admin")]
        public string AdminUserAccess()
        {
            return "Hello admin user";
        }

        [HttpGet("customer-user")]
        [Authorize(Roles = "Customer")]
        public string CustomerUSerAccess()
        {

            return "Hello dear customer user";
        }
    }
}
