using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CreateOrderDto
    {
        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string ReceiverName { get; set; } = null!;


        // public bool Delivered { get; set; }

    }
}
