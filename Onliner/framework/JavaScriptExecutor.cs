using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerUITest.framework
{
    internal class JavaScriptExecutor
    {
        public static IJavaScriptExecutor GetDriverAsJavaScriptExecutor() { 
            return (Browser.GetOrCreateBrowser().GetDriver() as IJavaScriptExecutor);
        }
    }
}
