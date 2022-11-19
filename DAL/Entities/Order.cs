using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order : EntityTimeStamp
    {
        public int OrderId { get; set; }
        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string ReceiverName { get; set; } = null!;


        public bool Delivered { get; set; }

        public string AppUserId { get; set; } = null!;
        public AppUser AppUser { get; set; } = null!;


        public List<OrderItem> OrderItems { get; set; } = null!;
    }
}
