using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class addingaccessenum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "VideoAccess",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoUrl" },
                values: new object[] { new Guid("c93cf79d-552c-4083-9059-2ae9755e36f4"), "First seeded Post's content", "First seeded Post's description", new DateTime(2020, 5, 10, 15, 1, 25, 683, DateTimeKind.Local).AddTicks(2663), "First", 1, "https://youtu.be/kmXUd6VLdj8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoUrl" },
                values: new object[] { new Guid("854a4222-bd34-4342-80f7-42779f5b3879"), "And this is second post", "The description of second post", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), "Second", 0, "https://youtu.be/kmXUd6VLdj8" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Description", "PublicationDate", "Title", "VideoAccess", "VideoUrl" },
                values: new object[] { new Guid("248fa551-8493-4bbf-9e09-2dc86ec7be62"), "And this is the third post", "It's description", new DateTime(2020, 5, 13, 3, 1, 25, 687, DateTimeKind.Local).AddTicks(5322), "Third", 0, "https://youtu.be/kmXUd6VLdj8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("248fa551-8493-4bbf-9e09-2dc86ec7be62"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("854a4222-bd34-4342-80f7-42779f5b3879"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c93cf79d-552c-4083-9059-2ae9755e36f4"));

            migrationBuilder.DropColumn(
                name: "VideoAccess",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
