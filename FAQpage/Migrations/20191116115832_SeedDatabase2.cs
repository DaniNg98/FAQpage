using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQpage.Migrations
{
    public partial class SeedDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tema",
                table: "SporsmalerOgSvar",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Sporsmal", "Svar", "Tema" },
                values: new object[] { "Trenger jeg en bruker for å bestille billett?", "Nei. Du trenger ikke å opprette en bruker for å bestille en billett på vår nettside", "Billett" });

            migrationBuilder.UpdateData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Sporsmal", "Svar", "Tema" },
                values: new object[] { "Er det mulig å avbestille billettene?", "Ja. Du kan avbestille billettene innen 24 timer etter at bestillingen er gjort", "Billett" });

            migrationBuilder.InsertData(
                table: "SporsmalerOgSvar",
                columns: new[] { "Id", "Sporsmal", "Svar", "Tema" },
                values: new object[,]
                {
                    { 3, "Hvordan kjøper jeg billett?", "Dette kan du enkelt gjøre på vår nettside ved å bruke reiseplanleggeren", "Billett" },
                    { 4, "Hvilken betalingsmåter godtar dere?", "Vi godtar kun Visa", "Billett" },
                    { 5, "Hva skjer hvis jeg ikke rekker toget?", "Enkeltbilletter er kun gyldig til avgitt avgang. Du kan ikke benytte enkeltbilletter til andre avganger", "Billett" },
                    { 6, "Hvordan logger jeg inn på admin siden?", "Du klikker deg inn på admin panelet øverst til høyre. Brukernavn og passord blir sendt til mail etter forespørsel", "Admin" },
                    { 7, "Hvordan kan jeg legge til en ny avgang?", "Du klikker inn på den stasjonen du ønsker å legge en ny avgang for. Så klikker du på 'legg til avgang' knappen", "Admin" },
                    { 8, "Kan jeg legge til en ny stasjon?", "Ja. Du kan legge til en ny stasjon ved å logge deg inn på adminpanelet. Under stasjoner finner du en 'legg til ny stasjon' knapp", "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "Tema",
                table: "SporsmalerOgSvar");

            migrationBuilder.UpdateData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Sporsmal", "Svar" },
                values: new object[] { "Hvor kan jeg kjøpe billetter?", "Du kan kjøpe billetter fra vår nettside eller så kan kjøpe billett fra billettautomaten som er lokalisert på togstasjonene" });

            migrationBuilder.UpdateData(
                table: "SporsmalerOgSvar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Sporsmal", "Svar" },
                values: new object[] { "Hvordan kjøper jeg periodebillett?", "Du kan også kjøpe periodebillett på vår nettside" });
        }
    }
}
