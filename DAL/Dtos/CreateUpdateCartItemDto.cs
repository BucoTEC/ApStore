using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CreateUpdateCartItemDto
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public string AppUserId { get; set; } = null!;

    }
}
