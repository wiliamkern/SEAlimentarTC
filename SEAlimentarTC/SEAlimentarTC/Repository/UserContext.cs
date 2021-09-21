using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAlimentarTC.Repository
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        /**
         * Seta o nome do DB
         * **/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"FileName={DataBase.DBPath}");
        }

        /**
         * Classe do Entity para setar o tipo de dado que será usado na criação da table no sql (se não usar o OnModelCreating o Entity seta tudo com tamanhos default estabelecidos por ele)
         * **/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User"); // seta nome da tabela (caso não informado seta o mesmo nome do objeto)

            modelBuilder.Entity<User>()
                .HasKey(key => key.UserID); // seta o ID da table
                                            //  .HasKey(key => new { key.Id, key.Name }); Criãção de chave composta

            /* modelBuilder.Entity<User>() // set de parametros via fluent API ou pode ser feito por tag direto na dto (como utilizei aqui)
                      .Property(prop => prop.Id)
                      .HasColumnType("integer")
                      .IsRequired(); */
        }
    }
}
