using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Dtos
{
    public class UserDataDto
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public int AppUserRoleId { get; set; }

        public string Email { get; set; } = null!;

        public AppUserRole AppUserRole { get; set; } = null!;

        public List<CartItem>? CartItems { get; set; }

        public List<Order>? Orders { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public DateTime DeletedAt { get; set; } = DateTime.Now;
    }
}
