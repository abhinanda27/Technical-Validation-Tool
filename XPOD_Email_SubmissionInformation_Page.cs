using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    class XPOD_Email_SubmissionInformation_Page
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_Email_SubmissionInformation_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        //Customer & Solution  Informtion Elements
        public IWebElement Headtxt_DellStorageSubInfo()
        {
            return driver.FindElement(By.XPath("//h4[contains(text(),'Dell Storage Submission Information')]"));
        }
        public IWebElement Headtxt_EqualLogicSubInfo()
        {
            return driver.FindElement(By.XPath("//h4[contains(text(),'EqualLogic Submission Information')]"));
        }
        public IWebElement LblHead_CustomerSolutionInfo()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Customer and Solution Info')]"));
        }
        public IWebElement Lbl_EndUser_Custname()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'End User Customer Name')]"));
        }
        public IWebElement Text_EndUser_Custname()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'End User Customer Name')]//following::div[1]"));
        }
        public IWebElement Lbl_ChannelPartnerName()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Channel Partner Name')]"));
        }
        public IWebElement Text_ChannelPartnerName()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Channel Partner Name')]//following::div[1]"));
        }
        public IWebElement Lbl_SolutionIDs()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Solution ID(s)')]"));
        }
        public IWebElement Text_SolutionIDs()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Solution ID(s)')]//following::div[1]"));
        }
        public IWebElement Lbl_SolutionSource()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Solution Source')]"));
        }
        public IWebElement Lbl_SFDCDealID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'SFDC Deal ID')]"));
        }
        public IWebElement Text_SFDCDealID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'SFDC Deal ID')]//following::div[1]"));
        }
        public IWebElement Lbl_Endusr_CustAffID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'End User Customer Affinity ID')]"));
        }
        public IWebElement Text_Enduser_CustAffID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'End User Customer Affinity ID')]//following::div[1]"));
        }
        public IWebElement Lbl_ChanelPart_AffID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Channel Partner Affinity ID')]"));
        }
        public IWebElement Text_ChanelPart_AffID()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Channel Partner Affinity ID')]//following::div[1]"));
        }
        public IWebElement Lbl_ValReqNumber()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Validation Request Number')]"));
        }
        public IWebElement Text_ValReqNumber()
        {
            return driver.FindElement(By.XPath("//div[contains(text(),'Validation Request Number')]//following::div[1]"));
        }
        public IWebElement Header_IntroductionSec()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_header'][contains(text(),'Introduction')]"));
        }
        public IWebElement Header_ContactSec()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_header'][contains(text(),'Contact Info')]"));
        }
        public IWebElement Header_ReplicationInfoSec()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_header'][contains(text(),'Replication Info')]"));
        }
        public IWebElement Header_SolutionInfoSec()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_header'][text()='Solution Info']"));
        }
        public IWebElement Header_UpgradeSec()
        {
            return driver.FindElement(By.XPath("//div[@class='summary_header'][text()='Upgrade']"));
        }


        //Methods
        public XPOD_Email_SubmissionInformation_Page Method_EmailCustSolutioinInfo_Validation(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            
            Assert.True(LblHead_CustomerSolutionInfo().Displayed);
            Assert.True(Lbl_EndUser_Custname().Displayed);
            Assert.Equal(OIDataObj["CustomerName"].Trim(),Text_EndUser_Custname().Text.Trim());
            Assert.True(Lbl_ChannelPartnerName().Displayed);
            Assert.Equal(OIDataObj["ChanPartName"].Trim(), Text_ChannelPartnerName().Text.Trim());
            Assert.True(Lbl_SolutionIDs().Displayed);
            Assert.Equal(RIDataObj["SolutionID"].Trim(), Text_SolutionIDs().Text.Trim());
            Assert.True(Lbl_SolutionSource().Displayed);
            Assert.True(Lbl_SFDCDealID().Displayed);
            Assert.Equal(OIDataObj["SFDCDealID"].Trim(), Text_SFDCDealID().Text.Trim());
            Assert.True(Lbl_Endusr_CustAffID().Displayed);
            Assert.Equal(OIDataObj["CustAffinityID"].Trim(), Text_Enduser_CustAffID().Text.Trim());
            Assert.True(Lbl_ChanelPart_AffID().Displayed);
            Assert.Equal(OIDataObj["ChanPartAffID"].Trim(), Text_ChanelPart_AffID().Text.Trim());
            Assert.True(Lbl_ValReqNumber().Displayed);
            Assert.Equal(RIDataObj["RequestNo"].Trim(), Text_ValReqNumber().Text.Trim());

            return new XPOD_Email_SubmissionInformation_Page(driver);
        }

        public XPOD_Email_SubmissionInformation_Page Method_OtherEmailSectionValidation(Dictionary<String, String> RIDataObj)
        {
            if (RIDataObj["ProductLine"].Contains("EqualLogic"))
            {
                Assert.True(Headtxt_EqualLogicSubInfo().Displayed);
            }
            else
            {
                Assert.True(Headtxt_DellStorageSubInfo().Displayed);
            }            
            Assert.True(Header_IntroductionSec().Displayed);
            Assert.True(Header_SolutionInfoSec().Displayed);
            Assert.True(Header_ContactSec().Displayed);
            //Assert.True(Header_ReplicationInfoSec().Displayed);
            if (RIDataObj["OrderType"].Contains("Upgrade"))
            {
                Assert.True(Header_UpgradeSec().Displayed);
            }
            return new XPOD_Email_SubmissionInformation_Page(driver);
        }
        

    }
}
