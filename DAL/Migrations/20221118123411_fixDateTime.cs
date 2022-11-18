using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fixDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7762), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7944), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7947), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7949), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(7950), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(8031), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(8038), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(8040), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 34, 11, 70, DateTimeKind.Local).AddTicks(8042), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6648), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6651), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6653), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6656), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6658), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6662), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6676), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6679), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6687), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6692), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6694), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 11, 18, 13, 32, 27, 433, DateTimeKind.Local).AddTicks(6696) });
        }
    }
}
