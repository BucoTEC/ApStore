using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.CategoryRepo
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategories();

    }
}
