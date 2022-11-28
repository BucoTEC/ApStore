using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class addisselected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "CartItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3f1d9a92-0e08-43a3-8e99-f50c1b5aed65", new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4432), new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4436), "AQAAAAEAACcQAAAAEI1hnqBWi1ZRFqXfvMQ3n/qbsVEqOfh5mPJAPsNmnr/6A5omZqMTBG+y2tHLRoEfaQ==", "d9e209d0-eae7-4e04-8323-b22b1610a055", new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e28dcaae-7890-4fc7-9168-31578b1bd426", new DateTime(2022, 11, 28, 13, 51, 18, 419, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 11, 28, 13, 51, 18, 419, DateTimeKind.Local).AddTicks(2924), "AQAAAAEAACcQAAAAEEKRsT2qZFKJDXCg4AN6O+iBlECm/MptnTmYUoCPb4ZD9K3maCAxGx53zyv46YdQuQ==", "ef2df148-12eb-4225-b9df-f19d418965a4", new DateTime(2022, 11, 28, 13, 51, 18, 419, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsSelected" },
                values: new object[] { new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9358), true });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsSelected" },
                values: new object[] { new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9369), true });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 417, DateTimeKind.Local).AddTicks(4394));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "a6267c35-d2d8-4f26-8f6e-5180d288323c", new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9332), new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9334), "AQAAAAEAACcQAAAAEEgPeYIKv5K+degy8CIkoeKHg7Lm6N+b0hrxgeFDjl+L7wkgwl50gJ5GGtw/1aQ5GQ==", "15d89782-6534-4928-a801-3461a0311c7d", new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d0986819-bfff-44f6-a85d-dddf7ab56389", new DateTime(2022, 11, 28, 9, 31, 0, 127, DateTimeKind.Local).AddTicks(7321), new DateTime(2022, 11, 28, 9, 31, 0, 127, DateTimeKind.Local).AddTicks(7340), "AQAAAAEAACcQAAAAEOYabPckZPBXOt7waLQADlXH/+m7GK9/qRHB0uf9aANfl5qk19yiBbsBLNpMR+zoPA==", "2a10562a-91d1-4df9-bb9b-919b13d1fd7f", new DateTime(2022, 11, 28, 9, 31, 0, 127, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 129, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9326));
        }
    }
}
