using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.GenericRepo
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Create(object data);

        Task<T> Update(int id, object data);

        Task<T> Delete(int id);

    }
}
