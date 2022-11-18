using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class productseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6463), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6517), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedAt", "DeletedAt", "Description", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6648), null, "Single-Vision", 0, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6647) },
                    { 2, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6651), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6653), null, "Bifocals", 0, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6652) },
                    { 3, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6658), null, "Trifocals", 0, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6657) },
                    { 4, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6662), null, "Progressives", 0, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6661) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AvailbleAmount", "CategoryId", "CreatedAt", "DeletedAt", "Description", "Image", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 9, 1, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6676), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6679), "Glasses one description", null, "Glasses one", 123.99m, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6678) },
                    { 2, 7, 2, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6687), "Glasses two description", null, "Glasses two", 333.99m, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6686) },
                    { 3, 4, 3, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6692), "Glasses three description", null, "Glasses three", 423.99m, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6691) },
                    { 4, 12, 4, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6694), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6697), "Glasses fore description", null, "Glasses fore", 523.99m, new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6696) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8017), new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8067), new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8070), new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8073), new DateTime(2022, 11, 18, 13, 11, 59, 848, DateTimeKind.Local).AddTicks(8071) });
        }
    }
}
