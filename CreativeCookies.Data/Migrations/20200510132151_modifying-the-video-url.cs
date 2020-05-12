using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class modifyingthevideourl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "VideoUrl",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "VideoID",
                table: "Posts",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "VideoUrl",
                table: "Posts",
                type: "nvarchar(max)",
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
    }
}
