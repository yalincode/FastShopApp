using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mig_allownull_123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
