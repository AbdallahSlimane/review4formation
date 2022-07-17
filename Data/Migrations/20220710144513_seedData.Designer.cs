﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MonDbContext))]
    [Migration("20220710144513_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Avis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("FormationId")
                        .HasColumnType("int");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Notes")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FormationId");

                    b.ToTable("Avis");
                });

            modelBuilder.Entity("Data.Formation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomSeo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Formations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Devenez pro et créer votre site web avec spring boot et angular",
                            Nom = "Créer votre site web avec spring boot et angular",
                            NomSeo = "spring-angular"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Créer votre application mobile avec flutter étape par étape",
                            Nom = "Créer votre application mobile avec flutter",
                            NomSeo = "flutter"
                        },
                        new
                        {
                            Id = 3,
                            Description = "comment faire du code propre",
                            Nom = "Apprendre le clean code",
                            NomSeo = "clean-code"
                        },
                        new
                        {
                            Id = 4,
                            Description = "gérer votre base de donnée",
                            Nom = "Devenez pro gestion de base de donnée",
                            NomSeo = "base-de-donnee"
                        });
                });

            modelBuilder.Entity("Data.Avis", b =>
                {
                    b.HasOne("Data.Formation", "Formation")
                        .WithMany("Avis")
                        .HasForeignKey("FormationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
