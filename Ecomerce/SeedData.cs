using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Ecomerce.Models;

namespace Ecommerce.Models
{
    public class SeedData
    {
        public static void Produits(IApplicationBuilder app)
        {
            ApplicationDbContext ctx = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            ctx.Database.Migrate();
            if (!ctx.Produits.Any())
            {
                ctx.Produits.AddRange(
                   new Produit
                   {
                       IDProduit = "1",
                       Nom = "Kayak 1 personne",
                       Categorie = "Sport aquatique",
                       Description = "Un bateau pour une personne",
                       Prix = 575M
                   },
                    new Produit
                    {
                        IDProduit = "2",
                        Nom = "Gillet de sauvetage adulte",
                        Categorie = "Sport aquatique",
                        Description = "Un gillet de sauvetage adulte",
                        Prix = 250
                    },
                    new Produit
                    {
                        IDProduit = "3",
                        Nom = "Chaussure de Foot",
                        Categorie = "Football",
                        Description = "Une paire de chaussures à crampons idéale pour le football",
                        Prix = 75
                    },
                    new Produit
                    {
                        IDProduit ="4",
                        Nom = "Ballon de Foot",
                        Categorie = "Football",
                        Prix = 15
                    },
                    new Produit
                    {
                        IDProduit = "5",
                        Nom = "Flute traversiere",
                        Categorie = "Musique",
                        Prix = 65
                    },
                    new Produit
                    {
                        IDProduit = "6",
                        Nom = "Flute à bec",
                        Categorie = "Musique",
                        Prix = 15
                    },
                    new Produit
                    {
                        IDProduit = "7",
                        Nom = "Converse Rouge",
                        Categorie = "Chaussure",
                        Prix = 55
                    },
                    new Produit
                    {
                        IDProduit = "8",
                        Nom = "Petit sapin",
                        Categorie = "Noel",
                        Prix = 23
                    },
                    new Produit
                    {
                        IDProduit = "9",
                        Nom = "Moyen sapin",
                        Categorie = "Noel",
                        Prix = 29
                    },
                    new Produit
                    {
                        IDProduit = "10",
                        Nom = "Grand sapin",
                        Categorie = "Noel",
                        Prix = 35
                    },
                    new Produit
                    {
                        IDProduit = "11",
                        Nom = "Guirelande electrique",
                        Categorie = "Noel",
                        Prix = 23
                    }
                );
            } 

            ctx.SaveChanges();
        }
    }
}
