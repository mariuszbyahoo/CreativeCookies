using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class turningvideoidtovideourl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("476858c8-26bc-4634-999c-c08655abe230"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e9a03907-6bc4-49d0-821b-2da38de6b85c"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f6974ef2-511f-471d-966b-d93d8c947f79"));

            migrationBuilder.DropColumn(
                name: "VideoID",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "youtubeVideoUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "youtubeVideoUrl" },
                values: new object[] { new Guid("cbc85ab1-b760-408d-8fbc-cf2916e775b6"), "First seeded Post's content", "First seeded Post's description", new DateTime(2020, 5, 10, 22, 43, 24, 533, DateTimeKind.Local).AddTicks(4320), "First", 1, "TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "youtubeVideoUrl" },
                values: new object[] { new Guid("08c3bd00-0ce7-46e7-b7f7-7065354e279f"), "And this is second post", "The description of second post", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Second", 0, "kmXUd6VLdj8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "youtubeVideoUrl" },
                values: new object[] { new Guid("013b4539-2d89-4611-8440-6a059025d3c9"), "And this is the third post", "It's description", new DateTime(2020, 5, 13, 10, 43, 24, 538, DateTimeKind.Local).AddTicks(2375), "Third", 0, "kmXUd6VLdj8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("013b4539-2d89-4611-8440-6a059025d3c9"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("08c3bd00-0ce7-46e7-b7f7-7065354e279f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("cbc85ab1-b760-408d-8fbc-cf2916e775b6"));

            migrationBuilder.DropColumn(
                name: "youtubeVideoUrl",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "VideoID",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoID" },
                values: new object[] { new Guid("476858c8-26bc-4634-999c-c08655abe230"), "First seeded Post's content", "First seeded Post's description", new DateTime(2020, 5, 10, 15, 21, 51, 209, DateTimeKind.Local).AddTicks(6128), "First", 1, "TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoID" },
                values: new object[] { new Guid("f6974ef2-511f-471d-966b-d93d8c947f79"), "And this is second post", "The description of second post", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Second", 0, "kmXUd6VLdj8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoID" },
                values: new object[] { new Guid("e9a03907-6bc4-49d0-821b-2da38de6b85c"), "And this is the third post", "It's description", new DateTime(2020, 5, 13, 3, 21, 51, 213, DateTimeKind.Local).AddTicks(9431), "Third", 0, "kmXUd6VLdj8" });
        }
    }
}
