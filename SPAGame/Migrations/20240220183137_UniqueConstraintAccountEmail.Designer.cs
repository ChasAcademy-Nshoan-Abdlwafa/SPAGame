﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPAGame.Data;

#nullable disable

namespace SPAGame.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240220183137_UniqueConstraintAccountEmail")]
    partial class UniqueConstraintAccountEmail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SPAGame.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountEmail")
                        .IsUnique()
                        .HasFilter("[AccountEmail] IS NOT NULL");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SPAGame.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("GameLost")
                        .HasColumnType("bit");

                    b.Property<bool>("GameWon")
                        .HasColumnType("bit");

                    b.Property<string>("GameWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GamesCompleted")
                        .HasColumnType("int");

                    b.Property<string>("Guess1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guess2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guess3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guess4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guess5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("AccountId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("SPAGame.Models.Game", b =>
                {
                    b.HasOne("SPAGame.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
