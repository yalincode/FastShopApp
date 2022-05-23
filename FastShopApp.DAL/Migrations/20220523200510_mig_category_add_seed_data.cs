using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_category_add_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ad5adc0d-d3be-46c7-a190-7c36dcde10bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "21e9ea87-23ea-4932-a30c-374cbb6870b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7e06c4e6-820c-4049-9ac2-5149fe75669e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0722a87-84f2-40e3-a86f-84cf79a9beb4", "AQAAAAEAACcQAAAAEBXnjyjQNg+2YdiA3BG7gB5DNMNqzRlWbOPVaCtxfFerizDpAKaI0at7hPK/bz9HMA==", "8f7a9edc-9b04-478f-b740-124a650ceb17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be9ac932-0158-4b11-ad8e-791d38774263", "AQAAAAEAACcQAAAAENtwme8a5YDyihBEdGvn8vgjNbVYre1yv1PLaY+k1xAHrAJcTwqKwdaCw1gjryd5Hw==", "37dccf6d-3f9e-4428-b6d8-d3f1a6205900" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612c35c6-9372-48ed-842f-e97bb9372234", "AQAAAAEAACcQAAAAELcDe8CwqQCmfiwdBdXpqm6wEwVITbhocf3iCfza4vQ9o41f+aKErCyDihUIhuxibw==", "7351f90c-ec64-455f-8102-03c84424c62e" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 23, 5, 9, 602, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "CreatedDate", "IsDeleted", "ModifiedDate" },
                values: new object[] { 1, "Ev Eşyaları", "Mobilya", null, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
