using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CartItem : EntityTimeStamp
    {
        public int CartItemId { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; } = null!;

    }
}
