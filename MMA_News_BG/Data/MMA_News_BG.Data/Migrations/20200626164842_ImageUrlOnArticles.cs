using Microsoft.EntityFrameworkCore.Migrations;

namespace MMA_News_BG.Data.Migrations
{
    public partial class ImageUrlOnArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Articles",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
