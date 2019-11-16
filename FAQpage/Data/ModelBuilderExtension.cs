using System;
using FAQpage.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQpage.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SporsmalOgSvar>().HasData(
                new SporsmalOgSvar
                {
                    Id = 1,
                    Tema = "Billett",
                    Sporsmal = "Trenger jeg en bruker for å bestille billett?",
                    Svar = "Nei. Du trenger ikke å opprette en bruker for å bestille en billett på vår nettside"
                },
                new SporsmalOgSvar
                {
                    Id = 2,
                    Tema = "Billett",
                    Sporsmal = "Er det mulig å avbestille billettene?",
                    Svar = "Ja. Du kan avbestille billettene innen 24 timer etter at bestillingen er gjort"
                },
                new SporsmalOgSvar
                {
                    Id = 3,
                    Tema = "Billett",
                    Sporsmal = "Hvordan kjøper jeg billett?",
                    Svar = "Dette kan du enkelt gjøre på vår nettside ved å bruke reiseplanleggeren"
                },
                new SporsmalOgSvar
                {
                    Id = 4,
                    Tema = "Billett",
                    Sporsmal = "Hvilken betalingsmåter godtar dere?",
                    Svar = "Vi godtar kun Visa"
                },
                new SporsmalOgSvar
                {
                    Id = 5,
                    Tema = "Billett",
                    Sporsmal = "Hva skjer hvis jeg ikke rekker toget?",
                    Svar = "Enkeltbilletter er kun gyldig til avgitt avgang. Du kan ikke benytte enkeltbilletter til andre avganger"
                },
                new SporsmalOgSvar
                {
                    Id = 6,
                    Tema = "Admin",
                    Sporsmal = "Hvordan logger jeg inn på admin siden?",
                    Svar = "Du klikker deg inn på admin panelet øverst til høyre. Brukernavn og passord blir sendt til mail etter forespørsel"
                },
                new SporsmalOgSvar
                {
                    Id = 7,
                    Tema = "Admin",
                    Sporsmal = "Hvordan kan jeg legge til en ny avgang?",
                    Svar = "Du klikker inn på den stasjonen du ønsker å legge en ny avgang for. Så klikker du på 'legg til avgang' knappen"
                },
                new SporsmalOgSvar
                {
                    Id = 8,
                    Tema = "Admin",
                    Sporsmal = "Kan jeg legge til en ny stasjon?",
                    Svar = "Ja. Du kan legge til en ny stasjon ved å logge deg inn på adminpanelet. Under stasjoner finner du en 'legg til ny stasjon' knapp"
                }
            );
        }
    }
}
