using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class DbSeeder
    {
        private readonly ModelBuilder modelBuilder;

        public DbSeeder(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<AppUserRole>().HasData(
                   new AppUserRole() { AppUserRoleId = 1, Name = "Customer" },
                   new AppUserRole() { AppUserRoleId = 2, Name = "Admin" }
            );
        }
    }
}
