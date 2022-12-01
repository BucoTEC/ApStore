using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fixProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailbleAmount",
                table: "Products",
                newName: "AvailableAmount");

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2d43bb78-9e67-402b-8c63-70c5bd1b9ffc", new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9356), "AQAAAAEAACcQAAAAECFz+N3swreBs0c61Aq/YUXTqG33EX4N/mEG9z7ts/v1EqaUa9Ts6aAIx4vllXSe5w==", "8538e226-a215-4940-b1ad-9a7959385031", new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "4a87ad22-354d-47d9-ba91-792675ba5b03", new DateTime(2022, 12, 1, 20, 34, 20, 958, DateTimeKind.Local).AddTicks(5573), new DateTime(2022, 12, 1, 20, 34, 20, 958, DateTimeKind.Local).AddTicks(5580), "AQAAAAEAACcQAAAAEKpHHK+Ma4sNUNIiSvnA+ElCu9lrUIRTUMbyIXa77DnyxN1ud8kko7qKgJykoc477g==", "5ffffec6-7b13-4c88-8ee8-68d85923e7c7", new DateTime(2022, 12, 1, 20, 34, 20, 958, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 961, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 1, 20, 34, 20, 955, DateTimeKind.Local).AddTicks(9342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableAmount",
                table: "Products",
                newName: "AvailbleAmount");

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
    }
}
