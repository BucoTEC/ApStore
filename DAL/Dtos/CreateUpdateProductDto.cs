using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CreateUpdateProductDto
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(5)]
        public string Description { get; set; } = null!;

        public string? Image { get; set; }


        [Required]
        [Range(0, Double.PositiveInfinity)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, Double.PositiveInfinity)]
        public decimal ShippingPrice { get; set; }

        [Required]
        [Range(1, Double.MaxValue)]
        public int AvailableAmount { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
