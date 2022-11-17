using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class AppUserRole : EntityTimeStamp
    {
        public int AppUserRoleId { get; set; }

        public string Name { get; set; } = null!;

    }
}
