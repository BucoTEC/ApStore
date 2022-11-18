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

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public String AppUserId { get; set; } = null!;

        public AppUser AppUser { get; set; } = null!;

    }
}
