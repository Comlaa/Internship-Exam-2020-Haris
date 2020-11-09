using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfinityMeshTest.Dal.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ViewProfileId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ViewProfileId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ViewProfileId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "ViewProfile",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ViewProfile" },
                values: new object[] { new DateTime(2020, 11, 9, 10, 42, 0, 0, DateTimeKind.Utc), "https://localhost:44329/api/user/GetUserById?UserId=1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewProfile",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ViewProfileId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 10, 41, 0, 0, DateTimeKind.Utc));

            migrationBuilder.CreateIndex(
                name: "IX_Users_ViewProfileId",
                table: "Users",
                column: "ViewProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ViewProfileId",
                table: "Users",
                column: "ViewProfileId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
