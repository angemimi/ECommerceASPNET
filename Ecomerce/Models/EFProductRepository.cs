using Ecomerce.Models;
using Microsoft.EntityFrameworkCore;
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
            context.Produits.Update(p); // Ajout du produit à la liste existantes
            context.SaveChanges(); // Sauvegarde des modification apporté.
        }

        public void EditProduct(Produit p)
        {
            context.Entry(p).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
