using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class modifyingpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "VideoAccess",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "youtubeVideoTrailerUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "youtubeVideoTrailerUrl", "youtubeVideoUrl" },
                values: new object[] { new Guid("a2b94a50-f897-4d01-9298-279744272de2"), "First seeded Post's content", "First seeded Post's description", new DateTime(2020, 5, 11, 13, 47, 39, 380, DateTimeKind.Local).AddTicks(7189), "First", "kmXUd6VLdj8", "TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "youtubeVideoTrailerUrl", "youtubeVideoUrl" },
                values: new object[] { new Guid("2fa86d6d-31ae-4b16-b917-a770118935be"), "And this is second post", "The description of second post", new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), "Second", "kmXUd6VLdj8", "TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "youtubeVideoTrailerUrl", "youtubeVideoUrl" },
                values: new object[] { new Guid("0a1f2935-ad13-4827-81b5-cd965207e820"), "And this is the third post", "It's description", new DateTime(2020, 5, 14, 1, 47, 39, 385, DateTimeKind.Local).AddTicks(4683), "Third", "kmXUd6VLdj8", "TGJiUNtOReI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0a1f2935-ad13-4827-81b5-cd965207e820"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("2fa86d6d-31ae-4b16-b917-a770118935be"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a2b94a50-f897-4d01-9298-279744272de2"));

            migrationBuilder.DropColumn(
                name: "youtubeVideoTrailerUrl",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "VideoAccess",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
