using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.ViewModel
{
    public class PaginationInfo
    {
        public int NombreProduits { get; set; }
        public int ProduitsParPage { get; set; } = 5;
        public int PageCourante { get; set; } = 1;

        public decimal NbPage()
        {
            decimal nbPage = NombreProduits / ProduitsParPage;
            return Math.Ceiling(nbPage);
        }
    }
}
