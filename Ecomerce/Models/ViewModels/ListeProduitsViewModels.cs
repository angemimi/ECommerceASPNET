using Ecomerce.Models;
using Ecommerce.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.ViewModels
{
    public class ListeProduitsViewModels
    {
        public IQueryable<Produit> Produits { get; set; }
        public PaginationInfo Pagination { get; set; }

        public IQueryable<Produit> ProduitsLimitOffset()
        {
            int offset = Pagination.ProduitsParPage * (Pagination.PageCourante - 1);
            return Produits.OrderBy(x => x.IDProduit).Skip(offset).Take(Pagination.ProduitsParPage);
        }
    }
}
