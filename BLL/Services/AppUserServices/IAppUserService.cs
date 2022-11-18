using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Services.AppUserServices
{
    public interface IAppUserService
    {
        Task<List<AppUser>> GetAppUsers();

    }
}
