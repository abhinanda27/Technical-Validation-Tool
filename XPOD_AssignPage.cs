using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;
using Xunit;
using System.Linq;
namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_AssignPage : PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;
        public XPOD_AssignPage(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement assignDropdown()
        {

           return driver.FindElement(By.Id("ddlVc"));
            

        }

        public IWebElement assignBtn()
        {
            return driver.FindElement(By.Id("btnAssign"));


        }

        public IWebElement closeBtn()
        {
            return driver.FindElement(By.ClassName("buttonMuseo"));


        }

        //Actons


        public XPOD_AssignPage clickSECDropdown()
        {
            new XPOD_AssignPage(driver).ScrollTillEnd();
            CommonMethods.WebdriverWait_TillElementReady(driver, assignBtn());
            new XPOD_Genral_OI_Page(driver).Btn_Assign().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.WebdriverWait_TillElementReady(driver, assignDropdown());
            Assert.True(assignDropdown().Enabled);
            return new XPOD_AssignPage(driver);
        }

        public XPOD_AssignPage selectSEC(Object DataObj, String TestName, String TestValue)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            var names = data[TestValue];
            CommonMethods.WebdriverWait_TillElementReady(driver, assignDropdown());
            SelectElement sec = new SelectElement(assignDropdown());
            sec.SelectByText(names.ToString());
            assignBtn().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, closeBtn());
            Assert.True(closeBtn().Enabled);
            return new XPOD_AssignPage(driver);
        }


        /// <summary>
        /// Method to scroll down the page till end
        /// </summary>
        /// <returns></returns>
        public XPOD_AssignPage ScrollTillEnd()
        {
            CommonMethods.Page_Scrolldown(driver);
            return new XPOD_AssignPage(driver);
        }
    }
}
