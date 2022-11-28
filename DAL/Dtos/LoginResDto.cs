using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class LoginResDto
    {
        public string Token { get; set; } = null!;

        public int Role { get; set; }
    }
}
