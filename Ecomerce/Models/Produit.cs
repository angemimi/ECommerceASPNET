﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerce.Models
{
    public class Produit
    {
        [Key]
        public string IDProduit { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal? Prix { get; set; }
        public string Categorie { get; set; }
    }
}
