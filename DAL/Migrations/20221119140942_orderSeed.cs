using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class orderSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingPrice",
                table: "OrderItems",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Address", "AppUserId", "City", "Country", "CreatedAt", "DeletedAt", "Delivered", "PhoneNumber", "ReceiverName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Kemala Kapetanovica 13.", "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "Sarajevo", "BiH", new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5649), null, true, "062656323", "Advan Bucalovic", null },
                    { 2, "Kemala Kapetanovica 13.", "341743f0-asd2-42de-afbf-59kmkkmk72cf6", "Sarajevo", "BiH", new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5652), null, false, "062656323", "Advan Bucalovic", null }
                });

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

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "CreatedAt", "DeletedAt", "Name", "OrderId", "Price", "ProductId", "Quantity", "ShippingPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5613), null, "Glasses one", 1, 123.99m, 1, 1, 9.99m, null },
                    { 2, new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5619), null, "Glasses two", 1, 333.99m, 2, 3, 9.99m, null },
                    { 3, new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5622), null, "Glasses three", 2, 423.99m, 3, 1, 9.99m, null },
                    { 4, new DateTime(2022, 11, 19, 15, 9, 42, 75, DateTimeKind.Local).AddTicks(5624), null, "Glasses four", 2, 523.99m, 4, 2, 9.99m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ShippingPrice",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "aaea1fea-2533-4563-a6e7-cef06acf6582", new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2995), "AQAAAAEAACcQAAAAEGvAVBVQUnzct9lk9Uuq3fpwJsot2CUVGQ5cs6lvTHtNTBPtZFhW0nOsXfQRqITzfw==", "1210168b-b815-4794-b652-806438aa9f17", new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "72a6a598-533f-48ed-bffd-19153ede0aae", new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5778), "AQAAAAEAACcQAAAAEDQ/BuAaiLw9hSZT8mT97n7bcojWdPHVwUoszHxJq8GizEsZjIqY7/c1RGYT+/da1w==", "f4c4c280-e167-474b-a6c5-b4495fb4c02d", new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId1",
                table: "Orders",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId1",
                table: "Orders",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
