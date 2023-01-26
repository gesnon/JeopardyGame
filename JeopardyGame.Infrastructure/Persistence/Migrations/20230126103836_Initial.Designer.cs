﻿// <auto-generated />
using System;
using JeopardyGame.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JeopardyGame.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20230126103836_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Pack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Packs");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("PackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("RoundId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoundId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Game", b =>
                {
                    b.HasOne("JeopardyGame.Domain.Entities.Pack", "Pack")
                        .WithMany()
                        .HasForeignKey("PackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pack");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Player", b =>
                {
                    b.HasOne("JeopardyGame.Domain.Entities.Game", "Game")
                        .WithMany("Players")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JeopardyGame.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Question", b =>
                {
                    b.HasOne("JeopardyGame.Domain.Entities.Theme", null)
                        .WithMany("Questions")
                        .HasForeignKey("ThemeId");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Round", b =>
                {
                    b.HasOne("JeopardyGame.Domain.Entities.Pack", null)
                        .WithMany("Rounds")
                        .HasForeignKey("PackId");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Theme", b =>
                {
                    b.HasOne("JeopardyGame.Domain.Entities.Round", null)
                        .WithMany("Themes")
                        .HasForeignKey("RoundId");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Game", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Pack", b =>
                {
                    b.Navigation("Rounds");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Round", b =>
                {
                    b.Navigation("Themes");
                });

            modelBuilder.Entity("JeopardyGame.Domain.Entities.Theme", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
