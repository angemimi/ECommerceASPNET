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
            context.Entry(p).State = EntityState.Added;
            context.SaveChanges(); // Sauvegarde des modification apporté.
        }

        public void EditProduct(Produit p)
        {
            context.Entry(p).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void RemoveProduct(Produit p)
        {
            context.Entry(p).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
