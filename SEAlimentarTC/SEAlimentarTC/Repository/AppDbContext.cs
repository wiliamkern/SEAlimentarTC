using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using System.IO;
using Xamarin.Essentials;

namespace SEAlimentarTC.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public AppDbContext() // se o banco existe não faz nada, senão cria ele
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string dbPath = Path.Combine(FileSystem.AppDataDirectory, "User.db3");
            // optionsBuilder.UseSqlite($"Filename={dbPath}");

            optionsBuilder.UseSqlite($"Filename={DataBase.DBPath}");
        }
    }
}
