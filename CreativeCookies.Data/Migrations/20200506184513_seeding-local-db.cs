using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class seedinglocaldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "ImageUrl", "PublicationDate", "Title" },
                values: new object[] { new Guid("9bb82c93-6705-497c-bf84-42876802dfd1"), "First seeded Post's content", "First seeded Post's description", "boy.jpg", new DateTime(2020, 5, 6, 20, 45, 12, 163, DateTimeKind.Local).AddTicks(4680), "First" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "ImageUrl", "PublicationDate", "Title" },
                values: new object[] { new Guid("a874f8e9-35c1-4e2d-8cf3-6cee0db8ddab"), "And this is second post", "The description of second post", "girl.jpg", new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), "Second" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "ImageUrl", "PublicationDate", "Title" },
                values: new object[] { new Guid("04dab9fa-e74b-4e18-aee1-e1308cc16f12"), "And this is the third post", "It's description", "lorem-ipsum.jpg", new DateTime(2020, 5, 9, 8, 45, 12, 167, DateTimeKind.Local).AddTicks(6768), "Third" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("04dab9fa-e74b-4e18-aee1-e1308cc16f12"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9bb82c93-6705-497c-bf84-42876802dfd1"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a874f8e9-35c1-4e2d-8cf3-6cee0db8ddab"));
        }
    }
}
