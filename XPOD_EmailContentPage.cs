using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using System.Linq;
using System.Threading;
using System.IO;
using OpenQA.Selenium.Support.Events;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_EmailContentPage
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_EmailContentPage(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Lbl_From()
        {
            return driver.FindElement(By.XPath("//label[text()='From'][@class='col-sm-1 col-form-label-sm']"));
        }
        public IWebElement Text_From()
        {
            return driver.FindElement(By.XPath("//label[text()='From'][@class='col-sm-1 col-form-label-sm']//following::label[1]"));
        }
        public IWebElement Lbl_To()
        {
            return driver.FindElement(By.XPath("//label[text()='To'][@class='col-sm-1 col-form-label-sm']"));
        }
        public IWebElement Text_To()
        {
            return driver.FindElement(By.XPath("//label[text()='To'][@class='col-sm-1 col-form-label-sm']//following::label[1]"));
        }
        public IWebElement Lbl_CC()
        {
            return driver.FindElement(By.XPath("//label[text()='CC'][@class='col-sm-1 col-form-label-sm']"));
        }
        public IWebElement Lbl_Subject()
        {
            return driver.FindElement(By.XPath("//label[text()='Subject'][@class='col-sm-1 col-form-label-sm']"));
        }
        public IWebElement Text_Subject()
        {
            return driver.FindElement(By.XPath("//label[text()='Subject'][@class='col-sm-1 col-form-label-sm']//following::label[1]"));
        }
        public IWebElement Lbl_Body()
        {
            return driver.FindElement(By.XPath("//label[text()='Body'][@class='col-sm-1 col-form-label-sm']"));
        }

        public IWebElement ViewValidationLink()
        {
            return driver.FindElement(By.LinkText("View Validation Request »"));
        }
        public IWebElement EBody_LblSolutionId()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//td[text()='SolutionId']"));
        }
        public IWebElement EBody_TextSolutionId()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//tr[2]//td[1]"));
        }
        public IWebElement EBody_LblVersion()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//td[text()='VersionNbr']"));
        }
        public IWebElement EBody_TextVersion()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//tr[2]//td[2]"));
        }
        public IWebElement EBody_LblStatus()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//td[text()='Status']"));
        }
        public IWebElement EBody_TextStatus()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//tr[2]//td[3]"));
        }
        public IWebElement EBody_LblLink()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//td[text()='Link']"));
        }
        public IWebElement EBody_TextLink()
        {
            return driver.FindElement(By.LinkText("Go to XPOD Submission"));
        }
        public IWebElement EBody_TextCustomer()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//tr[2]//td[7]"));
        }
        public IWebElement EBody_LblCustomer()
        {
            return driver.FindElement(By.XPath("//table[@id='tblHistoryTable']//td[text()='Customer']"));
        }

        public IWebElement Lbl_FORSECUSEONLY()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'FOR SEC USE ONLY')]"));
        }
        public IWebElement Btn_Validate()
        {
            return driver.FindElement(By.XPath("//a[contains(text(),'Validate')]"));
        }
        public IWebElement Btn_Assign()
        {
            return driver.FindElement(By.XPath("//a[contains(text(),'Assign')]"));
        }
        public IWebElement Link_ViewSysSummaryRep()
        {
            return driver.FindElement(By.LinkText("View System Summary Report"));
        }
        public IWebElement Link_ViewWebCST()
        {
            return driver.FindElement(By.LinkText("View WebCST"));
        }
        public IWebElement Link_DellSupportLink()
        {
            return driver.FindElement(By.LinkText("Dell Support Link"));
        }
        public IWebElement PendingStatus()
        {
            return driver.FindElement(By.XPath("//p[@class='bold']"));
        }

        public IWebElement PendingBodyDellStarQN()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Dell Star Quote Number')]"));
        }

        public IWebElement PendingBodyCustomerName()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Customer Name')]"));
        }

        public IWebElement PendingBodyInstallationAddress()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Installation Address')]"));
        }

        public IWebElement NoteHistory()
        {
            return driver.FindElement(By.XPath("//p[contains(text(),'Note History:')]"));
        }

        

        public IWebElement ViewLink()
        {
            return driver.FindElement(By.LinkText("View"));
        }

        public IWebElement ValidateLink()
        {
            return driver.FindElement(By.LinkText("Validate"));
        }

        //Methods
        public XPOD_EmailContentPage Method_ValidateEmailHeaderLabels()
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailHeaderFields_ForAssignedXPOD (Dictionary<String,String> RIDataObj, Dictionary<String,String> OIDataObj)
        {            
            //Assert.Equal(Text_From().Text.Trim(), "Rahul_Nagle@Dell.com");
            Assert.Contains(RIDataObj["AssignedTo"].Trim(),Text_To().Text.Trim());

            //String Subjectline="["+RIDataObj["ProductLine"]+" Validation Request "+RIDataObj["Status"] +"] Request Nbr: "+RIDataObj["RequestNo"] +" V. "+RIDataObj["Version"] +" | Customer: "+OIDataObj["CustomerName"] +" | SFDC DealId: "+OIDataObj["SFDCDealID"] +" | Display SSN/Order Type : /"+RIDataObj["OrderType"] +" | Solution: "+RIDataObj["SolutionID"] +" | GroupId: "+RIDataObj["GroupID"];

            Assert.Contains(RIDataObj["ProductLine"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(OIDataObj["SFDCDealID"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["OrderType"].Trim(), Text_Subject().Text.Trim());
            //Assert.Contains(RIDataObj["GroupID"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), Text_Subject().Text.Trim());

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_ValidateEmailHeaderFields_ForSubmittedCMLXPOD(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.NotNull(Text_From().Text.Trim());
            Assert.NotNull(Text_To().Text.Trim());

            //String Subjectline="["+RIDataObj["ProductLine"]+" Validation Request "+RIDataObj["Status"] +"] Request Nbr: "+RIDataObj["RequestNo"] +" V. "+RIDataObj["Version"] +" | Customer: "+OIDataObj["CustomerName"] +" | SFDC DealId: "+OIDataObj["SFDCDealID"] +" | Display SSN/Order Type : /"+RIDataObj["OrderType"] +" | Solution: "+RIDataObj["SolutionID"] +" | GroupId: "+RIDataObj["GroupID"];

            Assert.Contains(RIDataObj["ProductLine"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(OIDataObj["SFDCDealID"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["OrderType"].Trim(), Text_Subject().Text.Trim());
           // Assert.Contains(RIDataObj["GroupID"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), Text_Subject().Text.Trim());

            return new XPOD_EmailContentPage(driver);
        }
   
        public XPOD_EmailContentPage Method_ValidateEmailHeaderFields_ForEQLXPOD(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.NotNull(Text_From().Text.Trim());
            Assert.NotNull(Text_To().Text.Trim());
            
            //String Subjectline="["+RIDataObj["ProductLine"]+" Validation Request "+RIDataObj["Status"] +"] Request Nbr: "+RIDataObj["RequestNo"] +" V. "+RIDataObj["Version"] +" | Customer: "+OIDataObj["CustomerName"] +" | SFDC DealId: "+OIDataObj["SFDCDealID"] +" | Display SSN/Order Type : /"+RIDataObj["OrderType"] +" | Solution: "+RIDataObj["SolutionID"] +" | GroupId: "+RIDataObj["GroupID"];

            Assert.Contains(RIDataObj["ProductLine"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), Text_Subject().Text.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text.Trim());            
            Assert.Contains(RIDataObj["SolutionID"].Trim(), Text_Subject().Text.Trim());

            return new XPOD_EmailContentPage(driver);
        }


        public XPOD_EmailContentPage EmailBody_ViewValReqLink_Validation(Dictionary<String, String> RIDataObj)
        {
            Assert.True(ViewValidationLink().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            CommonMethods.WebdriverWait_TillElementReady(driver, ViewValidationLink());
            ViewValidationLink().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("requestNbr")));
            String ReqestNo = driver.FindElement(By.Id("requestNbr")).GetAttribute("value");
            Assert.Equal(ReqestNo, RIDataObj["RequestNo"]);
            driver.Close();
            driver.SwitchTo().Window(MainWindow);
            return new XPOD_EmailContentPage(driver);
        }
    public XPOD_EmailContentPage Method_ValidateEmailBody_AssignedCMLNewSys(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            //Vaidating the Para1 contains the requred information
            String ActEBodyP1 = driver.FindElement(By.XPath("//p[contains(text(),'Dell Storage Validation Request Assigned')]")).Text;
            Assert.Contains(RIDataObj["ProductLine"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["SFDCDealID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["OrderType"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["GroupID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), ActEBodyP1.Trim());

            //Vaidating the Para2 contains the requred information
            String ActBodyP2 = driver.FindElement(By.XPath("//p[contains(text(),'This Dell Storage Validation Request has been assi')]")).Text;
            String AssignedToval = RIDataObj["AssignedTo"].Substring(0, RIDataObj["AssignedTo"].IndexOf("@"));
            String AssignedTo = AssignedToval.Replace("_", " ");
            String res = UppercaseWords(AssignedTo);
            String ExpBodyP2 = "This Dell Storage Validation Request has been assigned to " + res.Trim() + " for review";
           
            Assert.Contains(ExpBodyP2.Trim(), ActBodyP2.Trim());

            //validating the OrderSystem Lable
            String ActOrderType = driver.FindElement(By.XPath("//table[@id='tblFirstTable']//div//p[contains(text(),'Order Type')]")).Text;
            String ExpOrderType = "Order Type:" + RIDataObj["OrderType"];
            Assert.Equal(ExpOrderType.Trim(), ActOrderType.Trim());

            //Validating table below view validation request link.Validating text and populated values 
            Assert.True(EBody_LblSolutionId().Displayed);
            Assert.True(EBody_LblVersion().Displayed);
            Assert.True(EBody_LblStatus().Displayed);
            Assert.True(EBody_LblLink().Displayed);
            Assert.True(EBody_LblCustomer().Displayed);
            String SolutionID = RIDataObj["SolutionID"].Trim().Substring(0, RIDataObj["SolutionID"].IndexOf("."));
            Assert.Equal(SolutionID, EBody_TextSolutionId().Text.Trim());
            Assert.Equal(RIDataObj["Version"].Trim(), EBody_TextVersion().Text.Trim());
            //Assert.Equal(RIDataObj["Status"].Trim(), EBody_TextStatus().Text.Trim());
            Assert.Equal(OIDataObj["CustomerName"].Trim(), EBody_TextCustomer().Text.Trim());
            Assert.True(EBody_TextLink().Enabled);
            Assert.True(Lbl_FORSECUSEONLY().Displayed);

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_ValidateEmailBody_SubmittedCMLXPOD(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            //Vaidating the Para1 contains the requred information
            String ActEBodyP1 = driver.FindElement(By.XPath("//p[contains(text(),'Dell Storage Validation Request Submitted')]")).Text;
            Assert.Contains(RIDataObj["ProductLine"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["SFDCDealID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["OrderType"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["GroupID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), ActEBodyP1.Trim());

            //Vaidating the Para2 contains the requred information
            String ActBodyP2 = driver.FindElement(By.XPath("//p[contains(text(),'This Validation Request has been submitted and nee')]")).Text;            
            String ExpBodyP2 = "This Validation Request has been submitted and needs to be reviewed by the validation consultant assigned to it.";
            Assert.Equal(ExpBodyP2.Trim(), ActBodyP2.Trim());

            //validating the OrderSystem Lable
            String ActOrderType = driver.FindElement(By.XPath("//table[@id='tblFirstTable']//div//p[contains(text(),'Order Type')]")).Text;
            String ExpOrderType = "Order Type:" + RIDataObj["OrderType"];
            Assert.Equal(ExpOrderType.Trim(), ActOrderType.Trim());

            Assert.True(Lbl_FORSECUSEONLY().Displayed);

            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailBody_SubmittedEQLXPOD(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            //Vaidating the Para1 contains the requred information
            String ActEBodyP1 = driver.FindElement(By.XPath("//p[contains(text(),'EqualLogic Validation Request Submitted')]")).Text;
            //Assert.Contains(RIDataObj["ProductLine"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["GroupID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), ActEBodyP1.Trim());

            //Vaidating the Para2 contains the requred information
            String ActBodyP2 = driver.FindElement(By.XPath("//p[contains(text(),'This Validation Request has been submitted and nee')]")).Text;
            String ExpBodyP2 = "This Validation Request has been submitted and needs to be reviewed by the validation consultant assigned to it.";
            Assert.Equal(ExpBodyP2.Trim(), ActBodyP2.Trim());

            //validating the OrderSystem Lable
            String ActOrderType = driver.FindElement(By.XPath("//table[@id='tblFirstTable']//div//p[contains(text(),'Order Type')]")).Text;
            String ExpOrderType = "Order Type:" + RIDataObj["OrderType"];
            Assert.Equal(ExpOrderType.Trim(), ActOrderType.Trim());

            Assert.True(Lbl_FORSECUSEONLY().Displayed);

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_ValidateEmailBody_AssignedEQLXPOD(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            //Vaidating the Para1 contains the requred information
            String ActEBodyP1 = driver.FindElement(By.XPath("//p[contains(text(),'EqualLogic Validation Request Assigned')]")).Text;
            Assert.Contains(RIDataObj["ProductLine"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Status"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["RequestNo"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["Version"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(OIDataObj["CustomerName"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["GroupID"].Trim(), ActEBodyP1.Trim());
            Assert.Contains(RIDataObj["SolutionID"].Trim(), ActEBodyP1.Trim());

            //Vaidating the Para2 contains the requred information
            String ActBodyP2 = driver.FindElement(By.XPath("//p[contains(text(),'This EqualLogic Validation Request has been assi')]")).Text;
            String AssignedToval = RIDataObj["AssignedTo"].Substring(0, RIDataObj["AssignedTo"].IndexOf("@"));
            String AssignedTo = AssignedToval.Replace("_", " ");
            String res = UppercaseWords(AssignedTo);
            String ExpBodyP2 = "This EqualLogic Validation Request has been assigned to " + res.Trim() + " for review";
            Assert.Contains(ExpBodyP2.Trim(), ActBodyP2.Trim());

            //validating the OrderSystem Label
            String ActOrderType = driver.FindElement(By.XPath("//table[@id='tblFirstTable']//div//p[contains(text(),'Order Type')]")).Text;
            String ExpOrderType = "Order Type:" + RIDataObj["OrderType"];
            Assert.Equal(ExpOrderType.Trim(), ActOrderType.Trim());

            //Validating table below view validation request link.Validating text and populated values 
            Assert.True(EBody_LblSolutionId().Displayed);
            Assert.True(EBody_LblVersion().Displayed);
            Assert.True(EBody_LblStatus().Displayed);
            Assert.True(EBody_LblLink().Displayed);
            Assert.True(EBody_LblCustomer().Displayed);
            String SolutionID = RIDataObj["SolutionID"].Trim().Substring(0, RIDataObj["SolutionID"].IndexOf("."));
            Assert.Equal(SolutionID, EBody_TextSolutionId().Text.Trim());
            Assert.Equal(RIDataObj["Version"].Trim(), EBody_TextVersion().Text.Trim());
            //Assert.Equal(RIDataObj["Status"].Trim(), EBody_TextStatus().Text.Trim());
            Assert.Equal(OIDataObj["CustomerName"].Trim(), EBody_TextCustomer().Text.Trim());
            Assert.True(EBody_TextLink().Enabled);

            Assert.True(Lbl_FORSECUSEONLY().Displayed);

            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_EmailValidateBtn_Validation()
        {
            Assert.True(Btn_Validate().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            Btn_Validate().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("txtDelSecStatus")));
            CommonMethods.Page_Scrolldown(driver);
            Assert.True(driver.FindElement(By.Id("btnApprove1")).Displayed);
            driver.Close();
            driver.SwitchTo().Window(MainWindow);

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_EmailAssignBtn_Validation()
        {
            Assert.True(Btn_Assign().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            Btn_Assign().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("btnAssign")));
            Assert.True(driver.FindElement(By.Id("btnAssign")).Displayed);            
            driver.Close();
            driver.SwitchTo().Window(MainWindow);

            return new XPOD_EmailContentPage(driver);
        }
        public string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public XPOD_EmailContentPage Method_ViewSystSummaryRep_Validation()
        {
            CommonMethods.ScrollTillElementViible(driver, Link_ViewSysSummaryRep());
            Assert.True(Link_ViewSysSummaryRep().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewSysSummaryRep());
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewSysSummaryRep());
            Link_ViewSysSummaryRep().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewSysSummaryRep());
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewSysSummaryRep());
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            String URL = driver.Url;
            String Exp = "http://reports.compellent.com";
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("ReportViewerControl_ctl04_ctl03_txtValue")));
            Assert.Contains(Exp, URL);
            driver.Close();
            driver.SwitchTo().Window(MainWindow);

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_ViewWebCST_Validation()
        {
            CommonMethods.ScrollTillElementViible(driver, Link_ViewWebCST());
            Assert.True(Link_ViewWebCST().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            Link_ViewWebCST().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewWebCST());
            CommonMethods.WebdriverWait_TillElementReady(driver, Link_ViewWebCST());
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            var a = driver.Url;
            
            String URL = driver.Url;
            String Exp = "http://tools.ph.dell.com";
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("productName")));
            Assert.Contains(Exp, URL);
            driver.Close();
            driver.SwitchTo().Window(MainWindow);

            return new XPOD_EmailContentPage(driver);
        }
        public XPOD_EmailContentPage Method_DellSupportLink_Validation()
        {
            Assert.True(Link_DellSupportLink().Enabled);
            String MainWindow = driver.CurrentWindowHandle;
            Link_DellSupportLink().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            String URL = driver.Url;
            String Exp = "https://www.dell.com";
            CommonMethods.WebdriverWait_TillElementReady(driver, driver.FindElement(By.Id("search-input")));
            Assert.Contains(Exp, URL);
            driver.Close();
            driver.SwitchTo().Window(MainWindow);

            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailHeaderFieldsApprovedCML(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            Assert.True(Text_To().Text.Trim() != "");
            Assert.Contains("SEC Dell Storage Validation", Text_Subject().Text);
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text);
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text);



            string BodyHeader = "has set this Validation Request";
            string BodyHeaderReqNo = RIDataObj["RequestNo"];
            string BodyHeadertoStatus = "to a status of ";
            string BodyHeaderStatus = RIDataObj["Status"];
            PendingStatus().Text.Contains(BodyHeader);
            PendingStatus().Text.Contains(BodyHeaderReqNo);
            PendingStatus().Text.Contains(BodyHeadertoStatus);
            PendingStatus().Text.Contains(BodyHeaderStatus);

            Assert.True(PendingBodyDellStarQN().Displayed);
            Assert.True(PendingBodyCustomerName().Displayed);
            Assert.True(PendingBodyInstallationAddress().Displayed);
            Assert.True(NoteHistory().Displayed);
            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage EmailBody_ViewReqLink_ValidationPending(Dictionary<String, String> RIDataObj)
        {
            try
            {
                CommonMethods.ScrollTillElementViible(driver, ViewLink());

                Assert.True(ViewLink().Enabled);
                Assert.True(ValidateLink().Enabled);
                CommonMethods.Page_Scrolldown(driver);
                ViewLink().Click();
                driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
                var viewSub = driver.FindElement(By.Id("btnViewSubmission"));
                Assert.True(viewSub.Enabled);
                //driver.Close();

                driver.SwitchTo().Window(driver.WindowHandles.First());
                return new XPOD_EmailContentPage(driver);
            }
            catch
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("Testscreenshot", ScreenshotImageFormat.Png);
                Assert.True(false);
                return new XPOD_EmailContentPage(driver);
            }
          

        }
        public XPOD_EmailContentPage EmailBody_ValReqLink_ValidationPending(Dictionary<String, String> RIDataObj)
        {
            CommonMethods.Page_Scrolldown(driver);
            CommonMethods.Page_Scrolldown(driver);
            ValidateLink().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.Page_Scrolldown(driver);
            var approveBtn = driver.FindElement(By.Id("btnApprove1"));
            Assert.True(approveBtn.Enabled);
            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailHeaderFieldsPendingNewSystem(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            Assert.True(Text_To().Text.Trim() != "");
            //Assert.Contains("SEC CML Validation", Text_Subject().Text);
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text);
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text);



            string BodyHeader = "has set this Validation Request";
            string BodyHeaderReqNo = RIDataObj["RequestNo"];
            string BodyHeadertoStatus = "to a status of ";
            string BodyHeaderStatus = RIDataObj["Status"];
            PendingStatus().Text.Contains(BodyHeader);
            PendingStatus().Text.Contains(BodyHeaderReqNo);
            PendingStatus().Text.Contains(BodyHeadertoStatus);
            PendingStatus().Text.Contains(BodyHeaderStatus);

            Assert.True(PendingBodyDellStarQN().Displayed);
            Assert.True(PendingBodyCustomerName().Displayed);
            Assert.True(PendingBodyInstallationAddress().Displayed);
            Assert.True(NoteHistory().Displayed);
            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            Assert.True(Text_To().Text.Trim() != "");
            Assert.Contains("SEC Dell Storage", Text_Subject().Text);
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text);
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["OrderType"].Trim(), Text_Subject().Text);




            string BodyHeader = "has set this Validation Request";
            string BodyHeaderReqNo = RIDataObj["RequestNo"];
            string BodyHeadertoStatus = "to a status of ";
            string BodyHeaderStatus = RIDataObj["Status"];
            PendingStatus().Text.Contains(BodyHeader);
            PendingStatus().Text.Contains(BodyHeaderReqNo);
            PendingStatus().Text.Contains(BodyHeadertoStatus);
            PendingStatus().Text.Contains(BodyHeaderStatus);

            Assert.True(PendingBodyDellStarQN().Displayed);
            Assert.True(PendingBodyCustomerName().Displayed);
            Assert.True(PendingBodyInstallationAddress().Displayed);
            Assert.True(NoteHistory().Displayed);
            return new XPOD_EmailContentPage(driver);
        }


        public XPOD_EmailContentPage Method_ValidateEmailHeaderFieldsPendingEQL(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            Assert.True(Text_To().Text.Trim() != "");
            Assert.Contains("SEC EqualLogic", Text_Subject().Text);
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text);
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["OrderType"].Trim(), Text_Subject().Text);




            string BodyHeader = "has set this Validation Request";
            string BodyHeaderReqNo = RIDataObj["RequestNo"];
            string BodyHeadertoStatus = "to a status of ";
            string BodyHeaderStatus = RIDataObj["Status"];
            PendingStatus().Text.Contains(BodyHeader);
            PendingStatus().Text.Contains(BodyHeaderReqNo);
            PendingStatus().Text.Contains(BodyHeadertoStatus);
            PendingStatus().Text.Contains(BodyHeaderStatus);

            Assert.True(PendingBodyDellStarQN().Displayed);
            Assert.True(PendingBodyCustomerName().Displayed);
            Assert.True(PendingBodyInstallationAddress().Displayed);
            Assert.True(NoteHistory().Displayed);
            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage Method_ValidateEmailHeaderFieldsDenied(Dictionary<String, String> RIDataObj, Dictionary<String, String> OIDataObj)
        {
            Assert.True(Lbl_From().Displayed);
            Assert.True(Lbl_To().Displayed);
            Assert.True(Lbl_CC().Displayed);
            Assert.True(Lbl_Subject().Displayed);
            Assert.True(Lbl_Body().Displayed);

            Assert.True(Text_To().Text.Trim() != "");
            Assert.Contains("SEC EqualLogic", Text_Subject().Text);
            Assert.Contains(RIDataObj["Status"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["RequestNo"].Trim(), Text_Subject().Text);
            Assert.Contains(OIDataObj["CustomerName"].Trim(), Text_Subject().Text);
            Assert.Contains(RIDataObj["OrderType"].Trim(), Text_Subject().Text);




            string BodyHeader = "has set this Validation Request";
            string BodyHeaderReqNo = RIDataObj["RequestNo"];
            string BodyHeadertoStatus = "to a status of ";
            string BodyHeaderStatus = RIDataObj["Status"];
            PendingStatus().Text.Contains(BodyHeader);
            PendingStatus().Text.Contains(BodyHeaderReqNo);
            PendingStatus().Text.Contains(BodyHeadertoStatus);
            PendingStatus().Text.Contains(BodyHeaderStatus);

            Assert.True(PendingBodyDellStarQN().Displayed);
            Assert.True(PendingBodyCustomerName().Displayed);
            Assert.True(PendingBodyInstallationAddress().Displayed);
            Assert.True(NoteHistory().Displayed);
            return new XPOD_EmailContentPage(driver);
        }

        public XPOD_EmailContentPage EmailBody_ValReqLink_ValidationDenied(Dictionary<String, String> RIDataObj)
        {


            CommonMethods.Page_Scrolldown(driver);
            CommonMethods.Page_Scrolldown(driver);
            ValidateLink().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.Page_Scrolldown(driver);
            var deniedTxt = driver.FindElement(By.XPath("//p[contains(text(),'This Technical Validation Submission has already been denied')]"));
            Assert.True(deniedTxt.Displayed);
            return new XPOD_EmailContentPage(driver);
        }


    }
}
