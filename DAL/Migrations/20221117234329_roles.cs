using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserRoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    AppUserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => x.AppUserRoleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppUserRoleId",
                table: "AspNetUsers",
                column: "AppUserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AppUserRole_AppUserRoleId",
                table: "AspNetUsers",
                column: "AppUserRoleId",
                principalTable: "AppUserRole",
                principalColumn: "AppUserRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AppUserRole_AppUserRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppUserRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppUserRoleId",
                table: "AspNetUsers");
        }
    }
}
