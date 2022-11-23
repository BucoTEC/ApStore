using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class updateCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartItems");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CartItems",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumn: "AppUserRoleId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "88f81bbd-7c7a-4cb3-a82b-9c3b3c9f90bb", new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(336), new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(339), "AQAAAAEAACcQAAAAEFYeKhSdiigJtfad1CY6Yhvz5p9T927WnUNoH4mHEumh+cmbcZSRVv1jhE6zs66DQA==", "b9b784d7-bf53-4c46-bba5-194ddd2277aa", new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "DeletedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6c84cda3-9544-498b-85f1-e1fa84017873", new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9624), "AQAAAAEAACcQAAAAEKZZte0qaRtb9q49VWOcoP5ir5gfNFgDSPsDbewtZLUY4Y+g65C04AvAOEbNNBA5cw==", "b0395f7a-9116-4143-accb-53d4c1be5175", new DateTime(2022, 11, 23, 22, 33, 34, 565, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5882), 123.99m });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5887), 333.99m });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5889), 423.99m });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "CartItemId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5891), 523.99m });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 567, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 11, 23, 22, 33, 34, 564, DateTimeKind.Local).AddTicks(329));
        }
    }
}
