using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerce.Models
{
    public class FauxDepotProduit
    {
        public IQueryable<Produit> Produits => new List<Produit>
        {
            
        }.AsQueryable<Produit>();

        public IQueryable<Produit> Link(int nb)
        {
            throw new NotImplementedException();
        }
    }
}
