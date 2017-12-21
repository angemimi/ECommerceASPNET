using Ecomerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class EFProductRepository: IProductRepository
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx) { context = ctx; }
        public IQueryable<Produit> Produits => context.Produits.OrderBy(x => x.IDProduit);

        public void AddProduct(Produit p)
        {
            p.IDProduit = Convert.ToString((Produits.Count() + 1)); // Ajout d'un id au produit
            context.Produits.Add(p); // Ajout du produit à la liste existantes
            context.SaveChanges(); // Sauvegarde des modification apporté.
        }

        public void EditProduct(Produit p)
        {
            Produit prod = context.Produits.SingleOrDefault<Produit>(pdt => pdt.IDProduit == p.IDProduit);
            prod = p;
            context.SaveChanges();
        }
    }
}
