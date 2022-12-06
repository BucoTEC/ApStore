using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class seedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8f80514c-6991-4c5c-a90a-336381059a9f", new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6573), new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6576), "AQAAAAEAACcQAAAAELYA1H/yWn7CpJHJ9cWgbNIwfFqXdwIKIESsYEWEKcrBMf50ZY6XZv7ftF/XpT4Tmg==", "3c201282-5214-49f6-9f13-f8b5bac7e53a", new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "52dd2695-77d1-4397-ba5f-bb3026a56b94", new DateTime(2022, 12, 6, 20, 23, 42, 69, DateTimeKind.Local).AddTicks(8654), new DateTime(2022, 12, 6, 20, 23, 42, 69, DateTimeKind.Local).AddTicks(8657), "AQAAAAEAACcQAAAAECuyJQ/yAAxu8+t/qirzR9v4HIJqlc5FABercgFg2fEC6gUpSv2b5JnsyrzOOb9mAw==", "71a3f965-0437-4c7f-807e-91f18cee227a", new DateTime(2022, 12, 6, 20, 23, 42, 69, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 71, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 71, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 71, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 71, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "AvailableAmount", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6433), "Glasses one1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "AvailableAmount", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6452), "Glasses one description", "Glasses one2", 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6455), "Glasses one description", "Glasses one3", 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "AvailableAmount", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 5, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6456), "Glasses one description", "Glasses one4", 123.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailableAmount", "CategoryId", "CreatedAt", "DeletedAt", "Description", "Image", "Name", "Price", "ShippingPrice", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, 6, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6457), null, "Glasses one description", null, "Glasses one5", 123.99m, 9.99m, null },
                    { 6, 7, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6460), null, "Glasses one description", null, "Glasses one6", 123.99m, 9.99m, null },
                    { 7, 8, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6462), null, "Glasses one description", null, "Glasses one7", 123.99m, 9.99m, null },
                    { 8, 9, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6464), null, "Glasses one description", null, "Glasses one8", 123.99m, 9.99m, null },
                    { 9, 10, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6465), null, "Glasses one description", null, "Glasses one9", 123.99m, 9.99m, null },
                    { 10, 11, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6467), null, "Glasses one description", null, "Glasses one10", 123.99m, 9.99m, null },
                    { 11, 12, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6469), null, "Glasses one description", null, "Glasses one11", 123.99m, 9.99m, null },
                    { 12, 13, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6471), null, "Glasses one description", null, "Glasses one12", 123.99m, 9.99m, null },
                    { 13, 14, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6472), null, "Glasses one description", null, "Glasses one13", 123.99m, 9.99m, null },
                    { 14, 15, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6473), null, "Glasses one description", null, "Glasses one14", 123.99m, 9.99m, null },
                    { 15, 16, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6475), null, "Glasses one description", null, "Glasses one15", 123.99m, 9.99m, null },
                    { 16, 17, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6476), null, "Glasses one description", null, "Glasses one16", 123.99m, 9.99m, null },
                    { 17, 18, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6477), null, "Glasses one description", null, "Glasses one17", 123.99m, 9.99m, null },
                    { 18, 19, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6480), null, "Glasses one description", null, "Glasses one18", 123.99m, 9.99m, null },
                    { 19, 20, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6519), null, "Glasses one description", null, "Glasses one19", 123.99m, 9.99m, null },
                    { 20, 21, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6521), null, "Glasses one description", null, "Glasses one20", 123.99m, 9.99m, null },
                    { 21, 22, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6523), null, "Glasses one description", null, "Glasses one21", 123.99m, 9.99m, null },
                    { 22, 23, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6524), null, "Glasses one description", null, "Glasses one22", 123.99m, 9.99m, null },
                    { 23, 24, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6525), null, "Glasses one description", null, "Glasses one23", 123.99m, 9.99m, null },
                    { 24, 25, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6527), null, "Glasses one description", null, "Glasses one24", 123.99m, 9.99m, null },
                    { 25, 26, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6528), null, "Glasses one description", null, "Glasses one25", 123.99m, 9.99m, null },
                    { 26, 27, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6530), null, "Glasses one description", null, "Glasses one26", 123.99m, 9.99m, null },
                    { 27, 28, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6531), null, "Glasses one description", null, "Glasses one27", 123.99m, 9.99m, null },
                    { 28, 29, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6532), null, "Glasses one description", null, "Glasses one28", 123.99m, 9.99m, null },
                    { 29, 30, 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6533), null, "Glasses one description", null, "Glasses one29", 123.99m, 9.99m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

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
                columns: new[] { "AvailableAmount", "CreatedAt", "Name" },
                values: new object[] { 9, new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9291), "Glasses one" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "AvailableAmount", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 7, 2, new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9297), "Glasses two description", "Glasses two", 333.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9299), "Glasses three description", "Glasses three", 423.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "AvailableAmount", "CategoryId", "CreatedAt", "Description", "Name", "Price" },
                values: new object[] { 12, 4, new DateTime(2022, 12, 5, 16, 44, 24, 848, DateTimeKind.Local).AddTicks(9304), "Glasses fore description", "Glasses fore", 523.99m });
        }
    }
}
