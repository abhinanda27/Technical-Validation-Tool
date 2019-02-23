using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.Page;

namespace TechnicalValidationTool.TestAutomation.Base
{
    public class PageBase : IWebDriverBase
    {
        public IWebDriver WebDriver => throw new NotImplementedException();

        IWebDriver IWebDriverBase.WebDriver { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
