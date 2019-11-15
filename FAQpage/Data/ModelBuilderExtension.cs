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
                    Sporsmal = "Hvor kan jeg kjøpe billetter?",
                    Svar = "Du kan kjøpe billetter fra vår nettside eller så kan kjøpe billett fra billettautomaten som er lokalisert på togstasjonene"
                },
                new SporsmalOgSvar
                {
                    Id = 2,
                    Sporsmal = "Hvordan kjøper jeg periodebillett?",
                    Svar = "Du kan også kjøpe periodebillett på vår nettside"
                }
            );
        }
    }
}
