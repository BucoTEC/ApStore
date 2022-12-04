using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string AppUserId { get; set; } = null!;

        public AppUser AppUser { get; set; } = null!;

        public Boolean IsSelected { get; set; } = false;

    }
}
