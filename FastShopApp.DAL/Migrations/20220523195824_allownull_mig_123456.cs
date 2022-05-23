using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class allownull_mig_123456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7497bf3f-d1bd-4247-a893-9a541ff3e55d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4ffe72af-2c7c-463f-af65-b221107c81a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "39d0b619-2a4f-42de-a06e-9e128e2c3997");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "777ce596-f45f-4170-b81e-c351aa7fe120", "AQAAAAEAACcQAAAAEEFJ4pOiW0I2sGWste85A030NVEtHtPlvWj9ylNELd/7nlkZImcRSmSXTey1J3qT0Q==", "f80e04b0-c533-47bb-a54c-b5387729a8cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "807855a3-8361-4c4f-895b-ce347d9eefaa", "AQAAAAEAACcQAAAAEMWQPX91vqWTUXL3F86vJVGoNRBSsyZOqGATQ/6P+CJSv8EJRJRDZQnYIXQQORhY6A==", "737e36c7-6208-4189-a58e-49fc5bac5ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92eecc10-1620-4fda-8f4e-bedd47d75b54", "AQAAAAEAACcQAAAAED+fbytndReCIzePmeovJI7+bhcbKgSYOXsVBJEV2gvuRyo1nr2DZm/o5kYM8DnzdA==", "04c995e1-ebc0-40a4-b751-ef02adc86572" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 22, 58, 23, 885, DateTimeKind.Local).AddTicks(7177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c483b124-778d-4b7a-9da9-65c549a0d914");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "472a298a-c2d5-4067-9921-44c2d4b98f14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "708f8650-562b-42b7-82a0-330c9342182d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72ff47b6-80a0-46e2-949e-617c52d9b0de", "AQAAAAEAACcQAAAAEC2zc9YOsBJqRJXchEkTsMhef2H7VhZ7babK0hQzhQ9hdZGa746N9IFJu6GzWALkWA==", "c20ab792-740e-449a-b86d-82d5be60ea99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fabc1e2c-2778-467e-ba18-599c6bb04a09", "AQAAAAEAACcQAAAAEKVQ5TbTA3F+otnAdkAPDbFOnU4ybO5wQiHemK54gAdB4EiARqKKrnXPpe7O8ve4Bw==", "c308ff35-a886-44b2-9aee-c39cfcb0d742" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a17842d-3549-4215-80c9-ec8643565af2", "AQAAAAEAACcQAAAAEAOX6D7EJVJrd9UnJ+Uf6NQ/zcZ974Cf77h47SxleBgXY/7zIgsL5+uMBnpQSj9PXQ==", "1a855871-12b1-499e-aae2-e96a156c7c73" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 22, 46, 37, 51, DateTimeKind.Local).AddTicks(3732));
        }
    }
}
