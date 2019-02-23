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
    public class XPOD_General_RI_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_General_RI_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }
      

        public IWebElement General_tab()
        {
            return driver.FindElement(By.LinkText("General"));
        }
        public IWebElement Lbl_RequstInfo()
        {
            return driver.FindElement(By.XPath("//strong[contains(text(),'Request Information')]"));
        }

        public IWebElement Lbl_RequestNo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Request Number')]"));
        }
        public IWebElement Txtbox_RequestNo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Request Number')]//following::input[1]"));
        }
        public IWebElement Lbl_VersionNo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Version Number')]"));
        }
        public IWebElement Txtbox_VersionNo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Version Number')]//following::input[1]"));
        }

        public IWebElement Lbl_Status()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Status')]"));
        }
        public IWebElement dd_Status()
        {
            return driver.FindElement(By.XPath("//select[@id='status']"));
        }
        public IWebElement Lbl_Ordertype()
        {
           return driver.FindElement(By.XPath("//label[contains(text(),'Order Type')]"));
        }
        public IWebElement dd_Ordertype()
        {
            return ReturnMeWebElement(By.XPath("//label[contains(text(),'Order Type')]//following::select[1]"));            
        }

        public IWebElement Lbl_ProductLine()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Product Line')]"));
        }
        public IWebElement Txtbox_ProductLine()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Product Line')]//following::input[1]"));
        }
        public IWebElement Lbl_CreatedBy()
        {
           return driver.FindElement(By.XPath("//label[contains(text(),'Created By')]"));
        }
        public IWebElement Txtbox_CreatedBy()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Created By')]//following::input[1]"));
        }
        public IWebElement Lbl_AssignedTo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Assigned To')]"));
        }
        public IWebElement Txtbox_AssignedTo()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Assigned To')]//following::input[1]"));
        }
        public IWebElement Lbl_SolutionID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Solution Id')]"));
        }
        public IWebElement Txtbox_SolutionID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Solution Id')]//following::input[1]"));
        }
        public IWebElement Lbl_GroupID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Group Id')]"));
        }
        public IWebElement Txtbox_GroupID()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Group Id')]//following::input[1]"));
        }
        public IWebElement Lbl_ApprovalLevel()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Approval Level')]"));
        }
        public IWebElement Txtbox_ApprovalLevel()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Approval Level')]//following::input[1]"));
        }
        public IWebElement Lbl_GiiQuote()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Gii Quote Id')]"));
        }
        public IWebElement Txtbox_GiiQuote()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Gii Quote Id')]//following::input[1]"));
        }
        public IWebElement Lbl_DellStarQuote()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Dellstar Quote Id')]"));
        }
        public IWebElement Txtbox_DellStarQuote()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Dellstar Quote Id')]//following::input[1]"));
        }
        public IWebElement Lbl_Region()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Region')]"));
        }
        public IWebElement dd_Region()
        {
            return ReturnMeWebElement(By.XPath("//label[contains(text(),'Region')]//following::select[1]"));
        }
        public IWebElement Lbl_Product()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Products To Validate')]"));
        }
        public IWebElement dd_Product()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Products To Validate')]//following::div[1]"));
        }
        public IWebElement dd_prodToValidate_Gen(String element)
        {
            return driver.FindElement(By.XPath("//span[text()='" + element + "']//preceding::mat-pseudo-checkbox[1]"));
        }


        //Actions

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
        /// General_RIField_Validations methos to validate different elements displayed in the 
        /// request information page.
        /// </summary>
        /// <returns></returns>
        public XPOD_General_RI_Page General_RIFeild_Validations()
        {
            Assert.True(General_tab().Displayed);
            Assert.True(Lbl_RequstInfo().Displayed);
            Assert.True(Lbl_RequestNo().Displayed);
            Assert.False(Txtbox_RequestNo().Enabled);
            Assert.True(Lbl_VersionNo().Displayed);
            Assert.False(Txtbox_VersionNo().Enabled);
            Assert.True(Lbl_Status().Displayed);
            Assert.False(dd_Status().Enabled);
            Assert.True(Lbl_Ordertype().Displayed);
            Assert.True(dd_Ordertype().Enabled);
            Assert.True(Lbl_ProductLine().Displayed);
            Assert.False(Txtbox_ProductLine().Enabled);
            Assert.True(Lbl_CreatedBy().Displayed);
            Assert.False(Txtbox_CreatedBy().Enabled);
            Assert.True(Lbl_AssignedTo().Displayed);
            Assert.False(Txtbox_AssignedTo().Enabled);

            Assert.True(Lbl_SolutionID().Displayed);
            Assert.False(Txtbox_SolutionID().Enabled);
            Assert.True(Lbl_GroupID().Displayed);
            Assert.False(Txtbox_GroupID().Enabled);
            Assert.True(Lbl_ApprovalLevel().Displayed);
            Assert.False(Txtbox_ApprovalLevel().Enabled);
            Assert.True(Lbl_GiiQuote().Displayed);
            Assert.False(Txtbox_GiiQuote().Enabled);
            Assert.True(Lbl_DellStarQuote().Displayed);
            Assert.False(Txtbox_DellStarQuote().Enabled);
            Assert.True(Lbl_Region().Displayed);
            Assert.True(dd_Region().Enabled);
            Assert.True(Lbl_Product().Displayed);
            Assert.True(dd_Product().Enabled);

            return new XPOD_General_RI_Page(driver);
        }
        /// <summary>
        /// This method is to switch back from Gen_RI Page to General Base Static Page
        /// </summary>
        /// <returns></returns>
        public XPOD_General_StaticEle_Page Switching_GeneralBasePage()
        {
            return new XPOD_General_StaticEle_Page(driver);
        }
        /// <summary>
        /// This method is to edit the fields the editable fields in General Tab
        /// Three frields are editable. Giving random values to those fields
        /// </summary>
        /// <returns></returns>
        public XPOD_General_RI_Page Method_EditFields(Object DataObj)
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");                        
            SelectElement OrdeType = new SelectElement(dd_Ordertype());
            OrdeType.SelectByText(data["EditOrdeType"].ToString());

            SelectElement Region = new SelectElement(dd_Region());
            Region.SelectByText(data["EditRegion"].ToString());
                                   
            return new XPOD_General_RI_Page(driver);
        }
        public XPOD_General_RI_Page Method_Validate_EditedFields(Object DataObj)
        {

            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");
            SelectElement OrderType = new SelectElement(dd_Ordertype());            
            String strOrdertypeOption = OrderType.SelectedOption.Text.Trim();
            String strEditOrdertype = data["EditOrdeType"].ToString();
            Assert.Equal(strEditOrdertype,strOrdertypeOption);
            SelectElement Region = new SelectElement(dd_Region());
            Assert.Equal((data["EditRegion"].ToString()), (Region.SelectedOption.Text.Trim()));

            return new XPOD_General_RI_Page(driver);
        }

        public Dictionary<String,String> GetRIData_FieldValues()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            var RIData = new Dictionary<string, string>();
            RIData.Add("RequestNo",Txtbox_RequestNo().GetAttribute("value"));
            RIData.Add("Version", Txtbox_VersionNo().GetAttribute("value"));
            SelectElement ddstatus = new SelectElement(dd_Status());
            RIData.Add("Status", ddstatus.SelectedOption.Text);
            SelectElement ddOrder = new SelectElement(dd_Ordertype());
            RIData.Add("OrderType", ddOrder.SelectedOption.Text);
            RIData.Add("ProductLine", Txtbox_ProductLine().GetAttribute("value"));
            RIData.Add("AssignedTo", Txtbox_AssignedTo().GetAttribute("value"));
            RIData.Add("SolutionID", Txtbox_SolutionID().GetAttribute("value"));

            if (Txtbox_GroupID().GetAttribute("value")=="")
            {
                RIData.Add("GroupID", "None");
            }
            else
            { 
                RIData.Add("GroupID", Txtbox_GroupID().GetAttribute("value"));
            }

            return RIData;

        }

        public XPOD_General_StaticEle_Page BtnsandFields()
        {


            Assert.True(dd_Ordertype().Enabled);
            Assert.True(dd_Region().Enabled);
            Assert.True(dd_Product().Enabled);
            CommonMethods.Page_Scrolldown(driver);

            Assert.True((new XPOD_Genral_OI_Page(driver).Txtbox_DealID().Enabled));
            Assert.False(Txtbox_RequestNo().Enabled);
            Assert.False(Txtbox_GroupID().Enabled);
            Assert.False(Txtbox_VersionNo().Enabled);
            Assert.False(Txtbox_SolutionID().Enabled);
            Assert.False(Txtbox_ApprovalLevel().Enabled);
            Assert.False(dd_Status().Enabled);
            Assert.False(Txtbox_GiiQuote().Enabled);
            Assert.False(Txtbox_DellStarQuote().Enabled);
            Assert.False(Txtbox_CreatedBy().Enabled);
            Assert.False(Txtbox_AssignedTo().Enabled);
            Assert.False((new XPOD_Genral_OI_Page(driver).Txtbox_OpertunityName().Enabled));
            Assert.False((new XPOD_Genral_OI_Page(driver).Txtbox_CustomerName().Enabled));
            Assert.False((new XPOD_Genral_OI_Page(driver).Txtbox_PartnerName().Enabled));
            Assert.False((new XPOD_Genral_OI_Page(driver).Txtbox_CustAffID().Enabled));
            Assert.False((new XPOD_Genral_OI_Page(driver).Txtbox_PartAffID().Enabled));

            Assert.True((new XPOD_Genral_OI_Page(driver).Btn_Save().Enabled));
            Assert.True((new XPOD_Genral_OI_Page(driver).Btn_SaveAndNotify().Enabled));
            Assert.True((new XPOD_Genral_OI_Page(driver).Btn_Assign().Enabled));
            Assert.True((new XPOD_Genral_OI_Page(driver).Btn_Validate().Enabled));
            Assert.True((new XPOD_Genral_OI_Page(driver).Btn_ViewSubmission().Enabled));

            CommonMethods.Page_ScrollUp(driver);
            CommonMethods.WebdriverWait_ElementClickable(driver, new XPOD_Genral_OI_Page(driver).btnValidationList());


            return new XPOD_General_StaticEle_Page(driver);
        }


    }
}
