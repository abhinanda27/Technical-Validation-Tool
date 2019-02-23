using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    class XPOD_EditExistingValRespTemp_Page
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_EditExistingValRespTemp_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Text_ProductLine()
        {
            return driver.FindElement(By.Id("lblProductLineLabel"));
        }
        public IWebElement Text_SalesRegion()
        {
            return driver.FindElement(By.Id("lblRegionLabel"));
        }
        public IWebElement Text_ValRespStatus()
        {
            return driver.FindElement(By.Id("lblValidationResponseStatusLabel"));
        }
        public IWebElement Radio_EqualLogic()
        {
            return driver.FindElement(By.Id("rblProductLineSelect_0"));
        }
        public IWebElement Radio_DellStorage()
        {
            return driver.FindElement(By.Id("rblProductLineSelect_1"));
        }
        public IWebElement Radio_AMER()
        {
            return driver.FindElement(By.Id("rblRegionSelect_0"));
        }
        public IWebElement Radio_APJ()
        {
            return driver.FindElement(By.Id("rblRegionSelect_1"));
        }
        public IWebElement Radio_EMEA()
        {
            return driver.FindElement(By.Id("rblRegionSelect_2"));
        }
        public IWebElement Radio_Denied()
        {
            return driver.FindElement(By.Id("rblValidationResponseStatusSelect_0"));
        }
        public IWebElement Radio_Approved()
        {
            return driver.FindElement(By.Id("rblValidationResponseStatusSelect_1"));
        }
        public IWebElement Radio_Pending()
        {
            return driver.FindElement(By.Id("rblValidationResponseStatusSelect_2"));
        }
        public IWebElement Btn_Ok()
        {
            return driver.FindElement(By.Id("btnEditFormSubmitProductlineAndRegionChoices"));
        }
        public IWebElement Radio_Cancel()
        {
            return driver.FindElement(By.XPath("//input[@value='Cancel']"));
        }
        public IWebElement TextArea_ResponseList()
        {
            return driver.FindElement(By.Id("lbValidationResponses"));
        }
        public IWebElement Textbox_TemplateName()
        {
            return driver.FindElement(By.Id("txtValidationResponseTemplateName"));
        }
        public IWebElement Textbox_TemplateDescription()
        {
            return driver.FindElement(By.Id("txtEditValidationRequestText"));
        }
        public IWebElement Btn_Add()
        {
            return driver.FindElement(By.Id("btnSubmitEditExistingValidationResponse"));
        }


        //Methods
        public XPOD_EditExistingValRespTemp_Page Method_EditRespTemp_FieldValidations()
        {
            Assert.True(Text_ProductLine().Displayed);
            Assert.True(Text_SalesRegion().Displayed);
            Assert.True(Text_ValRespStatus().Displayed);
            Assert.True(Radio_DellStorage().Enabled);
            Assert.True(Radio_EqualLogic().Enabled);
            Assert.True(Radio_AMER().Enabled);
            Assert.True(Radio_APJ().Enabled);
            Assert.True(Radio_EMEA().Enabled);
            Assert.True(Radio_Denied().Enabled);
            Assert.True(Radio_Approved().Enabled);
            Assert.True(Radio_Pending().Enabled);
            return new XPOD_EditExistingValRespTemp_Page(driver);
        }
        public XPOD_EditExistingValRespTemp_Page SelectTemplateOptions(String Status,String ProdLine,String Region)
        {
            switch(Status)
            {
                case "Denied":
                    Radio_Denied().Click();
                    break;
                case "Pending":
                    Radio_Pending().Click();
                    break;
                case "Approved":
                    Radio_Approved().Click();
                    break;
            }
            switch(ProdLine)
            {
                case "EqualLogic":
                    Radio_EqualLogic().Click();
                    break;
                case "Dell Storage":
                    Radio_DellStorage().Click();
                    break;
            }
            switch(Region)
            {
                case "AMER":
                    Radio_AMER().Click();
                    break;
                case "APJ":
                    Radio_APJ().Click();
                    break;
                case "EMEA":
                    Radio_EMEA().Click();
                    break;
            }
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Ok());
            Btn_Ok().Click();
            return new XPOD_EditExistingValRespTemp_Page(driver);
        }
        public XPOD_EditExistingValRespTemp_Page Method_SelectRespTemp(String TempName)
        {
            SelectElement RespList = new SelectElement(TextArea_ResponseList());
            RespList.SelectByText(TempName);
            return new XPOD_EditExistingValRespTemp_Page(driver);
        }
        public XPOD_EditExistingValRespTemp_Page Method_EditTempName(String TempName)
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Textbox_TemplateName());
            Textbox_TemplateName().Clear();
            CommonMethods.WebdriverWait_TillElementReady(driver, Textbox_TemplateName());
            Textbox_TemplateName().SendKeys(TempName);
            return new XPOD_EditExistingValRespTemp_Page(driver);
        }
        public XPOD_EditExistingValRespTemp_Page Method_EditTempDescp(String TestTempDesc)
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Textbox_TemplateDescription());
            Textbox_TemplateDescription().Clear();
            CommonMethods.WebdriverWait_TillElementReady(driver, Textbox_TemplateDescription());
            Textbox_TemplateDescription().SendKeys(TestTempDesc);
            return new XPOD_EditExistingValRespTemp_Page(driver);
        }
        public XPOD_ValidatePage Click_BtnAdd()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Add());
            Btn_Add().Click();
            return new XPOD_ValidatePage(driver);
        }


    }
}
