using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerUITest.framework
{
    internal class Wait
    {
        static WebDriverWait wait;
        //sjhbgjdgbhjkd
        private static WebDriverWait GetWebDriverWait()
        {
            if (wait == null)
            {
                return new WebDriverWait(Browser.GetOrCreateBrowser().GetDriver(), TimeSpan.FromSeconds(20));
            }
            else return wait;
        }

        public static void WaitUntilElementIsPresent(By locator)
        {
            GetWebDriverWait().IgnoreExceptionTypes(typeof(ElementNotVisibleException), typeof(NoSuchElementException)
                , typeof(StaleElementReferenceException));
            GetWebDriverWait().Until(ExpectedConditions.ElementExists(locator));
            //sfgdgnjdngkjdnkggdk
            //sfgdgnjdngkjdnkggdk//sfgdgnjdngkjdnkggdk
        }

        public static void WaitUntilElementIsClickable(By locator) {
            GetWebDriverWait().IgnoreExceptionTypes(typeof(ElementClickInterceptedException), typeof(ElementNotInteractableException));
            GetWebDriverWait().Until(ExpectedConditions.ElementToBeClickable(locator));
        }

    }
}
