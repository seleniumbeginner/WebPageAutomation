using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageAutomation
{  enum PropertyType
    {    Id ,
         Name,
         LinkText,
         CssName,
         ClassName
     }
    class BackBoneProperties
    { public static IWebDriver driver {get;set ;}
    }
}
