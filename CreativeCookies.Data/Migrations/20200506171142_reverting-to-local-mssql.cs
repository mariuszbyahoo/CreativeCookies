using Microsoft.EntityFrameworkCore.Migrations;

namespace CreativeCookies.Data.Migrations
{
    public partial class revertingtolocalmssql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Posts");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Posts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
