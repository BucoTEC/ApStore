using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class modelRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AppUserRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(922), new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(964), new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(971), new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(973), new DateTime(2022, 11, 18, 9, 57, 45, 428, DateTimeKind.Local).AddTicks(972) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AppUserRoles");

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
    }
}
