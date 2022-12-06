using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class seedUpdateCl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d5c26496-cd32-4193-a987-8b0056593b63", new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3955), new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3958), "AQAAAAEAACcQAAAAENhReEPIUQVGXR26MKkhFFPnkt6yKi3+7ygfzeZhrOw13weDwh8sCedonj4/95pjwQ==", "796ed5f7-5623-4567-95be-06e744cb04ab", new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6f44c261-6d9c-4c81-8521-df022b737812", new DateTime(2022, 12, 6, 20, 31, 5, 129, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 12, 6, 20, 31, 5, 129, DateTimeKind.Local).AddTicks(8786), "AQAAAAEAACcQAAAAEMhQvIoQflgAYG7rMl9v64GZFR+f+Dyn4HYuaVyz4eh5eoDn9jwo9aI2j676hB8nGw==", "9a9d7f9d-5781-4535-be19-0d9195845178", new DateTime(2022, 12, 6, 20, 31, 5, 129, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 131, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 131, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 131, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 131, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3825), "Glasses 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3849), "Glasses 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3851), "Glasses 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3853), "Glasses 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3854), "Glasses 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3858), "Glasses 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3860), "Glasses 7" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3861), "Glasses 8" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3863), "Glasses 9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3865), "Glasses 10" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3868), "Glasses 11" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3869), "Glasses 12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3871), "Glasses 13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3872), "Glasses 14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3874), "Glasses 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3875), "Glasses 16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3877), "Glasses 17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3880), "Glasses 18" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3881), "Glasses 19" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3883), "Glasses 20" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3885), "Glasses 21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3886), "Glasses 22" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3888), "Glasses 23" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3889), "Glasses 24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3891), "Glasses 25" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3893), "Glasses 26" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3894), "Glasses 27" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3896), "Glasses 28" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3897), "Glasses 29" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6433), "Glasses one1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6452), "Glasses one2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6455), "Glasses one3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6456), "Glasses one4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6457), "Glasses one5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6460), "Glasses one6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6462), "Glasses one7" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6464), "Glasses one8" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6465), "Glasses one9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6467), "Glasses one10" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6469), "Glasses one11" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6471), "Glasses one12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6472), "Glasses one13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6473), "Glasses one14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6475), "Glasses one15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6476), "Glasses one16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6477), "Glasses one17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6480), "Glasses one18" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6519), "Glasses one19" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6521), "Glasses one20" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6523), "Glasses one21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6524), "Glasses one22" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6525), "Glasses one23" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6527), "Glasses one24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6528), "Glasses one25" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6530), "Glasses one26" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6531), "Glasses one27" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6532), "Glasses one28" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Name" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 23, 42, 68, DateTimeKind.Local).AddTicks(6533), "Glasses one29" });
        }
    }
}
