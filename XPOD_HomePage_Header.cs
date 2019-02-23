using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_HomePage_Header:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;
        
        public XPOD_HomePage_Header(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }
        public IWebElement txt_page_header()
        {   
            return ReturnMeWebElement(By.XPath("//font[text()='Technical Validation']")); //driver.FindElement(By.XPath("//font[text()='Technical Validation']"));
        }
        
        
        public IWebElement DellLogo()
        {
            return ReturnMeWebElement(By.ClassName("logo"));
            
        }
        public IWebElement Txt_Username()
        {   
            return ReturnMeWebElement(By.XPath("//div[contains(text(),'Welcome')]"));
        }
        public IWebElement Txt_TechValidSub()
        {  
           return ReturnMeWebElement(By.XPath("//div[text()=' Technical Validation Submissions ']"));
        }
        public IWebElement TextBox_Fulldb_Search()
        {
            return ReturnMeWebElement(By.Id("filterTextGlobal"));
        }
        public IWebElement FullDbSearch_SearchBtn()
        {
            return ReturnMeWebElement(By.XPath("//input[@id='filterTextGlobal']//following::i[1]"));
        }
        public IWebElement Btn_ValidationList()
        {            
            return ReturnMeWebElement(By.Id("btnBack"));
        }
        public By PageLoader()
        {
            return By.XPath("//div[@class='icon-ui-loading']");
        }

        public IWebElement ReturnMeWebElement(By by)
        {
            bool avaialable = false;
            int counter = 0;
            while(counter<=20)
            {
                if (driver.FindElement(by).Displayed)
                {
                    avaialable = true;
                    return driver.FindElement(by);

                }
                Thread.Sleep(500);
                counter = counter + 1;
            }

            Assert.True(false);
            return driver.FindElement(by);
            
        }



            //Actons
            /// <summary>
            /// Loading the Technical Validation Page and validating the header text is displayed.
            /// Passing URL and details through the object from the JSON file
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public XPOD_HomePage_Header Login_XPOD(Object value)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(value, "BVT_TestData");
            var url = data["URL"];
            driver.Navigate().GoToUrl(url.ToString());
            Assert.True(txt_page_header().Displayed);            
            return new XPOD_HomePage_Header(driver); 
        }
  
        /// <summary>
        /// Validating different attributes in the Home Page
        /// Dell Logo,Welcome notes and user name,Technical Validation Submission text validations
        /// full db search textbox is enabled validations
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Header Field_Validations()
        {
            CommonMethods.WebdriverWait_ElementClickable(driver, DellLogo());
            Assert.True(DellLogo().Displayed);
            Assert.True(Txt_Username().Displayed);
            Assert.True(Txt_TechValidSub().Displayed);
            Assert.True(TextBox_Fulldb_Search().Enabled);
            return new XPOD_HomePage_Header(driver);
        }
        /// <summary>
        /// Method to click on the validation list button
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Header Method_Clicking_ValidationListButton()
        {
            Btn_ValidationList().Click();

            return new XPOD_HomePage_Header(driver);
        }
       
        public XPOD_HomePage_Header EnterSearchElement_FullDbSearch(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "BVT_TestData");
            var searchval = data["Searchvalue"];
            TextBox_Fulldb_Search().SendKeys(searchval.ToString());
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_ElementClickable(driver, FullDbSearch_SearchBtn());
            FullDbSearch_SearchBtn().Click();            
            return new XPOD_HomePage_Header(driver);
        }
        public XPOD_HomePage_Header launchBrowser()
        {
            PageBase page = new PageBase();
            return new XPOD_HomePage_Header(driver);
        }
        

      
    }
}
