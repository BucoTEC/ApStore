using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace DAL.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int AppUserRoleId { get; set; }

        public AppUserRole AppUserRole { get; set; } = null!;

    }
}
