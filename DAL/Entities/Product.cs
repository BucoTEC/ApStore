using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product : EntityTimeStamp
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? Image { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal ShippingPrice { get; set; }

        public int AvailbleAmount { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;
    }
}
