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
namespace TechnicalValidationTool.TestAutomation.Page
{
    public class XPOD_NotesTab_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;
        
        public XPOD_NotesTab_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement TxtArea_AddNote()
        {
            return driver.FindElement(By.XPath("//label[@class='col-form-label-sm']//following::textarea"));
        }
        public IWebElement Btn_CreateNote()
        {
            return ReturnMeWebElement(By.Id("btnCreateNote"));
            //return driver.FindElement(By.Id("btnCreateNote"));          
        }
        public IWebElement Notes_table()
        {
            return driver.FindElement(By.XPath("//mat-table[@class='mat-elevation-z1 mat-table']"));
        }
        public IWebElement FirstCell_NotesTable()
        {
            return driver.FindElement(By.XPath("//mat-table//mat-row[1]//mat-cell[1]"));
        }
      

        //Actons

        /// <summary>
        /// This method is to return the element once its loaded. Here chekcing whether the given 
        /// element is displayed or enabled.
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
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
        public XPOD_NotesTab_Page Creating_Notes(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "BVT_TestData");
            var Notes = data["Notes"];
            TxtArea_AddNote().SendKeys(Notes.ToString());
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_CreateNote());
            Btn_CreateNote().Click();
            CommonMethods.WebdriverWait_TillElementReady(driver, Notes_table());
            return new XPOD_NotesTab_Page(driver);
        }
        public XPOD_NotesTab_Page CreatedNote_Validation(Object DataObj,int OldNoteCount)
        {
            int NotesCountLatest= Getting_NotesTableCount();
            Assert.True(NotesCountLatest > OldNoteCount);
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "BVT_TestData");
            var Notes = data["Notes"];
            CommonMethods.WebdriverWait_TillElementReady(driver, Notes_table());            
            Assert.True(Notes_table().Displayed);            
            Assert.Equal(Notes.ToString(), FirstCell_NotesTable().Text);
            return new XPOD_NotesTab_Page(driver);
        }
        public XPOD_General_StaticEle_Page SwitchingTo_GenBasePage()
        {
            
            return new XPOD_General_StaticEle_Page(driver);
        }
        public void Method_Validate_ResponseComments(Object DataObj,String TestName,String RespName,int OldNotesCount)
        {
            int NotesLatestCount = Getting_NotesTableCount();
            Assert.True(NotesLatestCount > OldNotesCount);
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            String Notes = data[RespName].ToString();
            CommonMethods.WebdriverWait_TillElementReady(driver, Notes_table());
            Assert.True(Notes_table().Displayed);
            Assert.Contains(Notes,FirstCell_NotesTable().Text);
        }

        public int Getting_NotesTableCount()
        {
            int tableRowCount;
            try
            {
                 tableRowCount = driver.FindElements(By.XPath("//mat-table//mat-row")).Count;
            }
            catch
            {
                tableRowCount = 0;
            }
            return tableRowCount;
        }
    }
}
