using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinerUITest.framework.elements
{
    internal class TextInput : BaseElement
    {
        public TextInput(By locator, string elementName) : base(locator, elementName)
        {
        }

        public void SendKeys(string keysToSend)
        {
            GetElement();
            Logger.Info("Enter " + keysToSend + " to text input with name " + elementName);
            element.SendKeys(keysToSend);
        }

    }
}
