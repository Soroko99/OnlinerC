using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework.elements;

namespace OnlinerUITest.framework
{
    abstract class BaseElement 
    {
        private By locator;
        protected string elementName;
        protected IWebElement element;
        protected List<IWebElement> elementsList;

        public BaseElement(By locator, String elementName) { 
            this.locator = locator;
            this.elementName = "'" + elementName + "'";
        }

        public By GetLocator()
        {
            return locator;
        }

        public void GetElement() {
            element = Browser.GetOrCreateBrowser()
                             .GetDriver()
                             .FindElement(locator);
            Wait.WaitUntilElementIsPresent(locator);
        }

        public void Click() {
            GetElement();
            Logger.Info("Click element with name " + elementName);
            Wait.WaitUntilElementIsClickable(locator);
            element.Click();
        }

        public void ClickViaJavaScriptExecutor()
        {
            GetElement();
            Logger.Info("Click element with name " + elementName + " via javascript");
            Wait.WaitUntilElementIsClickable(locator);
            JavaScriptExecutor.GetDriverAsJavaScriptExecutor().ExecuteScript("arguments[0].click();", element);
        }

        public string GetText()
        {
            GetElement();
            string elementText = element.Text;
            Logger.Info("Trying to get element text with name " + elementName + ", the text is " + elementText);
            return elementText;
        }

       public string GetAttribute(string attributeName) {
            GetElement();
            string attributeValue = element.GetAttribute(attributeName);
            Logger.Info("Geting " + "'" + attributeName + "'" + " of " + elementName);
            return attributeValue;
        }
    }
}
