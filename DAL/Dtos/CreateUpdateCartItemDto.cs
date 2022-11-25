using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CreateUpdateCartItemDto
    {
        [Required]
        [Range(1, 99)]
        public int Quantity { get; set; }

        [Required]
        public int ProductId { get; set; }


    }
}
