using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("0d36497c-21ca-46e8-abff-ddbeb03a7998"), "First seeded Post's content", "First seeded Post's description", new DateTime(2021, 2, 13, 21, 47, 51, 665, DateTimeKind.Local).AddTicks(9780), "First", "assets/images/first.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("9b2f8056-bcd6-4ad6-912f-8a7aa290878f"), "And this is second post", "The description of second post", new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Local), "Second", "assets/images/second.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "imageUrl", "videoUrl" },
                values: new object[] { new Guid("25b9b333-e6ab-4d8b-a152-0498f43882de"), "And this is the third post", "It's description", new DateTime(2021, 2, 16, 9, 47, 51, 667, DateTimeKind.Local).AddTicks(5891), "Third", "assets/images/third.jpg", "https://www.youtube.com/embed/TGJiUNtOReI" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0d36497c-21ca-46e8-abff-ddbeb03a7998"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("25b9b333-e6ab-4d8b-a152-0498f43882de"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9b2f8056-bcd6-4ad6-912f-8a7aa290878f"));

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
    }
}
