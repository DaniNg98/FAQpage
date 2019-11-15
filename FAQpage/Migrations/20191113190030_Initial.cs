using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQpage.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SporsmalerOgSvar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sporsmal = table.Column<string>(nullable: true),
                    Svar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporsmalerOgSvar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SporsmalerOgSvar",
                columns: new[] { "Id", "Sporsmal", "Svar" },
                values: new object[] { 1, "Hvor kan jeg kjøpe billetter?", "Du kan kjøpe billetter fra vår nettside eller så kan kjøpe billett fra billettautomaten som er lokalisert på togstasjonene" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SporsmalerOgSvar");
        }
    }
}
