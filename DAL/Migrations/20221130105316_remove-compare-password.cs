using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class removecomparepassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 384, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 384, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "df26dd3e-531f-4996-bd40-f583216335c9", new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(189), new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(192), "AQAAAAEAACcQAAAAEImxbLm6DDein9PLRH7vcO7rDnZdFRFAO7LtN9ulfqF/cfNmJ01xgHwLY4Cp1MmhaQ==", "da1778f4-6567-4f42-a66d-ac444ee4c67b", new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "501eac3a-ced3-41a8-a53b-ade96180c25b", new DateTime(2022, 11, 30, 11, 53, 16, 386, DateTimeKind.Local).AddTicks(8044), new DateTime(2022, 11, 30, 11, 53, 16, 386, DateTimeKind.Local).AddTicks(8092), "AQAAAAEAACcQAAAAEGtpsTy9FVatUGwtEkGn8IUL2Oz6VYwy213KGSgdyI43K68A0NDzx1YQLSeQXCh1VQ==", "389b657e-9bbf-4419-8b13-728c3f5f17d5", new DateTime(2022, 11, 30, 11, 53, 16, 386, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 388, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 30, 11, 53, 16, 385, DateTimeKind.Local).AddTicks(162));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9358));

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
                column: "CreatedAt",
                value: new DateTime(2022, 11, 28, 13, 51, 18, 420, DateTimeKind.Local).AddTicks(9369));

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
    }
}
