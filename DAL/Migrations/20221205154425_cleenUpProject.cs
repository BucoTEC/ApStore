using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class cleenUpProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2f364fbc-893f-4e0b-8b3d-2b854c700a1f", new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9308), new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9311), "AQAAAAEAACcQAAAAEIBPxdx9k46FliTddcki+vd+4lBG6OaCZAFrZGwyWPHvT9Ajing2FexaUE+Qhxe2zg==", "655b33bf-c313-48c7-8444-811395b29f20", new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "46d1ab6c-9ecf-409e-8faf-a8b6ed604c1d", new DateTime(2022, 12, 5, 16, 44, 24, 850, DateTimeKind.Local).AddTicks(3807), new DateTime(2022, 12, 5, 16, 44, 24, 850, DateTimeKind.Local).AddTicks(3811), "AQAAAAEAACcQAAAAEETs2JWoWjZi3y5bRFXuiB57eAz6gDEwURthkXyIXQJTqkEUVrtsqgRSlXygXgZXMw==", "99d9dd27-002f-4ec1-9be5-4e4d2686968c", new DateTime(2022, 12, 5, 16, 44, 24, 850, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 851, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 851, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 851, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 851, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9304));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "47b8e3a7-3c02-406a-9d12-b14310a309a7", new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(777), new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(779), "AQAAAAEAACcQAAAAEEnzp+Mj7cxqXOzIdffrd1l3XX819ip8kFdmSbf3BVv46bIpCb6m2kZR0M7eksAs9A==", "551f70ca-edd4-4fec-bf27-41787b88944c", new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f710d1f2-7d23-4fb5-a3a7-a5e639413d51", new DateTime(2022, 12, 4, 12, 41, 8, 450, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 12, 4, 12, 41, 8, 450, DateTimeKind.Local).AddTicks(3813), "AQAAAAEAACcQAAAAEJXDGeZxP7I26TX3MlO0fhqxJxkY/TEqoMhx1FxQJ6djbLnFQLdUSStVKEX8xNd4lQ==", "1b38bcb1-982f-4e59-9ead-923046312931", new DateTime(2022, 12, 4, 12, 41, 8, 450, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 451, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 451, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 451, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 451, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 4, 12, 41, 8, 449, DateTimeKind.Local).AddTicks(772));
        }
    }
}
