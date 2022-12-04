using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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
            // seed roles
            modelBuilder.Entity<AppUserRole>().HasData(
                   new AppUserRole() { AppUserRoleId = 1, Name = "Customer" },
                   new AppUserRole() { AppUserRoleId = 2, Name = "Admin" }
            );

            // seed categories
            modelBuilder.Entity<Category>().HasData(
                   new Category() { CategoryId = 1, Name = "Single-Vision" },
                   new Category() { CategoryId = 2, Name = "Bifocals" },
                   new Category() { CategoryId = 3, Name = "Trifocals" },
                   new Category() { CategoryId = 4, Name = "Progressives" }

            );

            // seed products
            modelBuilder.Entity<Product>().HasData(
                   new Product() { ProductId = 1, Description = "Glasses one description", AvailableAmount = 9, CategoryId = 1, Price = 123.99M, Name = "Glasses one", ShippingPrice = 9.99M },
                   new Product() { ProductId = 2, Description = "Glasses two description", AvailableAmount = 7, CategoryId = 2, Price = 333.99M, Name = "Glasses two", ShippingPrice = 9.99M },
                   new Product() { ProductId = 3, Description = "Glasses three description", AvailableAmount = 4, CategoryId = 3, Price = 423.99M, Name = "Glasses three", ShippingPrice = 9.99M },
                   new Product() { ProductId = 4, Description = "Glasses fore description", AvailableAmount = 12, CategoryId = 4, Price = 523.99M, Name = "Glasses fore", ShippingPrice = 9.99M }

            );

            string ADMIN_ID = "02174cf0-9412-4cfe-afbf-59f706d72cf6";
            string CUSTOMER_ID = "341743f0-asd2-42de-afbf-59kmkkmk72cf6";
            // seed admin
            var appUser = new AppUser
            {
                Id = ADMIN_ID,
                Email = "adnan@gmail.com",
                FirstName = "Adnan",
                LastName = "Bucalovic",
                UserName = "adnan@gmail.com",
                NormalizedEmail = "ADNAN@GMAIL.COM",
                NormalizedUserName = "ADNAN@GMAIL.COM",
                AppUserRoleId = 2
            };

            //set user password
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "0401");

            //seed admin user
            modelBuilder.Entity<AppUser>().HasData(appUser);

            // seed customer
            var appCustomer = new AppUser
            {
                Id = CUSTOMER_ID,
                Email = "advan@gmail.com",
                FirstName = "Advan",
                LastName = "Bucalovic",
                UserName = "advan@gmail.com",
                NormalizedEmail = "ADVAN@GMAIL.COM",
                NormalizedUserName = "ADVAN@GMAIL.COM",
                AppUserRoleId = 1
            };

            //set user password
            appCustomer.PasswordHash = ph.HashPassword(appCustomer, "0309");

            //seed customer user
            modelBuilder.Entity<AppUser>().HasData(appCustomer);

            // cart item seed
            modelBuilder.Entity<CartItem>().HasData(
                   new CartItem() { CartItemId = 1, Quantity = 2, ProductId = 1, AppUserId = CUSTOMER_ID, IsSelected = true },
                   new CartItem() { CartItemId = 2, Quantity = 4, ProductId = 2, AppUserId = CUSTOMER_ID, IsSelected = false },
                   new CartItem() { CartItemId = 3, Quantity = 1, ProductId = 3, AppUserId = CUSTOMER_ID, IsSelected = true },
                   new CartItem() { CartItemId = 4, Quantity = 2, ProductId = 4, AppUserId = CUSTOMER_ID, IsSelected = false }

            );

            // order item seed
            // modelBuilder.Entity<OrderItem>().HasData(
            //        new OrderItem() { OrderItemId = 1, Name = "Glasses one", Quantity = 1, ProductId = 1, ShippingPrice = 9.99M, Price = 123.99M, OrderId = 1 },
            //        new OrderItem() { OrderItemId = 2, Name = "Glasses two", Quantity = 3, ProductId = 2, ShippingPrice = 9.99M, Price = 333.99M, OrderId = 1 },
            //        new OrderItem() { OrderItemId = 3, Name = "Glasses three", Quantity = 1, ProductId = 3, ShippingPrice = 9.99M, Price = 423.99M, OrderId = 2 },
            //        new OrderItem() { OrderItemId = 4, Name = "Glasses four", Quantity = 2, ProductId = 4, ShippingPrice = 9.99M, Price = 523.99M, OrderId = 2 }

            // );

            //order seed
            // modelBuilder.Entity<Order>().HasData(
            //        new Order() { OrderId = 1, Address = "Kemala Kapetanovica 13.", Country = "BiH", City = "Sarajevo", PhoneNumber = "062656323", ReceiverName = "Advan Bucalovic", AppUserId = CUSTOMER_ID },
            //        new Order() { OrderId = 2, Address = "Kemala Kapetanovica 13.", Country = "BiH", City = "Sarajevo", PhoneNumber = "062656323", ReceiverName = "Advan Bucalovic", AppUserId = CUSTOMER_ID }

            // );


        }
    }
}
