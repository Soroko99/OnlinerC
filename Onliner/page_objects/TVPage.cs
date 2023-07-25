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
    internal class TVPage : BaseOnlinerPage
    {
        string manufacturerCheckBoxXpath = "//ul[@class='schema-filter__list']//span[text() = '{0}']";
        string priceInputXpath = "//input[@placeholder='{0}']";
        string TVResolutionCheckBoxXpath = "//span[text()='{0}\"']//ancestor::label";
        string appearedLabelToVerifyFiltration = "//div[@title='{0}']/span";

        public TVPage(string expectedPageTitle) : base(expectedPageTitle)
        {
        }

        public TVPage SelectManufacturer(string manufacturerName) {
            Logger.Info("Trying to select manufacturer: " + manufacturerName);
            CheckBox manufacturerCheckbox = new CheckBox(By.XPath(String.Format(manufacturerCheckBoxXpath, manufacturerName)), 
                "Checkbox to choose manufacturer");
            manufacturerCheckbox.ClickViaJavaScriptExecutor();
            return this;
        }

        public TVPage SelectPrice(string placeholder, string price)
        {
            Logger.Info("Trying to enter price: " + placeholder + " " + price);
            TextInput priceInput = new TextInput(By.XPath(String.Format(priceInputXpath, placeholder)), 
                "Text input to choose maximum price");
            priceInput.SendKeys(price);
            return this;
        }

        public TVPage SelectMinimumTVScreenSize(string minimumScreenSize)
        {
            Logger.Info("Trying to select minimum screen resolution: " + minimumScreenSize);
            Button minimumTVResolutionCheckBox = new Button(By.XPath(String.Format(TVResolutionCheckBoxXpath, minimumScreenSize)),
                "Button to choose minimum TV resolution");
            minimumTVResolutionCheckBox.ClickViaJavaScriptExecutor();
            return this;
        }

        public TVPage SelectMaximumTVScreenSize(string maximumScreenSize)
        {
            Logger.Info("Trying to select maximum screen resolution: " + maximumScreenSize);
            Button maximumTVResolutionCheckBox = new Button(By.XPath(String.Format(TVResolutionCheckBoxXpath, maximumScreenSize)),
                "Button to choose maximum TV resolution");
            maximumTVResolutionCheckBox.ClickViaJavaScriptExecutor();
            return this;
        }

        public TVPage VerifySelectedManufacturer(string manufacturerName)
        {
            Logger.Info("Check whether" + manufacturerName + " was selected as manufacturer");
            Label manufacturerLbl = new Label(By.XPath(String.Format(appearedLabelToVerifyFiltration, "Производитель")), 
                "Label to verify selected manufacturer");
            string selectedManufacturerName = manufacturerLbl.GetAttribute("innerText");
            Assert.That(selectedManufacturerName, Is.EqualTo(manufacturerName), "Actual manufacturer name differs from expected one");
            return this;
        }

        public TVPage VerifySelectedPrice(string placeholder, string price)
        {
            Logger.Info("Check whether " + placeholder + " " + price + " is selected as a price");
            Label selectedPriceLabel = new Label(By.XPath(String.Format(appearedLabelToVerifyFiltration, "Минимальная цена")),
                "Label to verify selected manufacturer");
            string selectedPrice = selectedPriceLabel.GetText();
            Assert.True(selectedPrice.Contains(placeholder), "Actual price should starts with" + placeholder + " but found: " + selectedPrice);
            Assert.True(selectedPrice.Contains(price), "Actual price should be " + price + " but found: " + selectedPrice);
            return this;
        }

        public TVPage VerifySelectedScreenSize(string minimumScreenSize, string maximumScreenSize)
        {
            Logger.Info("Check screen size if scree size equals to " + minimumScreenSize + "x" + maximumScreenSize);
            Label selectedPriceLabel = new Label(By.XPath(String.Format(appearedLabelToVerifyFiltration, "Диагональ")),
                "Label to verify selected manufacturer");
            string selectedPrice = selectedPriceLabel.GetText();
            Assert.True(selectedPrice.Contains(minimumScreenSize), "Actual screen size should be more or equal " + minimumScreenSize + " but found: " + selectedPrice);
            Assert.True(selectedPrice.Contains(maximumScreenSize), "Actual price should be less or equal " + maximumScreenSize + " but found: " + selectedPrice);
            return this;
        }
    }
}
