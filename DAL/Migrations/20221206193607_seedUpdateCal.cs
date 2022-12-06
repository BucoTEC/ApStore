using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class seedUpdateCal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6edf0952-721e-4961-a1c1-1e67d160707f", new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2834), "AQAAAAEAACcQAAAAEBakGc9D/R6Jr614yiSPlIldQuX1Z0T7OlGmEpm8pW1pOT4qwXM0K624VABHCbtNEA==", "b9c636a5-5cd9-4355-a675-4eefe4ec145d", new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b1c5223c-061e-4a56-95fd-cb8c748337d9", new DateTime(2022, 12, 6, 20, 36, 7, 365, DateTimeKind.Local).AddTicks(5373), new DateTime(2022, 12, 6, 20, 36, 7, 365, DateTimeKind.Local).AddTicks(5377), "AQAAAAEAACcQAAAAEL9mCJWSo1sDCdAJw3xiS1Fybdb7docrD+w81JM54X1Cn+p+BNoQQ+czxU+aii97ww==", "22bbb47e-3438-46ae-947b-3d5a62800ab9", new DateTime(2022, 12, 6, 20, 36, 7, 365, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 366, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 366, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 366, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 366, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2692), 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2715), 194m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2717), 221m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2719), 66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2720), 292m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2723), 293m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2726), 163m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2728), 115m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2729), 124m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2732), 42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2734), 205m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2736), 201m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2738), 258m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2739), 90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2741), 214m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2742), 69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2744), 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2746), 129m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2748), 101m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2750), 31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2751), 253m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2753), 293m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2754), 38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2756), 289m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2757), 107m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2783), 59m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2785), 75m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2787), 140m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2788), 115m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3825), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3849), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3851), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3853), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3854), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3858), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3860), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3861), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3863), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3865), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3868), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3869), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3871), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3872), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3874), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3875), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3877), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3880), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3881), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3883), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3885), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3886), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3888), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3889), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3891), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3893), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3894), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3896), 123.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 6, 20, 31, 5, 128, DateTimeKind.Local).AddTicks(3897), 123.99m });
        }
    }
}
