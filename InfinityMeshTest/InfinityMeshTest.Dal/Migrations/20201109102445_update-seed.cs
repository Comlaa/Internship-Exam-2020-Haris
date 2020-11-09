using Microsoft.EntityFrameworkCore.Migrations;

namespace InfinityMeshTest.Dal.Migrations
{
    public partial class updateseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ViewProfile",
                value: "https://localhost:44357/api/user/getUserById?userId=1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ViewProfile",
                value: "https://localhost:44357/api/user/getUserById?userId=2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ViewProfile",
                value: "https://localhost:44357/api/user/getUserById?userId=3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ViewProfile",
                value: "https://localhost:44329/api/user/GetUserById?UserId=1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ViewProfile",
                value: "https://localhost:44329/api/user/GetUserById?UserId=2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ViewProfile",
                value: "https://localhost:44329/api/user/GetUserById?UserId=3");
        }
    }
}
