//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace WebPageAutomation
//{
//    class BillingFormSetMethodslongway
//    {
//        public static void EnterText(IWebDriver driver, string element, string value, string ElementType)
//        {
//            if (ElementType == "Id")
//                driver.FindElement(By.Id(element)).SendKeys(value);
//            if (ElementType == "Name")
//                driver.FindElement(By.Name(element)).SendKeys(value);
//        }
//        public static void Click(IWebDriver driver, string element, string value, string ElementType)
//        {
//            if (ElementType == "Id")
//                driver.FindElement(By.Id(element)).SendKeys(value);
//            if (ElementType == "Name")
//                driver.FindElement(By.Name(element)).SendKeys(value);
//        }
//        public static void SelectDropDown(IWebDriver driver, string element, string value, string ElementType)
//        {

//            if (ElementType == "Id")
//                driver.FindElement(By.Id(element)).Click();
//            if (ElementType == "Name")
//                driver.FindElement(By.Name(element)).Click();

//        }

//    }
//}
