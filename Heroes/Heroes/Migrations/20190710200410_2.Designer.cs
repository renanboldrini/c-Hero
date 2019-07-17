﻿// <auto-generated />
using System;
using Heroes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Heroes.Migrations
{
    [DbContext(typeof(HeroesContext))]
    [Migration("20190710200410_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Heroes.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Heroes.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Description");

                    b.Property<string>("Force");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<int>("PlanetId");

                    b.Property<int>("PowerId");

                    b.Property<string>("SuperName");

                    b.Property<string>("Universe");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("PlanetId");

                    b.HasIndex("PowerId");

                    b.ToTable("Hero");
                });

            modelBuilder.Entity("Heroes.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("Heroes.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HeroId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("Power");
                });

            modelBuilder.Entity("Heroes.Models.Hero", b =>
                {
                    b.HasOne("Heroes.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Heroes.Models.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Heroes.Models.Power", "Power")
                        .WithMany()
                        .HasForeignKey("PowerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Heroes.Models.Power", b =>
                {
                    b.HasOne("Heroes.Models.Hero")
                        .WithMany("Powers")
                        .HasForeignKey("HeroId");
                });
#pragma warning restore 612, 618
        }
    }
}
