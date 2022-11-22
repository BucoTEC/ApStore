using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<T> Create(object data)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var res = await _context.Set<T>().FindAsync(id);

            if (res != null)
            {
                return res;
            }
            throw new Exception("No match with this id");
        }

        public Task<T> Update(int id, object data)
        {
            throw new NotImplementedException();
        }
    }
}
