using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();

    }
}
