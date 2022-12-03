using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class cleenUpBasee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2e05b019-e6f9-4330-8704-9a168744d5e9", new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(735), "AQAAAAEAACcQAAAAEDv8qRmPzfSCucM0U+A3Mgcnb+jFSCR6vEjOdiL+kUjHXstb3vnrskC6epHhYEreqw==", "dfb0a790-3049-4500-9319-b3634978346c", new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8d43fc5f-8833-40ca-9f64-53d61f59ad5b", new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4246), new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4255), "AQAAAAEAACcQAAAAELsYkY5oiBFOX+oDlEsCl2dLUPKSB+wmV44d1EwDodgkL/vrfGdm1Fb8q/rVRuxNUw==", "94150338-6260-48e4-9059-abcb06257656", new DateTime(2022, 12, 3, 23, 57, 21, 48, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 50, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 57, 21, 47, DateTimeKind.Local).AddTicks(727));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "54f1f787-4812-456e-b6d6-82950a7783be", new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4552), "AQAAAAEAACcQAAAAEPjXDAn6u8/iU5tSxdHJVnmXyPLBL718DkKtCNn/Xwg4CO2LjreVtWMFFlCN29MYzg==", "8b71c72d-8df6-450d-badf-fe2d82474690", new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "352d13fe-9650-4fa5-90c5-e6f5707da237", new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7941), new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7948), "AQAAAAEAACcQAAAAEBLCvkZLU6A/4kualGFK7K5RALca53j7aEoJcwFyZA+dLXtubPrTqMZPS+hOrWZzJQ==", "3a806d62-8acc-41ad-86cf-75acbf8a7e48", new DateTime(2022, 12, 3, 23, 42, 48, 160, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 161, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 3, 23, 42, 48, 159, DateTimeKind.Local).AddTicks(4545));
        }
    }
}
