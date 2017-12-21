using Ecomerce.Models;
using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using System;
using Xunit;

namespace EcomerceTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            PaginationInfo pagination = new PaginationInfo
            {
                NombreProduits = 11,
                PageCourante = 1,
                ProduitsParPage = 5
            };

            pagination.NbPage();
        }
    }
}
