using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OrderItem : EntityTimeStamp
    {
        public int OrderItemId { get; set; }

        public int ProductId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; } = null!;

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

    }
}
