using Docker.DotNet.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageAutomation
{
    public class Tests
    {
        LoginPageObject LoginPage = new LoginPageObject();
        IWebDriver driver = new ChromeDriver();


        [Test]
        public void BillingFormPage()
        {
            
            driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
            driver.FindElement(By.Id ("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
            driver.FindElement(By.CssSelector("#wpforms-submit-locked-24")).Click();
           // FirstName("Name");
           // LastName("Surname");

            driver.Manage().Window.Maximize();
            Assert.Pass();
        }
        


    }
}