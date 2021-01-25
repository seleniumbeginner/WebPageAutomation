using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebPageAutomation
{
    class BillingFormGetMethodShortway
    {
        public static string  GetText (IWebElement element)
        {
            return element.GetAttribute("value"); 
        }

        public static string GetTextFromDDl(IWebElement element)
        { return new SelectElement (element.AllSelectedOptions.SingleOrDefault()); }
    }
}
