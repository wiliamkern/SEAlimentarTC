﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEAlimentarTC.Repository;

namespace SEAlimentarTC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211027011412_BancoV3")]
    partial class BancoV3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("SEAlimentarTC.Dtos.Breakfest", b =>
                {
                    b.Property<int>("BreakfestID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BreakfestItemID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodMenuID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("BreakfestID", "BreakfestItemID");

                    b.HasIndex("FoodMenuID");

                    b.ToTable("Breakfest");
                });

            modelBuilder.Entity("SEAlimentarTC.Dtos.FoodMenu", b =>
                {
                    b.Property<int>("FoodMenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("MenuDay")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("FoodMenuID");

                    b.ToTable("FoodMenu");
                });

            modelBuilder.Entity("SEAlimentarTC.Dtos.MorningSnack", b =>
                {
                    b.Property<int>("MorningSnackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodMenuID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<int>("MorningSnackItemID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("MorningSnackID");

                    b.HasIndex("FoodMenuID");

                    b.ToTable("MorningSnack");
                });

            modelBuilder.Entity("SEAlimentarTC.Dtos.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Height")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Imc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SEAlimentarTC.Dtos.Breakfest", b =>
                {
                    b.HasOne("SEAlimentarTC.Dtos.FoodMenu", "FoodMenu")
                        .WithMany()
                        .HasForeignKey("FoodMenuID");
                });

            modelBuilder.Entity("SEAlimentarTC.Dtos.MorningSnack", b =>
                {
                    b.HasOne("SEAlimentarTC.Dtos.FoodMenu", "FoodMenu")
                        .WithMany()
                        .HasForeignKey("FoodMenuID");
                });
#pragma warning restore 612, 618
        }
    }
}