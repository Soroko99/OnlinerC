using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerUITest.framework
{
    internal class DriverFactory
    {
        WebDriver?  driver;

        public WebDriver GetOrCreateDriver()
        {
            if (driver == null) {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                driver = new ChromeDriver(options);
                return driver;
            }
            else { return driver; }
        }

        public void loggingSomeThings()
        {
            Logger.Info("Some info");
        }
    }
}
