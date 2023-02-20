using OnlinerUITest.framework;
using OnlinerUITest.page_objects;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OnlinerUITest.framework;
using OnlinerUITest.framework.elements;

namespace OnlinerUITest.page_objects
{
    internal class HomePage : BaseOnlinerPage
    { 
        public HomePage(string expectedPageTitle) : base(expectedPageTitle)
        {
        }       

        public override HomePage SelectFromMegaMenu(string sectionName)
        {
            base.SelectFromMegaMenu(sectionName);
            return this;
        }

    }
}
