using OnlinerUITest.framework.elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework;

namespace OnlinerUITest.page_objects
{
    internal abstract class BaseOnlinerPage : BasePage
    {
        private static string pageTitleLabelXpath = "//body[@class='no-touch']//preceding-sibling::head//title";
        protected string mainNavigationButtonXpath = "//li[@class='b-main-navigation__item']//span[contains(text(), '{0}')]";

        protected BaseOnlinerPage(string expectedPageTitle) : base(expectedPageTitle, pageTitleLabelXpath)
        {
        }

        public virtual BaseOnlinerPage SelectFromMegaMenu(string sectionName)
        {
            Button selectSectionMainNavButton = new Button(By.XPath(String.Format(mainNavigationButtonXpath, sectionName))
                , "Button to open " + sectionName + " using main menu");
            Logger.Info("Select " + "'" + sectionName + "'" + " from mega menu");
            selectSectionMainNavButton.Click();
            return this;
        }
    }
}
