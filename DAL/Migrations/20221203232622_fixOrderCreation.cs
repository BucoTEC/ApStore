using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fixOrderCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "35def285-64cc-482d-b3df-f8105ecd539b", new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5919), "AQAAAAEAACcQAAAAEH0DtHEg4OWTEVFupVbPYNFdKGUdVyPZNMK+StnhYSl/wLWuDttRp1CFnZq9NI338w==", "ff805230-9d41-4606-bec7-f05a61c25133", new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b0ae7aab-203e-450f-aa43-41db1fb5d4ee", new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9426), new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9429), "AQAAAAEAACcQAAAAEBn/oWF65/yxr2si6JEhar8IS5Z7OxAR4nUGUlizQLKN764sZ+YVIsM6BwMaw4KNGg==", "eb0c11b5-2e06-4a5e-a41b-5bc1ba7f59ae", new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5909));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2beee132-5ab0-440c-a043-d34789f1c2fb", new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6189), new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6191), "AQAAAAEAACcQAAAAEP2C7tvhkkY6Kx9lMRjmjDabCXwdd+MNVQMWaF8T78PFdyw4p71m3K58GQp5uFlZ+A==", "ac5b2a3d-2895-4afc-ab2c-c7380aac4df2", new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "68b95b1e-82fe-4673-a038-1eeffe57cc62", new DateTime(2022, 12, 4, 0, 8, 27, 681, DateTimeKind.Local).AddTicks(9327), new DateTime(2022, 12, 4, 0, 8, 27, 681, DateTimeKind.Local).AddTicks(9331), "AQAAAAEAACcQAAAAEGJMzru2rlGXwImSSLPemDVs+tJuUEzYRSTO1ZIRfVdxNNoYUuL0Nyz+UHugXbjT8A==", "69800296-4de7-4981-97a5-d1a65af562ee", new DateTime(2022, 12, 4, 0, 8, 27, 681, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 683, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 0, 8, 27, 680, DateTimeKind.Local).AddTicks(6184));
        }
    }
}
