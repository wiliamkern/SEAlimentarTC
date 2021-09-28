using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Essentials;

namespace SEAlimentarTC.Repository
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public UserContext() // se o banco existe não faz nada, senão cria ele
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "User.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
