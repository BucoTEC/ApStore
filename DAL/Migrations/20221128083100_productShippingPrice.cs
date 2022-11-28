using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class productShippingPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivered",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingPrice",
                table: "Products",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

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
                columns: new[] { "CreatedAt", "ShippingPrice" },
                values: new object[] { new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9315), 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShippingPrice" },
                values: new object[] { new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9321), 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShippingPrice" },
                values: new object[] { new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9324), 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShippingPrice" },
                values: new object[] { new DateTime(2022, 11, 28, 9, 31, 0, 125, DateTimeKind.Local).AddTicks(9326), 9.99m });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ShippingPrice",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "Delivered",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "846bdf40-c9e6-4031-908d-44a8eba34032", new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(981), new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(984), "AQAAAAEAACcQAAAAEDW2GKknGm/a/CCN7VsieuXz8SGozbn+vLyB4eSgVFcAiTchIeiJQgMM1/gyMOvcJg==", "4ed90ac5-dc79-4977-927f-1291353711e3", new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dd8ccb15-f267-4ccd-af78-b66a9f3514cb", new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(516), "AQAAAAEAACcQAAAAELvONCwqJv74dVgkaQIuP91qfCjR6QdhfGpQ0kT9/z3d5bohEDb7tmIo/kz9/64Yjg==", "96ac8292-fafb-439a-9427-d34210f68a3f", new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Delivered" },
                values: new object[] { new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8571), true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(974));
        }
    }
}
