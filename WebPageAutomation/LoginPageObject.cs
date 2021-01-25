using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageAutomation
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.initelements(BackBoneProperties.driver, this);
        }
        
        [FindsBy (How=How.Name,Using= "wpforms[form_locker_password] ")]
      public IWebElement txtPassword { get; set; } 

    [FindsBy(How=How.Name,Using ="wpforms[submit]")]
    public IWebElement btnSubmit { get; set; }
    }
}
