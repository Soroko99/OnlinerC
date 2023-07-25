using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework;
using OnlinerUITest.page_objects;
using OnlinerUITest.framework;
using OnlinerUITest.framework.elements;

namespace OnlinerUITest.page_objects
{
    internal class CatalogPage : BaseOnlinerPage
    {
        string typeOfProductButtonXpath = "//span[contains(text(), '{0}')]//ancestor::li";
        string subTypeOfProductButtonXpath = "//div[contains(text(), '{0}')]";
        string productButtonXpath = "//div[contains(@class,'item_active')]//span[contains(text(), '{0}')]";


        public CatalogPage(string expectedPageTitle) : base(expectedPageTitle)
        {
        }

        public CatalogPage ChooseProductType(string productTypeName)
        {
            Logger.Info("Trying to open " + productTypeName + " menu");
            Button selectTypeOfProductBtn = new Button(By.XPath(String.Format(typeOfProductButtonXpath, productTypeName)), 
                "Type of product button");
            selectTypeOfProductBtn.Click();
            return this;
        }

        public CatalogPage SelectProductSubType(string productSubTypeName)
        {
            Logger.Info("Trying to open " + productSubTypeName + " subType");
            Button selectSubTypeOfProduct = new Button(By.XPath(String.Format(subTypeOfProductButtonXpath, productSubTypeName))
                , "SubType of product button");
            selectSubTypeOfProduct.Click();
            return this;
        }

        public CatalogPage OpenProductPage(string productName)
        {
            Logger.Info("Trying to open " + productName + " page");
            Button productButton = new Button(By.XPath(String.Format(productButtonXpath, productName)), 
                "Button to open product page");
            productButton.Click();
            return this;
        }
    }
}
