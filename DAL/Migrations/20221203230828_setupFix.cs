using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class setupFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2e05b019-e6f9-4330-8704-9a168744d5e9", new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(735), "AQAAAAEAACcQAAAAEDv8qRmPzfSCucM0U+A3Mgcnb+jFSCR6vEjOdiL+kUjHXstb3vnrskC6epHhYEreqw==", "dfb0a790-3049-4500-9319-b3634978346c", new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8d43fc5f-8833-40ca-9f64-53d61f59ad5b", new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4255), "AQAAAAEAACcQAAAAELsYkY5oiBFOX+oDlEsCl2dLUPKSB+wmV44d1EwDodgkL/vrfGdm1Fb8q/rVRuxNUw==", "94150338-6260-48e4-9059-abcb06257656", new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(727));
        }
    }
}
