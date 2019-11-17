using System;
using FAQpage.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQpage.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        
        public DbSet<SporsmalOgSvar> SporsmalerOgSvar { get; set; }
        public DbSet<SendtInnSpm> SendtInnSpms { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        
    }
}
