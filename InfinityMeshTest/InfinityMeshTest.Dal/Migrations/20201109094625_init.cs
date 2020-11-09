using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfinityMeshTest.Dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ViewProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_ViewProfileId",
                        column: x => x.ViewProfileId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PublishedDateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Birthdate", "CreatedAt", "Email", "ModifiedAt", "Name", "ViewProfileId" },
                values: new object[] { 1, 21, new DateTime(1999, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 9, 10, 41, 0, 0, DateTimeKind.Utc), "haris.mlaco@edu.fit.ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haris Mlaco", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Birthdate", "CreatedAt", "Email", "ModifiedAt", "Name", "ViewProfileId" },
                values: new object[] { 2, 31, new DateTime(1989, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 9, 10, 42, 0, 0, DateTimeKind.Utc), "admirmujkic@infinitymesh.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admir Mujkic", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Birthdate", "CreatedAt", "Email", "ModifiedAt", "Name", "ViewProfileId" },
                values: new object[] { 3, 21, new DateTime(1999, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 9, 10, 43, 0, 0, DateTimeKind.Utc), "johndoe@doeCompany.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", null });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ViewProfileId",
                table: "Users",
                column: "ViewProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
