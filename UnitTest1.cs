using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.InternetExplorer

namespace testproj2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\geckodriver\");
            //var options = new FirefoxDriver();
            //options.SetPreference("webdriver.gecko.driver", @"D:\geckodriver.exe");
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new FirefoxDriver(@"C:\driver"); 
            IWebDriver driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://technical-validation-web.ausvdc02.pcf.dell.com/");
        }
    }
}
