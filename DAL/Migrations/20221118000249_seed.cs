using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AppUserRole_AppUserRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole");

            migrationBuilder.RenameTable(
                name: "AppUserRole",
                newName: "AppUserRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles",
                column: "AppUserRoleId");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "AppUserRoleId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6691), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6816), "Customer", new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "AppUserRoleId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6819), new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6821), "Admin", new DateTime(2022, 11, 18, 1, 2, 48, 917, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AppUserRoles_AppUserRoleId",
                table: "AspNetUsers",
                column: "AppUserRoleId",
                principalTable: "AppUserRoles",
                principalColumn: "AppUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AppUserRoles_AppUserRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "AppUserRoles",
                newName: "AppUserRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRole",
                table: "AppUserRole",
                column: "AppUserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AppUserRole_AppUserRoleId",
                table: "AspNetUsers",
                column: "AppUserRoleId",
                principalTable: "AppUserRole",
                principalColumn: "AppUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
