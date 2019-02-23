using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.Helper;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;


namespace TechnicalValidationTool.TestAutomation.Page
{
    class XPOD_Genral_OI_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_Genral_OI_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        //Webelements
        public IWebElement Lbl_DealID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'SFDC Deal Id')]"));
        }
        public IWebElement Txtbox_DealID()
        {
            return ReturnMeWebElement(By.XPath("//label[contains(text(),'SFDC Deal Id')]//following::input[1]"));
        }

        public IWebElement Lbl_CustomerName()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Customer Name')]"));
        }
        public IWebElement Txtbox_CustomerName()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Customer Name')]//following::input[1]"));
        }
        public IWebElement Lbl_CustAffID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Customer Affinity Id')]"));
        }
        public IWebElement Txtbox_CustAffID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Customer Affinity Id')]//following::input[1]"));
        }
        public IWebElement Lbl_OpertunityName()
        {
           return driver.FindElement(By.XPath("//label[contains(text(),'Opportunity Name')]"));
        }
        public IWebElement Txtbox_OpertunityName()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Opportunity Name')]//following::input[1]"));
        }
        public IWebElement Lbl_PartnerName()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Partner Name')]"));
        }
        public IWebElement Txtbox_PartnerName()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Partner Name')]//following::input[1]"));
        }
        public IWebElement Lbl_PartAffID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Partner Affinity Id')]"));
        }
        public IWebElement Txtbox_PartAffID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Partner Affinity Id')]//following::input[1]"));
        }
        public IWebElement Lbl_Opertunity_Header()
        {
            return driver.FindElement(By.XPath("//strong[contains(text(),'Deal/Opportunity Information')]"));
        }
        public IWebElement Btn_Save()
        {
            return driver.FindElement(By.Id("btnSave"));           
        }
        public IWebElement Btn_SaveAndNotify()
        {
            return driver.FindElement(By.Id("btnSaveNotify"));
        }
        public IWebElement Btn_Assign()
        {
            return driver.FindElement(By.Id("btnAssign"));
        }
        public IWebElement Btn_Validate()
        {
            return driver.FindElement(By.Id("btnValidate"));
        }
        public IWebElement Btn_ViewSubmission()
        {
            return driver.FindElement(By.Id("btnViewSubmission"));
        }
        public IWebElement Header_GenralTab()
        {
            return driver.FindElement(By.LinkText("General"));
        }
        public IWebElement btnValidationList()
        {
            return driver.FindElement(By.Id("btnBack"));
        }


        //Methods-actions
        public IWebElement ReturnMeWebElement(By by)
        {
            bool avaialable = false;
            int counter = 0;
            while (counter <= 20)
            {
                if (driver.FindElement(by).Displayed && driver.FindElement(by).Enabled)
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

        /// <summary>
        /// This General_OIFeild_Validations method is to validate the Deal/Opertunity information
        /// populated in the General Opertunity information sections.
        /// </summary>
        /// <returns></returns>
        public XPOD_Genral_OI_Page General_OIFeild_Validations()
        {
            Assert.True(Lbl_Opertunity_Header().Displayed);
            Assert.True(Lbl_DealID().Displayed);
            Assert.True(Txtbox_DealID().Enabled);
            Assert.True(Lbl_CustomerName().Displayed);
            Assert.False(Txtbox_CustomerName().Enabled);
            Assert.True(Lbl_CustAffID().Displayed);
            Assert.False(Txtbox_CustAffID().Enabled);
            Assert.True(Lbl_OpertunityName().Displayed);
            Assert.False(Txtbox_OpertunityName().Enabled);
            Assert.True(Lbl_PartnerName().Displayed);
            Assert.False(Txtbox_PartnerName().Enabled);
            Assert.True(Lbl_PartAffID().Displayed);
            Assert.False(Txtbox_PartAffID().Enabled);

            return new XPOD_Genral_OI_Page(driver);
        }
        /// <summary>
        /// This method is to validate Gen Tab button for the Pending and submitted status xpods
        /// </summary>
        /// <returns></returns>
        public XPOD_Genral_OI_Page GeneralTabButton_Validations_PendingSubmissionXPODs()
        {
            Assert.True(Btn_Save().Enabled);
            Assert.True(Btn_Assign().Enabled);
            Assert.True(Btn_SaveAndNotify().Enabled);
            Assert.True(Btn_Validate().Enabled);
            Assert.True(Btn_ViewSubmission().Enabled);
            return new XPOD_Genral_OI_Page(driver);
        }
        /// <summary>
        /// This method is to validate the buttons in general tab for the Cancelled,Denied and 
        /// Approved XPODs
        /// </summary>
        /// <returns></returns>
        public XPOD_Genral_OI_Page GeneralTabButton_Validations_CanDenApprovedXPODs()
        {
            Thread.Sleep(2000);
            Assert.False(Btn_Save().Enabled);
            Assert.False(Btn_Assign().Enabled);
            Assert.False(Btn_SaveAndNotify().Enabled);
            Assert.False(Btn_Validate().Enabled);
            Assert.True(Btn_ViewSubmission().Enabled);
            return new XPOD_Genral_OI_Page(driver);
        }
        /// <summary>
        /// This method is to edit the editable field DealID
        /// </summary>
        /// <param name="DataObj"></param>
        public XPOD_Genral_OI_Page Method_EditDealID_Field(Object DataObj)
        {
            Txtbox_DealID().Clear();
            CommonMethods.Wait_TillTextbox_Clear(driver, Txtbox_DealID());
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");            
            Txtbox_DealID().SendKeys(data["EditDealID"].ToString());
            return new XPOD_Genral_OI_Page(driver);
        }
        public XPOD_Genral_OI_Page Mehod_ClickSaveButton()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Save());
            CommonMethods.Page_Scrolldown(driver);
            Btn_Save().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Save());
            return new XPOD_Genral_OI_Page(driver);
        }
        public XPOD_General_StaticEle_Page Method_SwitchingtoStaticPage()
        {
            Header_GenralTab().Click();
            return new XPOD_General_StaticEle_Page(driver);
        }
        public XPOD_Genral_OI_Page Method_Validate_EditedOIPageFields(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");
            String strEditDealID = data["EditDealID"].ToString();
            
            String strDealIDValue = Txtbox_DealID().GetAttribute("value");
            Assert.Equal(strEditDealID,strDealIDValue);
            return new XPOD_Genral_OI_Page(driver);
        }

        public Dictionary<String,String> GetOI_FieldValues()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_DealID());
            var OIData = new Dictionary<string, string>();            
            if (Txtbox_DealID().GetAttribute("value") == "")
            {
                OIData.Add("SFDCDealID", "none");
            }
            else
            {
                OIData.Add("SFDCDealID", Txtbox_DealID().GetAttribute("value"));
            }
            OIData.Add("CustomerName", Txtbox_CustomerName().GetAttribute("value"));
            OIData.Add("CustAffinityID", Txtbox_CustAffID().GetAttribute("value"));
            OIData.Add("OperName", Txtbox_OpertunityName().GetAttribute("value"));
            OIData.Add("ChanPartName", Txtbox_PartnerName().GetAttribute("value"));
            OIData.Add("ChanPartAffID", Txtbox_PartAffID().GetAttribute("value"));

            return OIData;
        }
        public void Method_Clik_BtnValidate()
        {
            Btn_Validate().Click();
        }
    }
}
