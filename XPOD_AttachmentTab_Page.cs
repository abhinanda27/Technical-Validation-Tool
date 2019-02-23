using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechnicalValidationTool.TestAutomation.Base;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_AttachmentTab_Page:PageBase
    {
        public IWebDriver driver;

        public XPOD_AttachmentTab_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
        }
        public IWebElement Lbl_NoAttachment()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'--No Attachments--')]"));
        }
        public IWebElement Lbl_Attachment()
        {
            return driver.FindElement(By.XPath("//h5[contains(text(),'Attachments')]"));
        }
        public IWebElement Lbl_Attachment_Name()
        {
            return driver.FindElement(By.XPath("//h5[contains(text(),'Attachments')]//following::td[1]"));
        }
        public IWebElement Btn_DownloadArrow()
        {
            return driver.FindElement(By.XPath("//i[@class='fa fa-download']"));
        }
        public XPOD_AttachmentTab_Page AttachmentTab_Validation()
        {
            if(Lbl_NoAttachment().Displayed)
            {
                return new XPOD_AttachmentTab_Page(driver);
            }
            else
            {
                Assert.True(Lbl_Attachment().Displayed);
                Assert.True(Lbl_Attachment_Name().Displayed);
                Assert.True(Btn_DownloadArrow().Enabled);
                return new XPOD_AttachmentTab_Page(driver);
            }
            
        }
    }
}
