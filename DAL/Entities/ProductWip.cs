using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductWip
    {
        public int ProductWipId { get; set; }

        public string EditorId { get; set; } = null!;

        public int ProductId { get; set; }
    }
}
