using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalValidationTool.TestAutomation.Base
{
   public interface IWebDriverBase
    {
        IWebDriver WebDriver { get; set; }

    }
}
