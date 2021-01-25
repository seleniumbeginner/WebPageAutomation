using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageAutomation
{
    class Program
    {










        static void Main (string[] args)
        {              }

        [SetUp]
        public void initialise()
        { BackBoneProperties.driver = new ChromeDriver();
            BackBoneProperties.driver.Navigate().GoToUrl("http://qaauto.co.nz/test-blank-form/");

            Console.WriteLine("OPen Page");
        }
        [Test]

        public void ExecuteTest()
        {
            BillingPageObjects page = new BillingPageObjects();
            page.txtFirstName.SendKeys(" Basanta");
            page.txtLastName.SendKeys("Godar");
            page.txtemail.SendKeys("abc@gmail.com");
            page.btnSave.Click(); 
        
        }




    }

}
