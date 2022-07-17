using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MonDbContext :DbContext
    {
        public MonDbContext(DbContextOptions<MonDbContext> options) : base(options)
        {

        }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Avis> Avis { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        public DbSet<ReRouting> ReRouting { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>()
                .Property(f => f.Description)
                .HasMaxLength(500);
            modelBuilder.Entity<Formation>().HasData
                (
                    new
                    {
                        Id = 1,
                        Nom = "Créer votre site web avec spring boot et angular",
                        NomSeo = "spring-angular",
                        Description = "Devenez pro et créer votre site web avec spring boot et angular"
                    },
                    new
                    {
                        Id = 2,
                        Nom = "Créer votre application mobile avec flutter",
                        NomSeo = "flutter",
                        Description = "Créer votre application mobile avec flutter étape par étape"
                    },
                    new
                    {
                        Id = 3,
                        Nom = "Apprendre le clean code",
                        NomSeo = "clean-code",
                        Description = "comment faire du code propre"
                    },
                    new
                    {
                        Id = 4,
                        Nom = "Devenez pro gestion de base de donnée",
                        NomSeo = "base-de-donnee",
                        Description = "gérer votre base de donnée"
                    },
                    new
                    {
                        Id = 5,
                        Nom = "Apprendre le C",
                        NomSeo = "langage-C",
                        Description = "comment faire du C"
                    },
                    new
                    {
                        Id = 6,
                        Nom = "Découvrez l'architecture des logiciels",
                        NomSeo = "architecture-des-logiciels",
                        Description = "La conception de l'architecture est une étape cruciale du développement logiciel"
                    },
                    new
                    {
                        Id = 7,
                        Nom = "Apprendre le React.JS",
                        NomSeo = "langage-react.js",
                        Description = "comment faire du C"
                    },
                    new
                    {
                        Id = 8,
                        Nom = "Le langage androïd en plusieurs étapes",
                        NomSeo = "langage-androïd",
                        Description = "Android est un système d'exploitation mobile fondé sur le noyau Linux"
                    },
                    new
                    {
                        Id = 9,
                        Nom = "Apprendre le PHP",
                        NomSeo = "langage-php",
                        Description = "Découvrez le code avec PHP"
                    }

                ) ;
        }

    }
}
