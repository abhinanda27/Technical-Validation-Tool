using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace TechnicalValidationTool.TestAutomation.Base
{
    public class TestBase:IDisposable
    {

        public IWebDriver webDriverTest;
        public TestBase()
        {
            webDriverTest = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webDriverTest.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriverTest.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            Screenshot ss = ((ITakesScreenshot)webDriverTest).GetScreenshot();
            var fileName = this.GetType().FullName.ToString().Split('.')[4]+".png";
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            webDriverTest.Quit();
        }
    }
}
