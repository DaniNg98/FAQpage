using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQpage.Migrations
{
    public partial class SeedDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NegativRating",
                table: "SporsmalerOgSvar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositivRating",
                table: "SporsmalerOgSvar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NegativRating",
                table: "SporsmalerOgSvar");

            migrationBuilder.DropColumn(
                name: "PositivRating",
                table: "SporsmalerOgSvar");
        }
    }
}
