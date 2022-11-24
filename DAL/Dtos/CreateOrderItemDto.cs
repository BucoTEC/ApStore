using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CreateOrderItemDto
    {

        public int ProductId { get; set; }


        public decimal Price { get; set; }

        public decimal ShippingPrice { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; } = null!;

        public int OrderId { get; set; }
    }
}
