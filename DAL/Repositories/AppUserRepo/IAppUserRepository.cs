using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.AppUserRepo
{
    public interface IAppUserRepository
    {
        Task<List<AppUser>> GetAppUsers();
    }
}
