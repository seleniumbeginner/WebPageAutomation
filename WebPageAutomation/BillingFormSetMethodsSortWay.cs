using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageAutomation
{
    class BillingFormSetMethodsSortWay   (  )
 
    public  string GetText(IWebElement element, String value)
    { element.SendKeys(value); }
    public static void submit (IWebElement element)
    {
        element.Click();
    }

    public static void GetTextFromDDl(IWebElement element, string value)
    { new SelectElement(element).SelectByText(value); }


    [Ignore]
    ////  public static void EnterBillingForm() 
    //  { BackBoneProperties.driver.Navigate().GoToUrl("http://qaauto.co.nz/test-blank-form/");
    //BackBoneProperties.driver.FindElement(By.ClassName()).SendKeys("Testing"); }


}
    } 

