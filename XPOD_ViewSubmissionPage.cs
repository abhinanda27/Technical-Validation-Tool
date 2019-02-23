using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_ViewSubmissionPage : PageBase
    {
        public IWebDriver driver;

        public XPOD_ViewSubmissionPage(IWebDriver driverinstance)
        {
            driver = driverinstance;
        }
        public IWebElement xPODForm()
        {
            return driver.FindElement(By.Id("txtSubmitterName"));
        }
        
    }
}
