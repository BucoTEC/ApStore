using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BLL.Utils
{
    public class JwtHandler : IJwtHandler
    {
        private readonly IConfiguration _configuration;



        public JwtHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateJwtToken(AppUser user)
        {
            var authClaims = new List<Claim>
            {
                new Claim("UserId", user.Id),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, user.AppUserRoleId == 2 ? "Admin" : "Customer")

            };
            var authSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(300),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public object DecodeToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();

            var decodedToken = handler.ReadJwtToken(token);

            var userId = decodedToken.Claims.First(c => c.Type == "UserId").Value;
            var userEmail = decodedToken.Claims.First(c => c.Type == "Name").Value;
            var userRole = decodedToken.Claims.First(c => c.Type == "Role").Value;



            return new
            {
                userId,
                userEmail,
                userRole
            };
        }
    }
}
