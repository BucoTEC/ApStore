using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class fixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "846bdf40-c9e6-4031-908d-44a8eba34032", new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(981), new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(984), "ADNAN@GMAIL.COM", "ADNAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDW2GKknGm/a/CCN7VsieuXz8SGozbn+vLyB4eSgVFcAiTchIeiJQgMM1/gyMOvcJg==", "4ed90ac5-dc79-4977-927f-1291353711e3", new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dd8ccb15-f267-4ccd-af78-b66a9f3514cb", new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(516), "ADVAN@GMAIL.COM", "ADVAN@GMAIL.COM", "AQAAAAEAACcQAAAAELvONCwqJv74dVgkaQIuP91qfCjR6QdhfGpQ0kT9/z3d5bohEDb7tmIo/kz9/64Yjg==", "96ac8292-fafb-439a-9427-d34210f68a3f", new DateTime(2022, 11, 24, 13, 11, 54, 945, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 946, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 24, 13, 11, 54, 943, DateTimeKind.Local).AddTicks(974));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "11b92886-bde1-4132-97c6-d17fc2ea2ef9", new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7501), new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7504), null, null, "AQAAAAEAACcQAAAAEHmfkRW3SjJuP+S102erbbQ21rj80zV+sOh3kuKcTCKAr/171MQQa4L0OpHmGHLdfA==", "973ce5a8-1d01-427c-8e39-e66eacb109d8", new DateTime(2022, 11, 24, 11, 1, 53, 402, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dca8d9ed-aad4-4343-bfa3-89bee8f85763", new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(225), new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(228), null, null, "AQAAAAEAACcQAAAAEMvp0RtiePR8NZG3caw12c2WbJWRsj38URc7Ov/rNrwHFTuU8iwCfr2nO2NvTnTiEA==", "cc357fbd-eb7d-4499-8959-9c10cd1dd645", new DateTime(2022, 11, 24, 11, 1, 53, 404, DateTimeKind.Local).AddTicks(227) });

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
    }
}
