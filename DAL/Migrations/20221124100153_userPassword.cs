using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class userPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "11b92886-bde1-4132-97c6-d17fc2ea2ef9", new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7501), new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7504), "AQAAAAEAACcQAAAAEHmfkRW3SjJuP+S102erbbQ21rj80zV+sOh3kuKcTCKAr/171MQQa4L0OpHmGHLdfA==", "973ce5a8-1d01-427c-8e39-e66eacb109d8", new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dca8d9ed-aad4-4343-bfa3-89bee8f85763", new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(225), new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(228), "AQAAAAEAACcQAAAAEMvp0RtiePR8NZG3caw12c2WbJWRsj38URc7Ov/rNrwHFTuU8iwCfr2nO2NvTnTiEA==", "cc357fbd-eb7d-4499-8959-9c10cd1dd645", new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 405, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7496));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1f7e55c8-fe1d-4e66-9286-c2469544cdb1", new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7191), new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7194), "AQAAAAEAACcQAAAAEA+3Kx65jY0+gVmoPkzV/+QZIKaXNGk5yvH8/9Z6WkZKeGF1UB3Fp+63tbRS0T7SvQ==", "c9460274-2183-43a1-808c-eb96bd93b2d6", new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "34238adb-406e-4953-ae13-9072527ace28", new DateTime(2022, 11, 23, 22, 40, 37, 888, DateTimeKind.Local).AddTicks(4448), new DateTime(2022, 11, 23, 22, 40, 37, 888, DateTimeKind.Local).AddTicks(4453), "AQAAAAEAACcQAAAAEENdACkwmgLlIyZa8SETLuVe9elWOZHGU8j0KZl/leWiaNRK+vIACaV+Sij0sT/rGA==", "4947f627-b7a0-485e-9c4a-3de31a2211af", new DateTime(2022, 11, 23, 22, 40, 37, 888, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 890, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 40, 37, 886, DateTimeKind.Local).AddTicks(7185));
        }
    }
}
