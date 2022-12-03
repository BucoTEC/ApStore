using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class cleenUpBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "54f1f787-4812-456e-b6d6-82950a7783be", new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4552), "AQAAAAEAACcQAAAAEPjXDAn6u8/iU5tSxdHJVnmXyPLBL718DkKtCNn/Xwg4CO2LjreVtWMFFlCN29MYzg==", "8b71c72d-8df6-450d-badf-fe2d82474690", new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "352d13fe-9650-4fa5-90c5-e6f5707da237", new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7941), new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7948), "AQAAAAEAACcQAAAAEBLCvkZLU6A/4kualGFK7K5RALca53j7aEoJcwFyZA+dLXtubPrTqMZPS+hOrWZzJQ==", "3a806d62-8acc-41ad-86cf-75acbf8a7e48", new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4545));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
