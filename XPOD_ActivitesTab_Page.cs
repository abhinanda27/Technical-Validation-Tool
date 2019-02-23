using System;
using System.Collections.Generic;
using System.Linq;
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
    public class XPOD_ActivitesTab_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        public XPOD_ActivitesTab_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Table_Activites()
        {
            return driver.FindElement(By.XPath("//mat-table[@class='mat-elevation-z1 mat-table']"));
        }
        public int Rowcount_ActivityTable()
        {
            return driver.FindElements(By.XPath("//mat-table[@class='mat-elevation-z1 mat-table']//mat-row")).Count;
        }
        public IWebElement dd_Ordertype()
        {
            return driver.FindElement(By.XPath("//label[contains(text(),'Order Type')]//following::select[1]"));
        }
        public By PageLoader()
        {
            return By.XPath("//div[@class='icon-ui-loading']");
        }
        public IWebElement xPODForm()
        {
            return driver.FindElement(By.Id("div_txtSubmitterName"));
        }
        public IList<IWebElement> ActivityTabHeaderRows()
        {
            IList<IWebElement> HeaderRows = driver.FindElements(By.XPath("//mat-header-row//mat-header-cell"));
            return HeaderRows;
        }


        public XPOD_ActivitesTab_Page Activity_Table_Generation_Validation()
        {            
            CommonMethods.WebdriverWait_TillElementReady(driver, Table_Activites());
            Assert.True(Table_Activites().Displayed);
            Assert.NotEqual(0, Rowcount_ActivityTable());

            return new XPOD_ActivitesTab_Page(driver);
        }
        public XPOD_ActivitesTab_Page validateList()
        {

            new XPOD_Genral_OI_Page(driver).btnValidationList().Click();
            //Thread.Sleep(10000);
           // Assert.True(new XPOD_HomePage_Xpodlist(driver).btn_AdvancedFind().Enabled);
            Assert.True(new XPOD_HomePage_Header(driver).TextBox_Fulldb_Search().Enabled);
            return new XPOD_ActivitesTab_Page(driver);
        }
        public XPOD_ActivitesTab_Page saveNotify()
        {
            CommonMethods.Page_Scrolldown(driver);
            new XPOD_Genral_OI_Page(driver).Btn_SaveAndNotify().Click();
            CommonMethods.Page_ScrollUp(driver);
            new XPOD_General_StaticEle_Page(driver).Clicking_ActivitesTab();
            CommonMethods.WebdriverWait_TillElementReady(driver, Table_Activites());
            Assert.True(Table_Activites().Displayed);
            Assert.NotEqual(0, Rowcount_ActivityTable());
            Assert.NotEqual(Rowcount_ActivityTable(), Rowcount_ActivityTable() + 1);
            return new XPOD_ActivitesTab_Page(driver);
        }
        public XPOD_ActivitesTab_Page viewSub()
        {

            CommonMethods.Page_Scrolldown(driver);
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_Ordertype());
            new XPOD_Genral_OI_Page(driver).Btn_ViewSubmission().Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Manage().Window.Maximize();
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_TillElementReady(driver, xPODForm());
            Assert.True(xPODForm().Displayed);
            return new XPOD_ActivitesTab_Page(driver);
        }

        public XPOD_EmailContentPage Method_ClickEmail(String ColumnName, String value)
        {
            IList<IWebElement> HeaderElements = ActivityTabHeaderRows();
            foreach (var colvalue in HeaderElements)
            {
                if (colvalue.Text == ColumnName)
                {                    
                    String str = colvalue.GetAttribute("class");
                    String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                    IList<IWebElement> ColumnValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute + " mat-column-" + strHeaderAttribute + " ng-star-inserted']"));
                    for (int i = 0; i < ColumnValues.Count; i++)
                    {
                        if (ColumnValues[i].Text.Equals(value))
                        {
                            ColumnValues[i].Click();
                            return new XPOD_EmailContentPage(driver);
                        }
                    }
                }

            }
            Assert.True(false);
            return new XPOD_EmailContentPage(driver);

        }
        public XPOD_EmailContentPage Method_ClickEmailExclude(String ColumnName, String value)
        {
            IList<IWebElement> HeaderElements = ActivityTabHeaderRows();
            foreach (var colvalue in HeaderElements)
            {
                if (colvalue.Text == ColumnName)
                {
                    String str = colvalue.GetAttribute("class");
                    String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                    IList<IWebElement> ColumnValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute + " mat-column-" + strHeaderAttribute + " ng-star-inserted']"));
                    for (int i = 0; i < ColumnValues.Count; i++)
                    {
                        if (ColumnValues[i].Text.Equals(value))
                        {
                            IList<IWebElement> HeaderElements2 = ActivityTabHeaderRows();
                            foreach (var ExCol in HeaderElements2)
                            {
                                if (ExCol.Text == "Subject")
                                {
                                    String strEx = ExCol.GetAttribute("class");
                                    String strHeaderAttributeEx = strEx.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();
                                    IList<IWebElement> ExcludeColValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttributeEx + " mat-column-" + strHeaderAttributeEx + " ng-star-inserted']"));
                                    if (!ExcludeColValues[i].Text.StartsWith("[SEC"))
                                    {
                                        ColumnValues[i].Click();
                                        return new XPOD_EmailContentPage(driver);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            Assert.True(false);
            return new XPOD_EmailContentPage(driver);

        }
        
    }
}
