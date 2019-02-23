using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.Base;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class GooglePage:PageBase
    {
        private static IWebDriver webDriver;
        public GooglePage(IWebDriver driverInstance)
        {
            webDriver = driverInstance;
        }

        public IWebElement searchBox
        {
            get { return webDriver.FindElement(By.Name("q")); }
        }

        public GooglePage NaviagateToGoogle()
        {
            webDriver.Navigate().GoToUrl("http://www.google.com");

            return new GooglePage(webDriver);
        }
    }
}
