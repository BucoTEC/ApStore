using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class usersC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "88f81bbd-7c7a-4cb3-a82b-9c3b3c9f90bb", new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(336), new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(339), "AQAAAAEAACcQAAAAEFYeKhSdiigJtfad1CY6Yhvz5p9T927WnUNoH4mHEumh+cmbcZSRVv1jhE6zs66DQA==", "b9b784d7-bf53-4c46-bba5-194ddd2277aa", new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6c84cda3-9544-498b-85f1-e1fa84017873", new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9624), "AQAAAAEAACcQAAAAEKZZte0qaRtb9q49VWOcoP5ir5gfNFgDSPsDbewtZLUY4Y+g65C04AvAOEbNNBA5cw==", "b0395f7a-9116-4143-accb-53d4c1be5175", new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(329));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
