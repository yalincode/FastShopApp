using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastShopApp.DAL.Migrations
{
    public partial class mid_seed_data_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "76bc4312-48c3-4965-b1df-44acf107ebb1", "SysAdmin", null },
                    { 2, "e2c41593-f52e-4c6f-962a-40967b1e9664", "Admin", null },
                    { 3, "c01adcda-bb26-4582-8e8f-793f40cda2e1", "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandAbout", "BrandName", "CreatedDate", "IsDeleted", "ModifiedDate" },
                values: new object[] { 1, "ingilizce öğrenme platformu", "Konuşarak Öğren", new DateTime(2022, 5, 23, 16, 7, 54, 395, DateTimeKind.Local).AddTicks(3786), false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BrandId", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, 1, "05cca6ac-7840-4558-9e36-fc79077d25ee", "yukselyal@gmail.com", true, null, false, null, "Yalın", null, null, "AQAAAAEAACcQAAAAELa4M9HT1Lr0xtqqYPhMA4vgKlnTO5nEjC+YIFlpqruws7Z6sRCC+tlAa0pCdU7vXw==", "5555555555", true, "56035d68-f769-4ae7-80f4-5f491f1c7b60", "Sonat", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BrandId", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2, 0, 1, "943621aa-ee36-4233-8480-58375d5f3d2e", "baran@gmail.com", true, null, false, null, "Baran", null, null, "AQAAAAEAACcQAAAAEFL4EsYFAxjE7OPhvgNb8duYZ67KF3lsD9lJO8KpLIMzKo7gfgzm0nSibzuD4B66xg==", "6666666666", true, "d18bf3ed-af00-4c94-9e96-d6f077722ef6", "kaya", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BrandId", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, 1, "6487d8c4-2f76-4bdd-824e-8269a12c3b2c", "musteri@gmail.com", true, null, false, null, "Müşteri", null, null, "AQAAAAEAACcQAAAAEGcER6PVh92xgsuHsd9cJbvQIXBV0Etf+5hPru8jTLRnl+mkHwfXLwe3Xbh1GCWInQ==", "7777777777", true, "c278cb3c-3112-45f6-a171-a522405944c3", "halk", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
