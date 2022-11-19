using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "86d7f143-a766-4d4d-be42-086743a25f60", new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9912), "AQAAAAEAACcQAAAAEDM77yFuICgoFO+YzoGo6uabY4l7gsqBPF4GEkZC+aaOm376xotC0JyQpissontrIw==", "4e52936b-07a8-4ff9-9035-f919cef405b2", new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dbdffe7d-cf5c-4eee-96cc-7592a5f820ae", new DateTime(2022, 11, 19, 15, 48, 51, 448, DateTimeKind.Local).AddTicks(6418), new DateTime(2022, 11, 19, 15, 48, 51, 448, DateTimeKind.Local).AddTicks(6422), "AQAAAAEAACcQAAAAEIlXWwvvTiGbNX5z6oYyCpwWI+7ZxPnuHI1xGNgottSqjB4GsKetN+60VDVcSfdb3A==", "ed9df3bc-46b8-467c-9770-c6fc96701af3", new DateTime(2022, 11, 19, 15, 48, 51, 448, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 450, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 19, 15, 48, 51, 446, DateTimeKind.Local).AddTicks(9903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
