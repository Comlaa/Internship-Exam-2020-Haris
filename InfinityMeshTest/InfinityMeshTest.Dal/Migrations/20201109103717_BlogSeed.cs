using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfinityMeshTest.Dal.Migrations
{
    public partial class BlogSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedAt", "ModifiedAt", "PublishedDateTime", "Summary", "Title", "UserId" },
                values: new object[] { 1, "This is content", new DateTime(2020, 11, 9, 11, 36, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 9, 11, 37, 0, 0, DateTimeKind.Utc), "This is summary", "This is title", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
