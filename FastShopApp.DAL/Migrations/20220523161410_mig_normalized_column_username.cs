using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_normalized_column_username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bf71ad69-f193-497a-9c7d-d346a2251411");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "983ebde8-5c74-4bff-8cc2-e6e8c6153cb4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5689104a-9da0-4ce7-91ba-839bb1ae660f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889f8124-4141-4b83-8623-4993991627be", "YUKSELYAL", "AQAAAAEAACcQAAAAEMicqU4SicA2no3IATFZM5C1USXM8zPCsKYwfSboqiwO79V+e6pqQIYZx+JnZ5YxQg==", "43aaaa0d-0471-4f92-81ee-1242f3b09299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71eb026-e061-45f2-b559-40bb5267dac6", "BARAN66", "AQAAAAEAACcQAAAAEJKV59Xwq3q0DrtU9YSJiwBwyKJd6YhauXmbD3+W3J0/YSNaYtaqAt+AnGFA/WIrqQ==", "4893f528-bfa2-4826-a14f-21fd83348a2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fefdd24-2cf0-46d9-9b40-cb8f52d27064", "MUSTERI77", "AQAAAAEAACcQAAAAEPQpAUn7Kz218O/u+Ji6ukZnQ5eRUxeNcD3ZZoGWTammTeKpkYAlLmHkcPtWL7I74A==", "a06d94f5-57ca-488c-a085-1b82746ea183" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 19, 14, 9, 803, DateTimeKind.Local).AddTicks(7933));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc4c0df-6e07-494a-876a-2d4722d50dd3", null, "AQAAAAEAACcQAAAAELCfwwJySyXi1bjH6/EL4DRvWY/HQktzM8xdJMfxjzAINo1L6+/PZN2SwykTPNz60Q==", "dcb32d4c-4cde-492b-8e5f-07750a277440" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0940b34a-1980-4d0a-942e-a4cd81250cf9", null, "AQAAAAEAACcQAAAAECMPjG76+52lTJtA4sDig4kdCnQ3zdNidhUUUTP1gRUQslu43Kh9BRhqt3E7Z07d1Q==", "dbf628e1-19e2-4670-be8b-febcd73817ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99aea760-319d-46c8-944e-7b09f59bf652", null, "AQAAAAEAACcQAAAAEH8Uk9yE1jyesBiuBlUm7RZBwLV6lHPh1/uI8CPLbvBOyGpBUdGfBZTjqMo6+wWEQA==", "c65f4d55-ed2e-4b95-8ecc-e812926134b1" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 17, 39, 32, 722, DateTimeKind.Local).AddTicks(2869));
        }
    }
}
