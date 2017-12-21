using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerce.Models {
    public interface IProductRepository {
        IQueryable<Produit> Produits { get; }
        void AddProduct(Produit p);
    }
}
