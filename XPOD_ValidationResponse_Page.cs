using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;
using Xunit;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_ValidationResponse_Page
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_ValidationResponse_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Lbl_ProductLine()
        {
            return driver.FindElement(By.Id("lblProductLineLabel"));
        }
        public IWebElement Lbl_SalesRegion()
        {
            return driver.FindElement(By.Id("lblRegionLabel"));
        }
        public IWebElement Btn_Ok()
        {
            return driver.FindElement(By.Id("btnSubmitProductlineAndRegionChoices"));
        }
        public IWebElement Btn_Cancel()
        {
            return driver.FindElement(By.XPath("//input[@value='Cancel']"));
        }
        public IWebElement Radio_EqualLogic()
        {
            return driver.FindElement(By.Id("rblProductLineSelect_0"));
        }
        public IWebElement Radio_DellStorage()
        {
            return driver.FindElement(By.Id("rblProductLineSelect_1"));
        }
        public IWebElement Radio_AmCan()
        {
            return driver.FindElement(By.Id("rblRegionSelect_0"));
        }
        public IWebElement Radio_APJASIA()
        {
            return driver.FindElement(By.Id("rblRegionSelect_1"));
        }
        public IWebElement Radio_EMEAEURO()
        {
            return driver.FindElement(By.Id("rblRegionSelect_2"));
        }
        public IWebElement Textbox_Search()
        {
            return driver.FindElement(By.Id("txtsearch"));
        }
        public IWebElement MultiSelect_Resp()
        {
            return driver.FindElement(By.Id("lbValidationResponses"));
        }
        public IWebElement Btn_Add_Resp()
        {
            return driver.FindElement(By.Id("btnAddValidationResponse"));
        }
        
        public XPOD_ValidationResponse_Page Method_ValidatePageFields()
        {
            Assert.True(Lbl_ProductLine().Displayed);
            Assert.True(Lbl_SalesRegion().Displayed);
            Assert.True(Radio_EqualLogic().Enabled);
            Assert.True(Radio_DellStorage().Enabled);
            Assert.True(Radio_AmCan().Enabled);
            Assert.True(Radio_APJASIA().Enabled);
            Assert.True(Radio_EMEAEURO().Enabled);
            Assert.True(Btn_Cancel().Displayed);
            Assert.True(Btn_Ok().Displayed);
            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidationResponse_Page Method_Click_BtnOk()
        {
            Btn_Ok().Click();
            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidationResponse_Page Method_SelectProductLineandRegioin(String ProdLine,String Region)
        {
            switch(ProdLine)
            { 
                case "EqualLogic":
                    Radio_EqualLogic().Click();
                    break;
                case "Dell Storage":
                    Radio_DellStorage().Click();
                    break;                                  

             }
            switch (Region)
            {
                case "AMER":
                    Radio_AmCan().Click();
                    break;
                case "APJ":
                    Radio_APJASIA().Click();
                    break;
                case "EMEA":
                    Radio_EMEAEURO().Click();
                    break;
            }

            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidationResponse_Page Method_ValidateResponsePageFields()
        {
            Assert.True(Textbox_Search().Displayed);
            Assert.True(MultiSelect_Resp().Displayed);
            Assert.True(Btn_Add_Resp().Displayed);
            Assert.True(Btn_Cancel().Displayed);            
            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidationResponse_Page Method_ValidateResponsesInMultiselectValues(Object DataObj,String TestData,int NoResp)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestData);
            
            CommonMethods.WebdriverWait_ElementClickable(driver, MultiSelect_Resp());
            SelectElement options = new SelectElement(MultiSelect_Resp());
            IList<IWebElement> ViewOptions = options.Options;
            if (NoResp == 0)
       
            {
                
                foreach (var Ele in ViewOptions)
                {
                    Assert.Equal(data["0"].ToString().Trim(), Ele.Text.Trim());
                    break;
                }
            }
            else
            {
                for (int i = 1; i <= NoResp; i++)
                {
                    
                    String s = i.ToString();
                    int counter = 0;
                    foreach (var Ele in ViewOptions)
                    {
                        if ((data[s].ToString().Trim()).Equals(Ele.Text.Trim()))
                        {
                            counter = counter + 1;
                            break;
                        }
                    }
                    Assert.NotEqual(0, counter);
                }
            }
            return new XPOD_ValidationResponse_Page(driver);
        }

        public XPOD_ValidatePage Method_SelectResponse(String Resp)
        {
            SelectElement options = new SelectElement(MultiSelect_Resp());
            options.SelectByText(Resp);
            Btn_Add_Resp().Click();
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_ValidationResponse_Page Method_EmptyValResp_Validation()
        {
            String res = MultiSelect_Resp().Text;
            if(res == "")
            {
                Console.Write("No Template available for this category.Expected Behavior");
            }
            else
            {
                Console.Write("User Defined Templates are available for this category.");
            }
            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidationResponse_Page Method_Validate_SpecificValRespTemp(String TempName)
        {
            SelectElement options = new SelectElement(MultiSelect_Resp());
            IList<IWebElement> ViewOptions = options.Options;
            foreach(var Ele in ViewOptions)
            {
                if(Ele.Text==TempName)
                {
                    return new XPOD_ValidationResponse_Page(driver);
                }
            }
            Assert.True(false);
            return new XPOD_ValidationResponse_Page(driver);
        }
        public XPOD_ValidatePage Method_Click_BtnCancel()
        {
            Btn_Cancel().Click();
            return new XPOD_ValidatePage(driver);
        }
    }
            
    
}
