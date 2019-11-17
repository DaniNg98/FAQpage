﻿// <auto-generated />
using FAQpage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQpage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQpage.Models.SendtInnSpm", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sporsmal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("SendtInnSpms");
                });

            modelBuilder.Entity("FAQpage.Models.SporsmalOgSvar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NegativRating")
                        .HasColumnType("int");

                    b.Property<int>("PositivRating")
                        .HasColumnType("int");

                    b.Property<string>("Sporsmal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Svar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SporsmalerOgSvar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Trenger jeg en bruker for å bestille billett?",
                            Svar = "Nei. Du trenger ikke å opprette en bruker for å bestille en billett på vår nettside",
                            Tema = "Billett"
                        },
                        new
                        {
                            Id = 2,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Er det mulig å avbestille billettene?",
                            Svar = "Ja. Du kan avbestille billettene innen 24 timer etter at bestillingen er gjort",
                            Tema = "Billett"
                        },
                        new
                        {
                            Id = 3,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Hvordan kjøper jeg billett?",
                            Svar = "Dette kan du enkelt gjøre på vår nettside ved å bruke reiseplanleggeren",
                            Tema = "Billett"
                        },
                        new
                        {
                            Id = 4,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Hvilken betalingsmåter godtar dere?",
                            Svar = "Vi godtar kun Visa",
                            Tema = "Billett"
                        },
                        new
                        {
                            Id = 5,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Hva skjer hvis jeg ikke rekker toget?",
                            Svar = "Enkeltbilletter er kun gyldig til avgitt avgang. Du kan ikke benytte enkeltbilletter til andre avganger",
                            Tema = "Billett"
                        },
                        new
                        {
                            Id = 6,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Hvordan logger jeg inn på admin siden?",
                            Svar = "Du klikker deg inn på admin panelet øverst til høyre. Brukernavn og passord blir sendt til mail etter forespørsel",
                            Tema = "Admin"
                        },
                        new
                        {
                            Id = 7,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Hvordan kan jeg legge til en ny avgang?",
                            Svar = "Du klikker inn på den stasjonen du ønsker å legge en ny avgang for. Så klikker du på 'legg til avgang' knappen",
                            Tema = "Admin"
                        },
                        new
                        {
                            Id = 8,
                            NegativRating = 0,
                            PositivRating = 0,
                            Sporsmal = "Kan jeg legge til en ny stasjon?",
                            Svar = "Ja. Du kan legge til en ny stasjon ved å logge deg inn på adminpanelet. Under stasjoner finner du en 'legg til ny stasjon' knapp",
                            Tema = "Admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
