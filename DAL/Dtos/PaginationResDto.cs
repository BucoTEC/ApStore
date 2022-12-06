using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Dtos
{
    public class PaginationResDto
    {
        public int NumOfPages { get; set; }

        public List<Product>? Data { get; set; }
    }
}
