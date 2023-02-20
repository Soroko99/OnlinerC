using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework;
using OnlinerUITest.framework.elements;

namespace OnlinerUITest.framework
{
    abstract class BasePage
    {
        public BasePage(string expectedPageTitle, string pageTitleLabelXPath)
        {
            Label pageTitleLable = new Label(By.XPath(pageTitleLabelXPath), "Page title");
            string actualPageTitleText = pageTitleLable.GetAttribute("innerText");
            Assert.That(actualPageTitleText, Is.EqualTo(expectedPageTitle), "Opened wrong page, opened page - "
                + Browser.GetOrCreateBrowser().GetPageUrl() + " with title " + actualPageTitleText);
            Logger.Info("The page " + "'" + actualPageTitleText + "'" + " was opened");
        }
    }
}
