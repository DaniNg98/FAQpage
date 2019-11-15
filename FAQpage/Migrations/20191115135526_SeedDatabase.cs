using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQpage.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SporsmalerOgSvar",
                columns: new[] { "Id", "Sporsmal", "Svar" },
                values: new object[] { 2, "Hvordan kjøper jeg periodebillett?", "Du kan også kjøpe periodebillett på vår nettside" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
