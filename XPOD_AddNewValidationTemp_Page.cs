using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    class XPOD_AddNewValidationTemp_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_AddNewValidationTemp_Page(IWebDriver Webdriverinstance)
        {
            driver = Webdriverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Txt_ValReqStatus()
        {
           return driver.FindElement(By.XPath("//*[contains(text(),'Validation Request Status')]"));
        }
        public IWebElement dd_ValReqStatus()
        {
            return driver.FindElement(By.Id("ddlValidationRequestStatus"));
        }
        public IWebElement dd_ProductLine()
        {
            return driver.FindElement(By.Id("ddlProductLine"));
        }
        public IWebElement dd_Region()
        {
            return driver.FindElement(By.Id("ddlRegion"));
        }
        public IWebElement Textbox_Name()
        {
            return driver.FindElement(By.Id("txtValidationResponseTemplateName"));
        }
        public IWebElement Text_ValRespText()
        {
            return driver.FindElement(By.XPath("//td[contains(text(),'New Validation Response Text:')]"));
        }
        public IWebElement TextArea_ValRespText()
        {
            return driver.FindElement(By.Id("txtNewValidationRequestText"));
        }
        public IWebElement Btn_Add()
        {
            return driver.FindElement(By.Id("btnAdd"));
        }
        public IWebElement Btn_Cancel()
        {
            return driver.FindElement(By.XPath("//input[@value='Cancel']"));
        }
        
        public IWebElement Lbl_TempAlreadyExisit()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'There is already an existing Validation Reponse that has this name')]"));
        }
        public IWebElement Btn_CloseTempAlreadyExist()
        {
            return driver.FindElement(By.Id("btnValidationResponseTemplateAlreadyExistsViewButton"));
        }
        //Methods

        public XPOD_AddNewValidationTemp_Page Method_AddNewValResp_PageFields_Validation()
        {
            Assert.True(Txt_ValReqStatus().Displayed);
            Assert.True(dd_ValReqStatus().Displayed);
            Assert.True(dd_ProductLine().Displayed);
            Assert.True(dd_Region().Displayed);
            Assert.True(TextArea_ValRespText().Displayed);
            Assert.True(Text_ValRespText().Displayed);
            Assert.True(Btn_Add().Displayed);
            Assert.True(Btn_Cancel().Displayed);
            return new XPOD_AddNewValidationTemp_Page(driver);
        }
        public XPOD_AddNewValidationTemp_Page Method_ddValReqstatus_Validation()
        {
            SelectElement dd_Status = new SelectElement(dd_ValReqStatus());
            try
            { 
                dd_Status.SelectByText("Denied");
                    dd_Status.SelectByText("Approved");
                dd_Status.SelectByText("Pending");
            }
            catch
            {
                Console.Write("The Dropdown dont have all the required Status");
                Assert.True(false);
            }
            return new XPOD_AddNewValidationTemp_Page(driver);

        }
        public XPOD_AddNewValidationTemp_Page Method_ddProductLine_Validation()
        {
            SelectElement dd_Prod = new SelectElement(dd_ProductLine());
            try
            {
                dd_Prod.SelectByText("EqualLogic");
                dd_Prod.SelectByText("Dell Storage");                
            }
            catch
            {
                Console.Write("The Dropdown dont have all the required ProductLine");
                Assert.True(false);
            }
            return new XPOD_AddNewValidationTemp_Page(driver);
        }
        public XPOD_AddNewValidationTemp_Page Method_ddRegion_Validation()
        {
            SelectElement ddRegion = new SelectElement(dd_Region());
            try
            {
                ddRegion.SelectByText("Americas / Canada (US / Canada / LATAM)");
                ddRegion.SelectByText("APJ > ASIA");
                ddRegion.SelectByText("EMEA > EURO");
            }
            catch
            {
                Console.Write("The Dropdown dont have all the required Regions");
                Assert.True(false);
            }
            return new XPOD_AddNewValidationTemp_Page(driver);
        }

        public XPOD_AddNewValidationTemp_Page CreateTemplate(String Status,String ProductLine,String Region)
        {
            SelectElement ddStatus = new SelectElement(dd_ValReqStatus());
            ddStatus.SelectByText(Status);
            SelectElement ddProduct = new SelectElement(dd_ProductLine());
            ddProduct.SelectByText(ProductLine);
            SelectElement ddReg = new SelectElement(dd_Region());
           switch(Region)
            {
                case "APJ":
                    ddReg.SelectByText("APJ > ASIA");
                    break;
                case "EMEA":
                    ddReg.SelectByText("EMEA > EURO");
                    break;
                default:
                    ddReg.SelectByText("Americas / Canada (US / Canada / LATAM)");
                    break;                
            }

            Textbox_Name().SendKeys("AutomationTest Template new");
            TextArea_ValRespText().SendKeys("Template Created for Test Automation Created Again and again");
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Add());
            Btn_Add().Click();

            return new XPOD_AddNewValidationTemp_Page(driver);
        }
        public XPOD_ValidatePage Validate_TempAlreadyExisit()
        {
            try
            {
                if (Lbl_TempAlreadyExisit().Displayed)
                {
                    Btn_CloseTempAlreadyExist().Click();
                    Btn_Cancel().Click();
                    return new XPOD_ValidatePage(driver);
                }
                else
                {                    
                    return new XPOD_ValidatePage(driver);
                }
            }
            catch
            {                
                return new XPOD_ValidatePage(driver);
            }
        }
        

    }
}
