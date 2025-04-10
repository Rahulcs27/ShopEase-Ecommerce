using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopEase.Identity.Migrations
{
    /// <inheritdoc />
    public partial class RefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1a1b - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "aea67de4-ca5f-4ef0-8f07-ac7578eefd9c", "AQAAAAIAAYagAAAAEPe2g2F5m0LNrTj3M0AMm8FZta/90//pHa/pQrAdMB0T5BwXhaLhKeY9e+JF5AXvRQ==", "", null, "bd7de4c2-de79-4a35-ad42-cb971e605afd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1b1b - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "5256d239-45e1-4799-86f9-58cd9b90cbe0", "AQAAAAIAAYagAAAAEC1MwCvR/AMVj5tHy+EXPu+m44cMrrrA0MbPkAlT9ZiWwXX9Ej/2oHYHXyG6p8XgjA==", "", null, "fd3d8758-451c-47bb-b685-31296e3eb70b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1a1b - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82a7bb29-7057-4fc8-aba3-4e9bf744ef7c", "AQAAAAIAAYagAAAAEBdDtj4DYwOtxvZNXPRorrdZYD5/2hLrq+A1bXvJ3Z9zNrDJRhuMqSgKUy4u36tqTw==", "452d1e20-6c48-4d91-ae5e-93de4e7f0fb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776008 - 6086 - 1b1b - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca83946-dae5-4798-8a13-08940c130a60", "AQAAAAIAAYagAAAAEPzjlKjOCYxcjRIXKMlPYGiY+H5zkLY9rFYxMhr2Y3OvOnwSqIm67numklCiNLYtUw==", "7ef4a99f-3be1-4371-948d-40743721ae64" });
        }
    }
}
