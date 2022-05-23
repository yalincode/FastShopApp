using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_123456789 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ProductImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ec7b27db-4ec4-4d66-99c9-2b09a83f63ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ac1632dc-6a8f-47f2-8faf-6b6c28bc5486");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c8ff9dcd-3061-4da6-8ee3-d17c5bf78920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da98953e-7a5e-40a0-afde-aa5507d8e396", "AQAAAAEAACcQAAAAEKcE1iHDaCaKbfNhDzF3Z3tZvAGOlkdS1FQ4EVij+AkzwPtVB+3MdYjYiXui+YnPYQ==", "dab9238b-abdc-473e-95c0-81e0b489c15f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efefbbb4-24a1-4c32-9ad0-e7e3c7563163", "AQAAAAEAACcQAAAAEKReVcA+uq3LeUVwnKUSkG6DxuWNM0AFmHcsz+1wAAGJIRMf/BEdVAz1h6vFaPoW3g==", "0fd29099-0a23-45e0-bc6c-c83e4b7f2c4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67c685c3-1850-4d51-83f4-d9ff12e07225", "AQAAAAEAACcQAAAAEGXEtFslE1tLwdWhkWpIEWWXZTLkqLg5Qpbk7louWGFYVyOpR+gnD030IDZQkgbgmA==", "a0e7e0e8-0b81-4ee8-a942-d06e0979644a" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 22, 38, 21, 11, DateTimeKind.Local).AddTicks(8789));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductImage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889f8124-4141-4b83-8623-4993991627be", "AQAAAAEAACcQAAAAEMicqU4SicA2no3IATFZM5C1USXM8zPCsKYwfSboqiwO79V+e6pqQIYZx+JnZ5YxQg==", "43aaaa0d-0471-4f92-81ee-1242f3b09299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71eb026-e061-45f2-b559-40bb5267dac6", "AQAAAAEAACcQAAAAEJKV59Xwq3q0DrtU9YSJiwBwyKJd6YhauXmbD3+W3J0/YSNaYtaqAt+AnGFA/WIrqQ==", "4893f528-bfa2-4826-a14f-21fd83348a2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fefdd24-2cf0-46d9-9b40-cb8f52d27064", "AQAAAAEAACcQAAAAEPQpAUn7Kz218O/u+Ji6ukZnQ5eRUxeNcD3ZZoGWTammTeKpkYAlLmHkcPtWL7I74A==", "a06d94f5-57ca-488c-a085-1b82746ea183" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 23, 19, 14, 9, 803, DateTimeKind.Local).AddTicks(7933));
        }
    }
}
