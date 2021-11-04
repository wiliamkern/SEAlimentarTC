using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using System.IO;
using Xamarin.Essentials;

namespace SEAlimentarTC.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<FoodMenu> FoodMenu { get; set; }
        public DbSet<Breakfest> Breakfest { get; set; }
        public DbSet<MorningSnack> MorningSnack { get; set; }
        public DbSet<Lunch> Lunch { get; set; }
        public DbSet<AfternoonSnack> AfternoonSnack { get; set; }
        public DbSet<Dinner> Dinner { get; set; }
        public DbSet<AfterDinner> AfterDinner { get; set; }
        public DbSet<FoodMenuHistory> FoodMenuHistory { get; set; }

        public AppDbContext() // se o banco existe não faz nada, senão cria ele
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DataBase.DBPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // criação de chave composta só pelo API Fluent
            modelBuilder.Entity<Breakfest>()
               .HasKey(c => new { c.FoodMenuID, c.BreakfestID });

            modelBuilder.Entity<MorningSnack>()
               .HasKey(c => new { c.FoodMenuID, c.MorningSnackID });

            modelBuilder.Entity<Lunch>()
               .HasKey(c => new { c.FoodMenuID, c.LunchID});

            modelBuilder.Entity<AfternoonSnack>()
               .HasKey(c => new { c.FoodMenuID, c.AfternoonSnackID });

            modelBuilder.Entity<Dinner>()
               .HasKey(c => new { c.FoodMenuID, c.DinnerID });

            modelBuilder.Entity<AfterDinner>()
              .HasKey(c => new { c.FoodMenuID, c.AfterDinnerID });

        }
    }
}
