using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosConRoles.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58f11820-31da-4fc5-ba33-daa5f406eef2", "2e17509a-6b32-4997-8eb5-e9a2de43cb68", "Vendedor", "VENDEDOR" },
                    { "d081a319-991c-4b04-82ed-3da787a90751", "559c8bbd-713b-4ae2-9220-aaf3a35617e4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a034fe8-adf6-4756-bce3-b11bc2ca9cb1", 0, "0f1ade28-9737-4c11-8eb6-e2088e9a3f12", "usuarioVendedor@hotmail.com", false, false, null, "USUARIOVENDEDOR@HOTMAIL.COM", "USUARIOVENDEDOR", null, null, false, "7f1e7d87-451a-47ce-b270-6e6a7cd00431", false, "usuarioVendedor" },
                    { "7caf4c2e-0df3-4f44-a650-55c5d2d150dc", 0, "ddad799d-ca2b-4f50-856b-f0315651e13d", "usuarioSinRol@hotmail.com", false, false, null, "USUARIOSINROL@HOTMAIL.COM", "USUARIOSINROL", null, null, false, "de7118c7-7201-4669-b1a6-27965264866a", false, "usuarioSinRol" },
                    { "870eaafc-b0c4-4878-86c0-87cca01d56be", 0, "747f8f0f-f6e9-4608-805e-7bc09a2cd5c9", "usuarioAdmin@hotmail.com", false, false, null, "USUARIOADMIN@HOTMAIL.COM", "USUARIOADMIN", null, null, false, "0387b723-14cc-4295-a712-1752f42850c1", false, "usuarioAdmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "58f11820-31da-4fc5-ba33-daa5f406eef2", "4a034fe8-adf6-4756-bce3-b11bc2ca9cb1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d081a319-991c-4b04-82ed-3da787a90751", "870eaafc-b0c4-4878-86c0-87cca01d56be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "58f11820-31da-4fc5-ba33-daa5f406eef2", "4a034fe8-adf6-4756-bce3-b11bc2ca9cb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d081a319-991c-4b04-82ed-3da787a90751", "870eaafc-b0c4-4878-86c0-87cca01d56be" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7caf4c2e-0df3-4f44-a650-55c5d2d150dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58f11820-31da-4fc5-ba33-daa5f406eef2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d081a319-991c-4b04-82ed-3da787a90751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a034fe8-adf6-4756-bce3-b11bc2ca9cb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870eaafc-b0c4-4878-86c0-87cca01d56be");
        }
    }
}
