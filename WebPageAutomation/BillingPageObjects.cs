using DocuSign.eSign.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WebPageAutomation
{
    class BillingPageObjects
    {
        public BillingPageObjects()
        {

            PageFactory.initElements(BackBoneProperties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "wpforms[fields][0][first]")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "wpforms[fields][0][last]")]
        public IWebElement txtLastName { get; set; }


        [FindsBy(How = How.Name, Using = "wpforms[fields][1]")]

        public IWebElement txtemail { get; set; }
        [FindsBy(How=How.Name, Using = "textarea")]
        public IWebElement txtMesasge { get; set; }

        [FindsBy(How = How.TagName, Using = "button")]

        public IWebElement btnSave { get; set; }

        public void  EnterBillingForm(string Password)
        {
            txtPassword.SendKeys(password);
            txtLogin.Click();
        }
        }

    
}

