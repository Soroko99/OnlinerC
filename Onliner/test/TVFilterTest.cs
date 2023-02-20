using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework;
using OnlinerUITest.page_objects;

namespace OnlinerUITest.test
{
    internal class TVFilterTest : BaseTest
    {

        [TestCase("Samsung", "до", "2 000", "40", "50")]
        public void TVFiltrationTest(string manufacturerName, string pricePlaceholder, string price, 
            string minimumTVScreenSize, string maximumTVScreenSize) {
            new HomePage("Onlíner")
                .SelectFromMegaMenu("Каталог");
            new CatalogPage("Каталог Onlíner")
                .ChooseProductType("Электроника")
                .SelectProductSubType("Телевидение")
                .OpenProductPage(" Телевизоры ");
            new TVPage("Телевизор купить в Минске")
                .SelectManufacturer(manufacturerName)
                .SelectPrice(pricePlaceholder, price)
                .SelectMinimumTVScreenSize(minimumTVScreenSize)
                .SelectMaximumTVScreenSize(maximumTVScreenSize)
                .VerifySelectedManufacturer(manufacturerName)
                .VerifySelectedPrice(pricePlaceholder, price)
                .VerifySelectedScreenSize(minimumTVScreenSize, maximumTVScreenSize);
        }
    }
}
