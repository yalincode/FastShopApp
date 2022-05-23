using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_lockout_end : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "95c300d5-6713-49c2-b243-b1476eec67a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "68b43dac-1073-4ef1-b01d-50d5cc02b3b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "19a4dd4c-37d0-4080-94fd-97cd11687900");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd8d96f1-a0a6-4fde-bc76-786f7bf50d59", true, "AQAAAAEAACcQAAAAEEljcSQjiyJRRMkPUej68KsEGmeQ/uGJXyaOLzLSgFhqhPLY9zDGYMHUxs80RmgzYw==", "e0147193-8c60-4919-b24e-294a8238ea04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2563961-7a17-470f-8106-8f7f7c520047", true, "AQAAAAEAACcQAAAAEK+/b7EyKNp4ejy8UZ3n8QplCG3BMtQ7RrTacnoNMzuaNEWA8NsoUE4HIEROT9xc6Q==", "3778db1a-1131-4da9-ac7c-7b85eda122d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f53b381-825b-45d7-8291-5c93974f766c", true, "AQAAAAEAACcQAAAAEFo2MIrhm+gsBw6F0RPDUVqwuMiylMkc04GkBdjZGoZ2+v5VRE0L7L9N209J2xBo2A==", "d321b293-59f7-41bc-b0b5-49e3965e2448" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 17, 6, 7, 897, DateTimeKind.Local).AddTicks(8307));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "76bc4312-48c3-4965-b1df-44acf107ebb1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e2c41593-f52e-4c6f-962a-40967b1e9664");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c01adcda-bb26-4582-8e8f-793f40cda2e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05cca6ac-7840-4558-9e36-fc79077d25ee", false, "AQAAAAEAACcQAAAAELa4M9HT1Lr0xtqqYPhMA4vgKlnTO5nEjC+YIFlpqruws7Z6sRCC+tlAa0pCdU7vXw==", "56035d68-f769-4ae7-80f4-5f491f1c7b60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943621aa-ee36-4233-8480-58375d5f3d2e", false, "AQAAAAEAACcQAAAAEFL4EsYFAxjE7OPhvgNb8duYZ67KF3lsD9lJO8KpLIMzKo7gfgzm0nSibzuD4B66xg==", "d18bf3ed-af00-4c94-9e96-d6f077722ef6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6487d8c4-2f76-4bdd-824e-8269a12c3b2c", false, "AQAAAAEAACcQAAAAEGcER6PVh92xgsuHsd9cJbvQIXBV0Etf+5hPru8jTLRnl+mkHwfXLwe3Xbh1GCWInQ==", "c278cb3c-3112-45f6-a171-a522405944c3" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 16, 7, 54, 395, DateTimeKind.Local).AddTicks(3786));
        }
    }
}
