using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class cartItemSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_AspNetUsers_AppUserId1",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_AppUserId1",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168a2f66-5e90-464f-9f42-06ce1d166ce5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9122bb88-74ba-4cec-8d12-60799684a4b4");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "CartItems");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CartItems",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppUserRoleId", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "02174cf0-9412-4cfe-afbf-59f706d72cf6", 0, 2, "aaea1fea-2533-4563-a6e7-cef06acf6582", new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2995), "adnan@gmail.com", false, "Adnan", true, "Bucalovic", false, null, null, null, "AQAAAAEAACcQAAAAEGvAVBVQUnzct9lk9Uuq3fpwJsot2CUVGQ5cs6lvTHtNTBPtZFhW0nOsXfQRqITzfw==", null, false, "1210168b-b815-4794-b652-806438aa9f17", false, new DateTime(2022, 11, 18, 23, 15, 45, 533, DateTimeKind.Local).AddTicks(2994), "adnan@gmail.com" },
                    { "341743f0-asd2-42de-afbf-59kmkkmk72cf6", 0, 1, "72a6a598-533f-48ed-bffd-19153ede0aae", new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5778), "advan@gmail.com", false, "Advan", true, "Bucalovic", false, null, null, null, "AQAAAAEAACcQAAAAEDQ/BuAaiLw9hSZT8mT97n7bcojWdPHVwUoszHxJq8GizEsZjIqY7/c1RGYT+/da1w==", null, false, "f4c4c280-e167-474b-a6c5-b4495fb4c02d", false, new DateTime(2022, 11, 18, 23, 15, 45, 534, DateTimeKind.Local).AddTicks(5777), "advan@gmail.com" }
                });

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

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartItemId", "AppUserId", "CreatedAt", "DeletedAt", "Price", "ProductId", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "341743f0-asd2-42de-afbf-59kmkkmk72cf6", new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7598), null, 123.99m, 1, 2, null },
                    { 2, "341743f0-asd2-42de-afbf-59kmkkmk72cf6", new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7601), null, 333.99m, 2, 4, null },
                    { 3, "341743f0-asd2-42de-afbf-59kmkkmk72cf6", new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7602), null, 423.99m, 3, 1, null },
                    { 4, "341743f0-asd2-42de-afbf-59kmkkmk72cf6", new DateTime(2022, 11, 18, 23, 15, 45, 535, DateTimeKind.Local).AddTicks(7604), null, 523.99m, 4, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_AppUserId",
                table: "CartItems",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_AspNetUsers_AppUserId",
                table: "CartItems",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_AspNetUsers_AppUserId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_AppUserId",
                table: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6");

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartItems");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "CartItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AppUserRoleId", "ConcurrencyStamp", "CreatedAt", "DeletedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "168a2f66-5e90-464f-9f42-06ce1d166ce5", 0, 1, "3150a3d7-9853-495f-9b57-2c5277cea72f", new DateTime(2022, 11, 18, 22, 56, 41, 264, DateTimeKind.Local).AddTicks(2517), new DateTime(2022, 11, 18, 22, 56, 41, 264, DateTimeKind.Local).AddTicks(2520), "advan@gmail.com", false, "Advan", true, "Bucalovic", false, null, null, null, "AQAAAAEAACcQAAAAEOI4YrwN6lQJHL38R5Soh+MwE6adCEj8VO6nZ2ayiwpW4Mu5oHjEPaAIMYpofRirCA==", null, false, "fac1855e-92de-43f8-8f3f-f317eecc8b03", false, new DateTime(2022, 11, 18, 22, 56, 41, 264, DateTimeKind.Local).AddTicks(2519), "advan@gmail.com" },
                    { "9122bb88-74ba-4cec-8d12-60799684a4b4", 0, 2, "1f9ae183-c94d-48a2-aafc-2297da20e456", new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(483), new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(485), "adnan@gmail.com", false, "Adnan", true, "Bucalovic", false, null, null, null, "AQAAAAEAACcQAAAAELjKoRCDWamazcoxXs86iJ4OHfrWZ5ZPv0sxzbzkBsUMKXuOEWpBJv2uZN5KES8ONA==", null, false, "c8ca4864-7097-4f22-8427-17c654723593", false, new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(484), "adnan@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 18, 22, 56, 41, 263, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_AppUserId1",
                table: "CartItems",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_AspNetUsers_AppUserId1",
                table: "CartItems",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
