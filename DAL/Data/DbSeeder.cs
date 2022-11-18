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

            modelBuilder.Entity<Category>().HasData(
                   new Category() { CategoryId = 1, Name = "Single-Vision" },
                   new Category() { CategoryId = 2, Name = "Bifocals" },
                   new Category() { CategoryId = 3, Name = "Trifocals" },
                   new Category() { CategoryId = 4, Name = "Progressives" }

            );

            modelBuilder.Entity<Product>().HasData(
                   new Product() { ProductId = 1, Description = "Glasses one description", AvailbleAmount = 9, CategoryId = 1, Price = 123.99M, Name = "Glasses one" },
                   new Product() { ProductId = 2, Description = "Glasses two description", AvailbleAmount = 7, CategoryId = 2, Price = 333.99M, Name = "Glasses two" },
                   new Product() { ProductId = 3, Description = "Glasses three description", AvailbleAmount = 4, CategoryId = 3, Price = 423.99M, Name = "Glasses three" },
                   new Product() { ProductId = 4, Description = "Glasses fore description", AvailbleAmount = 12, CategoryId = 4, Price = 523.99M, Name = "Glasses fore" }

            );
        }
    }
}
