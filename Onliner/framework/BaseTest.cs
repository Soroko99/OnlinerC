using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace OnlinerUITest.framework
{
    abstract class BaseTest
    { 

        [SetUp]
        public void Setup()
        {
            Browser.GetOrCreateBrowser().NavigateToUrl("https://www.onliner.by/");
        }

        [TearDown]
        public void TearDown() { 
            Browser.GetOrCreateBrowser().TearDown();
        }
    }
}
