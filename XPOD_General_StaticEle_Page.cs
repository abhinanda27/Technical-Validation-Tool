using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_General_StaticEle_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_General_StaticEle_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        //WebElements
        public IWebElement Btn_GeneralTab()
        {
            return driver.FindElement(By.LinkText("General"));
        }
        public IWebElement Btn_NotesTab()
        {
            return driver.FindElement(By.LinkText("Notes"));
        }
        public IWebElement Btn_ActivitiesTab()
        {
            return driver.FindElement(By.LinkText("Activities"));
        }
        public IWebElement Btn_InstallationTab()
        {
            return driver.FindElement(By.LinkText("Installation Info"));
        }
        public IWebElement Btn_AttachmentTab()
        {
            return driver.FindElement(By.LinkText("Attachments"));
        }

        //Actions

        
        /// <summary>
        /// Method to click on the Notes Tab
        /// </summary>
        /// <returns></returns>
        public XPOD_NotesTab_Page Clicking_NotesTab()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_NotesTab());           
            Btn_NotesTab().Click();           
            return new XPOD_NotesTab_Page(driver);
        }
        /// <summary>
        /// Method to click on the Activites tab and it will navigate to activity tab
        /// </summary>
        /// <returns></returns>
        public XPOD_ActivitesTab_Page Clicking_ActivitesTab()
        {
            Btn_ActivitiesTab().Click();
            return new XPOD_ActivitesTab_Page(driver);
        }

        /// <summary>
        /// Method to click on the Installation Section Tab and navigate
        /// </summary>
        /// <returns></returns>
        public XPOD_InstallationSec_Page Clicking_InstallationSec()
        {
            Btn_InstallationTab().Click();            
            return new XPOD_InstallationSec_Page(driver);
        }
        public XPOD_AttachmentTab_Page Clicking_AttachementTab()
        {
            Btn_AttachmentTab().Click();

            return new XPOD_AttachmentTab_Page(driver);
        }
        public XPOD_General_RI_Page SwitchingTo_GenRIPage()
        {
            Btn_GeneralTab().Click();
            return new XPOD_General_RI_Page(driver);
        }
        
    }
}
