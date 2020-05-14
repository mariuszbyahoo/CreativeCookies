using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class restructuringvideosnimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "youtubeVideoUrl",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "videoUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("dabcc37d-ab49-4091-83f2-87bdad1c1e44"), "First seeded Post's content", "First seeded Post's description", new DateTime(2020, 5, 14, 16, 32, 32, 497, DateTimeKind.Local).AddTicks(9883), "First", "assets/images/first.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("d45eb84e-73c5-4ce9-a6bc-d0f0dcc80bec"), "And this is second post", "The description of second post", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), "Second", "assets/images/second.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("e7b5dd9c-0f1a-4a10-b6b6-87a7e7013590"), "And this is the third post", "It's description", new DateTime(2020, 5, 17, 4, 32, 32, 503, DateTimeKind.Local).AddTicks(7683), "Third", "assets/images/third.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d45eb84e-73c5-4ce9-a6bc-d0f0dcc80bec"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("dabcc37d-ab49-4091-83f2-87bdad1c1e44"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e7b5dd9c-0f1a-4a10-b6b6-87a7e7013590"));

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "videoUrl",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "youtubeVideoTrailerUrl",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "youtubeVideoUrl",
                table: "Posts",
                type: "nvarchar(max)",
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
    }
}
