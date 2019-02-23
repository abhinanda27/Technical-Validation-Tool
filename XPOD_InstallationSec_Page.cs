using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using TechnicalValidationTool.TestAutomation.Workflow;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_InstallationSec_Page
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_InstallationSec_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Lbl_Addressline1()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Address Line 1')]"));
        }
        public IWebElement Txtbox_Addressline1()
        {
            return driver.FindElement(By.XPath("//input[@formcontrolname='installStreet1']"));
        }
        public IWebElement Lbl_Addressline2()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Address Line 2')]"));
        }
        public IWebElement Txtbox_Addressline2()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Address Line 2')]//following::input[1]"));
        }
        public IWebElement Lbl_City()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'City')]"));
        }
        public IWebElement Txtbox_City()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'City')]//following::input[1]"));
        }
        public IWebElement Lbl_State()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'State / Province')]"));
        }
        public IWebElement Txtbox_State()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'State / Province')]//following::input[1]"));
        }
        public IWebElement Lbl_Country()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Country')]"));
        }
        public IWebElement Txtbox_Country()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Country')]//following::input[1]"));
        }
        public IWebElement Lbl_ZipCode()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Zip Code')]"));
        }
        public IWebElement Txtbox_ZipCode()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Zip Code')]//following::input[1]"));
        }
        public IWebElement Btn_SaveInstallInfo()
        {
            return driver.FindElement(By.XPath("//button[@type='submit']"));
        }
        public By PageLoader()
        {
            return By.XPath("//div[@class='icon-ui-loading']");
        }

        //methods
        /// <summary>
        /// This method is to validate the fields populated in the intallation section Tab
        /// </summary>
        /// <returns></returns>
        public XPOD_InstallationSec_Page InstallSec_Fields_Validations()
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            Assert.True(Lbl_Addressline1().Displayed);
            Assert.True(Lbl_Addressline2().Displayed);
            Assert.True(Lbl_City().Displayed);
            Assert.True(Lbl_State().Displayed);
            Assert.True(Lbl_Country().Displayed);
            Assert.True(Lbl_ZipCode().Displayed);
            Assert.True(Btn_SaveInstallInfo().Enabled);

            return new XPOD_InstallationSec_Page(driver);
        }
        /// <summary>
        /// This method is to validate the mandatory fields in Intallation sections are not null
        /// </summary>
        /// <returns></returns>
        public XPOD_InstallationSec_Page installSecPage_FeildsArenotNull_validation()
        {
            
            Assert.NotNull(Txtbox_Addressline1().GetAttribute("value"));            
            //Assert.NotNull(Txtbox_Addressline2().GetAttribute("value"));
            Assert.NotNull(Txtbox_City().GetAttribute("value"));
            Assert.NotNull(Txtbox_State().GetAttribute("value"));
            Assert.NotNull(Txtbox_Country().GetAttribute("value"));
            Assert.NotNull(Txtbox_ZipCode().GetAttribute("value"));
            Assert.True(Btn_SaveInstallInfo().Enabled);
        
            return new XPOD_InstallationSec_Page(driver);
        }   
        /// <summary>
        /// This method is to Edit the existing fields and save
        /// </summary>
        /// <returns></returns>
        public XPOD_InstallationSec_Page FieldEdit_Validation(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "InstallationSec");
            Txtbox_Addressline1().Clear();
            Txtbox_Addressline1().SendKeys(data["Addressline1"].ToString());
            Txtbox_Addressline2().Clear();
            Txtbox_Addressline2().SendKeys(data["Addressline2"].ToString());
            Txtbox_City().Clear();
            Txtbox_City().SendKeys(data["City"].ToString());
            Txtbox_State().Clear();
            Txtbox_State().SendKeys(data["State"].ToString());
            Txtbox_Country().Clear();
            Txtbox_Country().SendKeys(data["Country"].ToString());
            Txtbox_ZipCode().Clear();
            Txtbox_ZipCode().SendKeys(data["Zipcode"].ToString());

            CommonMethods.WebdriverWait_ElementClickable(driver, Btn_SaveInstallInfo());
            CommonMethods.Page_Scrolldown(driver);
            Btn_SaveInstallInfo().Click();
            //CommonMethods.Page_ScrollUp(driver);

            return new XPOD_InstallationSec_Page(driver);
        }
        public XPOD_InstallationSec_Page Validating_Edited_Fields(Object DataObj)
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "InstallationSec");
            
            Assert.Equal(data["Addressline1"].ToString(), Txtbox_Addressline1().GetAttribute("value"));
            //Assert.Equal(data["Addressline2"].ToString(), Txtbox_Addressline2().GetAttribute("value"));
            Assert.Equal(data["City"].ToString(), Txtbox_City().GetAttribute("value"));
            Assert.Equal(data["State"].ToString(), Txtbox_State().GetAttribute("value"));
            Assert.Equal(data["Country"].ToString(), Txtbox_Country().GetAttribute("value"));
            Assert.Equal(data["Zipcode"].ToString(), Txtbox_ZipCode().GetAttribute("value"));
            
            return new XPOD_InstallationSec_Page(driver);
        }
        
        public XPOD_General_StaticEle_Page SwitchingTo_GenBasePage()
        {
            return new XPOD_General_StaticEle_Page(driver);
        }
    }
}
