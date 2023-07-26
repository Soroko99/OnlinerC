using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerUITest.framework
{
    internal class Browser  
    {
        WebDriver driver;
        static ThreadLocal<Browser> BROWSER_CONTAINER = new ThreadLocal<Browser>();
        public Browser(WebDriver driver) {
            Logger.Info("The browser is created");
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }
     
        public void NavigateToUrl(String url) {
            Logger.Info("Browser goes to " + url);
            driver.Navigate().GoToUrl(url);
        }

        public static Browser GetOrCreateBrowser() {
            Browser? browser = BROWSER_CONTAINER.Value;
            if (browser == null) {
                browser = new Browser(new DriverFactory().GetOrCreateDriver());
                BROWSER_CONTAINER.Value = browser;
                return browser;
            }
            return browser;
        }

        public WebDriver GetDriver()
        {
            return driver;
        }

        public String GetPageUrl() {
            return driver.Url;
        }

        public void TearDown()
        {
            driver.Quit();
        }

    }



}
