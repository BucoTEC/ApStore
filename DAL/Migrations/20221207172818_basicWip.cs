using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class basicWip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductWips",
                columns: table => new
                {
                    ProductWipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWips", x => x.ProductWipId);
                });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bccf27c4-6634-48e1-a054-596837a5f7c9", new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1564), new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1567), "AQAAAAEAACcQAAAAEOCyDCAhvHMDIl3zDJpQ9P89rBntvcymdq9NagtjeVtwAVMwcd0tiZ8i2INiWoHDWg==", "32c49d85-76e9-4cfd-a8f6-7f012cd444ee", new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "fb9ea712-6f53-4c06-9bef-e96b7ae8ee37", new DateTime(2022, 12, 7, 18, 28, 18, 425, DateTimeKind.Local).AddTicks(7879), new DateTime(2022, 12, 7, 18, 28, 18, 425, DateTimeKind.Local).AddTicks(7883), "AQAAAAEAACcQAAAAEOfsmL6qay4uM/hrfvdLMbohbX7IxkB7gZwkfirB49LiZ82jL9BXEPVjQZRB32m4dA==", "4dd8ff7c-f940-41e6-a047-031c629fd487", new DateTime(2022, 12, 7, 18, 28, 18, 425, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 427, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 427, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 427, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 427, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1407), 60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1430), 88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1432), 184m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1435), 120m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1437), 125m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1468), 122m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1471), 54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1474), 247m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1476), 294m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1479), 94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1482), 274m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1484), 143m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1487), 75m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1489), 66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1491), 286m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1493), 292m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1496), 106m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1499), 60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1502), 296m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1504), 265m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1506), 139m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1508), 199m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1510), 29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1512), 197m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1515), 118m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1517), 173m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 3, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1519), 98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 1, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1521), 36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 7, 18, 28, 18, 424, DateTimeKind.Local).AddTicks(1523), 59m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductWips");

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2734), 205m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2739), 90m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2748), 101m });

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
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 2, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2751), 253m });

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
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2754), 38m });

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
                columns: new[] { "CategoryId", "CreatedAt", "Price" },
                values: new object[] { 4, new DateTime(2022, 12, 6, 20, 36, 7, 364, DateTimeKind.Local).AddTicks(2757), 107m });

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
    }
}
