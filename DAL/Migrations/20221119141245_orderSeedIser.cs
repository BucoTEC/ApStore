using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class orderSeedIser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7a9eddc4-a8a8-4561-9599-f24d14e7726b", new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4561), new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4563), "AQAAAAEAACcQAAAAED0vmgKdHZNBbmphgmGTINvEX7+FUgV+0PXp5BN7v8gVcyNv/4Nprq9N4OBv1wriew==", "561f15f4-f2c1-4286-b273-a13657f7bdec", new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2fd354cf-c4a5-4507-80cf-c102c91a5f8a", new DateTime(2022, 11, 19, 15, 12, 45, 509, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 11, 19, 15, 12, 45, 509, DateTimeKind.Local).AddTicks(9118), "AQAAAAEAACcQAAAAEHi+8SDihtBxFZmH1RRXzV0wQcQmeqJUF1BFUOhSdoQ17zyap/jSH35MzmUoUrWXlg==", "524f6a42-4212-460c-bbe1-bbe0f589d4a3", new DateTime(2022, 11, 19, 15, 12, 45, 509, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 511, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 12, 45, 508, DateTimeKind.Local).AddTicks(4538));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "95a420f6-4748-4220-926f-3fec95e22910", new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4977), "AQAAAAEAACcQAAAAEATTU2Kq7MUA4ah4SRPG4hp5kdrDj/lhGT3AezxjyN/JoSmOQ4ry7wRIoA43SEDRcw==", "7a8f4dca-013c-44e5-baf5-531df6e32cf6", new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "49f699f6-dec6-4388-8c60-27f1f9081e7c", new DateTime(2022, 11, 19, 15, 9, 42, 74, DateTimeKind.Local).AddTicks(931), new DateTime(2022, 11, 19, 15, 9, 42, 74, DateTimeKind.Local).AddTicks(957), "AQAAAAEAACcQAAAAEC0yg9M5KierTi+I6rb9SeP5aWoQwUwrW/BKP7TeKoTfwqM4U0eXlPPxhSUtiJ4elw==", "4012fb9a-db27-422a-97a2-4bd52638d518", new DateTime(2022, 11, 19, 15, 9, 42, 74, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 9, 42, 72, DateTimeKind.Local).AddTicks(4969));
        }
    }
}
