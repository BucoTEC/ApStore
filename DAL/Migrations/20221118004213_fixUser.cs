using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fixUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7510), new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7545), new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7548), new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7549), new DateTime(2022, 11, 18, 1, 42, 13, 186, DateTimeKind.Local).AddTicks(7549) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6691), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6819), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6821), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6820) });
        }
    }
}
