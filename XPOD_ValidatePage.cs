using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;
using Xunit;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_ValidatePage : PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_ValidatePage(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

       
        public IWebElement approveBtn()
        {
            return driver.FindElement(By.Id("btnApprove1"));

        }

        public IWebElement pendingBtn()
        {
            return driver.FindElement(By.Id("btnPending"));

        }

        public IWebElement deniedBtn()
        {
            return driver.FindElement(By.Id("btnDeny"));

        }

        public IWebElement cancelledBtn()
        {
            return driver.FindElement(By.Id("btnCancel"));

        }

        public IWebElement releaseCossacks()
        {
            return driver.FindElement(By.XPath("//*[@id='tblMain']/tbody/tr[5]/td/input[5]"));

        }

        public IWebElement Btn_AddComments()
        {
            return driver.FindElement(By.Id("btnComments"));

        }

        public IWebElement exitBtn()
        {
            return driver.FindElement(By.XPath("//input[@value='Exit']")); ;

        }
        public IWebElement Btn_Validate()
        {
            return driver.FindElement(By.Id("btnValidate"));
        }
        public IWebElement dd_Ordertype()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Order Type')]//following::select[1]"));
        }
        public IWebElement TextArea_Comments()
        {
            return driver.FindElement(By.Id("txtComments"));
        }
        public IWebElement Link_InsertApprovedValRes()
        {
            return driver.FindElement(By.LinkText("Insert Approved Validation Response"));
        }
        public IWebElement Link_InsertPendingValRes()
        {
            return driver.FindElement(By.LinkText("Insert Pending Validation Response"));
        }
        public IWebElement Link_InsertDeniedValRes()
        {
            return driver.FindElement(By.LinkText("Insert Denied Validation Response"));
        }
        public IWebElement Link_AddNewRespTemp()
        {
            return driver.FindElement(By.LinkText("Add New Response Template"));
        }
        public IWebElement Link_EditExistValTemp()
        {
            return driver.FindElement(By.LinkText("Edit Existing Validation Response"));
        }
        public IWebElement Btn_Close()
        {
            return driver.FindElement(By.XPath("//input[@value='Close']"));
        }


            public XPOD_ValidatePage validateXPOD()
        {
            CommonMethods.Page_Scrolldown(driver);
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            Btn_Validate().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.ScrollTillElementViible(driver, deniedBtn());
            CommonMethods.WebdriverWait_TillElementReady(driver, deniedBtn());
            Assert.True(new XPOD_ValidatePage(driver).deniedBtn().Displayed);
            Assert.True(new XPOD_ValidatePage(driver).approveBtn().Displayed);
            Assert.True(new XPOD_ValidatePage(driver).cancelledBtn().Displayed);
            Assert.True(new XPOD_ValidatePage(driver).pendingBtn().Displayed);
            //Assert.True(new XPOD_ValidatePage(driver).releaseCossacks().Displayed);
            Assert.True(new XPOD_ValidatePage(driver).Btn_AddComments().Displayed);
            Assert.True(new XPOD_ValidatePage(driver).exitBtn().Displayed);
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_ValidatePage Method_RightClickComments()
        {
            CommonMethods.Page_Scrolldown(driver);
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            
            Btn_Validate().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.Page_Scrolldown(driver);
            Actions act = new Actions(driver);
            act.ContextClick(TextArea_Comments()).Build().Perform();
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_ValidatePage Method_Validate_ValidateRightClickOption()
        {
            Assert.True(Link_AddNewRespTemp().Displayed);
            Assert.True(Link_InsertApprovedValRes().Displayed);
            Assert.True(Link_InsertPendingValRes().Displayed);
            Assert.True(Link_InsertDeniedValRes().Displayed);
            Assert.True(Link_EditExistValTemp().Displayed);
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_ValidationResponse_Page Method_Click_ValidateOptions(String ValOption)
        {
           switch(ValOption)
            {
                case "Insert Approved Validation Response":
                    Link_InsertApprovedValRes().Click();
                    driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                    return new XPOD_ValidationResponse_Page(driver);
                case "Insert Pending Validation Response":
                    Link_InsertPendingValRes().Click();
                    driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                    return new XPOD_ValidationResponse_Page(driver);
                case "Insert Denied Validation Response":
                    Link_InsertDeniedValRes().Click();
                    driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                    return new XPOD_ValidationResponse_Page(driver);
                case "Add New Response Template":
                    Link_AddNewRespTemp().Click();
                    driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                    return new XPOD_ValidationResponse_Page(driver);
                case "Edit Existing Validation Response":
                    Link_EditExistValTemp().Click();
                    driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                    return new XPOD_ValidationResponse_Page(driver);
                default:
                    Assert.True(false);
                    return new XPOD_ValidationResponse_Page(driver);
                    break; 
            }            

        }
        public XPOD_ValidatePage Method_Validate_SelectedResComment(Object DataObj,String TestName,String RespOption)
        {
            var Data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            String ValRespComments = Data[RespOption].ToString();
            String Respcom = TextArea_Comments().GetAttribute("value");
            Assert.Contains(ValRespComments, Respcom);
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_General_StaticEle_Page Method_Click_AddCommentsButton()
        {
            Btn_AddComments().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Close());
            Assert.True(driver.FindElement(By.XPath("//p[contains(text(),'Your comments have been added to this Validation R')]")).Displayed);
            Assert.True(Btn_Close().Enabled);
            Btn_Close().Click();
            return new XPOD_General_StaticEle_Page(driver);
        }
        public XPOD_ValidatePage Rightclick()
        {
            CommonMethods.Page_Scrolldown(driver);
            Actions act = new Actions(driver);
            act.ContextClick(TextArea_Comments()).Build().Perform();            
            return new XPOD_ValidatePage(driver);
        }
        public XPOD_ValidatePage Method_Validate_ResponseComment(String Comment)
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, TextArea_Comments());
            if((TextArea_Comments().GetAttribute("value").Equals(Comment.Trim()) )||(TextArea_Comments().GetAttribute("value").Contains(Comment)))
            {
                Assert.True(true);
                return new XPOD_ValidatePage(driver);
            }
            Assert.True(false);
            return new XPOD_ValidatePage(driver);
        }
    }
}

