using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Utils
{
    public interface IJwtHandler
    {

        string GenerateJwtToken(AppUser user);

        DecodedToken DecodeToken(string token);

    }
}
