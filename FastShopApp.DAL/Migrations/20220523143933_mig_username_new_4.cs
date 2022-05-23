using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_username_new_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3a2ea80f-a37f-48f2-9de0-8e94d243c7a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6930ff6b-9142-4005-977e-49710b29bc25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ba7a7bce-0e2a-4f0c-9ab4-e13789a0c9ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "adc4c0df-6e07-494a-876a-2d4722d50dd3", "AQAAAAEAACcQAAAAELCfwwJySyXi1bjH6/EL4DRvWY/HQktzM8xdJMfxjzAINo1L6+/PZN2SwykTPNz60Q==", "dcb32d4c-4cde-492b-8e5f-07750a277440", "yukselyal" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0940b34a-1980-4d0a-942e-a4cd81250cf9", "AQAAAAEAACcQAAAAECMPjG76+52lTJtA4sDig4kdCnQ3zdNidhUUUTP1gRUQslu43Kh9BRhqt3E7Z07d1Q==", "dbf628e1-19e2-4670-be8b-febcd73817ec", "baran66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "99aea760-319d-46c8-944e-7b09f59bf652", "AQAAAAEAACcQAAAAEH8Uk9yE1jyesBiuBlUm7RZBwLV6lHPh1/uI8CPLbvBOyGpBUdGfBZTjqMo6+wWEQA==", "c65f4d55-ed2e-4b95-8ecc-e812926134b1", "musteri77" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 17, 39, 32, 722, DateTimeKind.Local).AddTicks(2869));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cd8d96f1-a0a6-4fde-bc76-786f7bf50d59", "AQAAAAEAACcQAAAAEEljcSQjiyJRRMkPUej68KsEGmeQ/uGJXyaOLzLSgFhqhPLY9zDGYMHUxs80RmgzYw==", "e0147193-8c60-4919-b24e-294a8238ea04", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a2563961-7a17-470f-8106-8f7f7c520047", "AQAAAAEAACcQAAAAEK+/b7EyKNp4ejy8UZ3n8QplCG3BMtQ7RrTacnoNMzuaNEWA8NsoUE4HIEROT9xc6Q==", "3778db1a-1131-4da9-ac7c-7b85eda122d7", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9f53b381-825b-45d7-8291-5c93974f766c", "AQAAAAEAACcQAAAAEFo2MIrhm+gsBw6F0RPDUVqwuMiylMkc04GkBdjZGoZ2+v5VRE0L7L9N209J2xBo2A==", "d321b293-59f7-41bc-b0b5-49e3965e2448", null });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 17, 6, 7, 897, DateTimeKind.Local).AddTicks(8307));
        }
    }
}
