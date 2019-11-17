using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQpage.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendtInnSpms",
                columns: table => new
                {
                    SId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Tema = table.Column<string>(nullable: true),
                    Sporsmal = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendtInnSpms", x => x.SId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendtInnSpms");
        }
    }
}
