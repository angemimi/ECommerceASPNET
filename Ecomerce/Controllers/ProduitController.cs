using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecomerce.Models;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models.ViewModel;
using Ecommerce.Models.ViewModels;
using Ecommerce.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomerce.Controllers
{
    public class ProduitController : Controller
    {
        IProductRepository productRepository;
        PaginationInfo pagination = new PaginationInfo();
        ListeProduitsViewModels viewModel = new ListeProduitsViewModels();
        public ProduitController(IProductRepository repos) {
            productRepository = repos;
            pagination.NombreProduits = repos.Produits.Count();
            viewModel = new ListeProduitsViewModels
            {
                Produits = repos.Produits,
                Pagination = pagination
            };
        }
        
        public ViewResult List(int productPage)
        {
            productPage = productPage > 0 ? productPage : 1;
            viewModel.Pagination.PageCourante = productPage;
            return View(viewModel);
        }

        // Affichage du formulaire d'ajout de produit
        public ViewResult AddProductForm(Produit p) => View(p);

        public ViewResult AddProduct(Produit p)
        {
            productRepository.AddProduct(p); // Ajout du produit créée
            return View("List", viewModel);
        }

        // Affichage du formulaire de modification du produit selectionné. On selectionne un produit dont l'id à pour valeur celle passer en parametre
        public ViewResult EditProductForm(string pId) => View(productRepository.Produits.Single<Produit>(p => p.IDProduit == pId));
        public ViewResult EditProduct(Produit p)
        {
            productRepository.EditProduct(p);
            return View("List", viewModel);
        }

        public ViewResult RemoveProduct(string pId)
        {
            productRepository.RemoveProduct(productRepository.Produits.Single<Produit>(p => p.IDProduit == pId));
            return View("List", viewModel);
        }
    }
}
