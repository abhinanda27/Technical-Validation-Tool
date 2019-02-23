using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using TechnicalValidationTool.TestAutomation.Helper;
using System.Threading;

namespace TechnicalValidationTool.TestAutomation.Page
{
    public class AdvancedFind_Page:PageBase
    {
        public IWebDriver driver;
        CommonMethods CommonMethods;

        String strDefaultViewname;
        public AdvancedFind_Page(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
        }

        public IWebElement Btn_CreateView()
        {
            return (ReturnMeWebElement(By.XPath("//button[@id='btnCreate']")));
        }
        public IWebElement Lbl_AdvancedViewSelect()
        {
            return driver.FindElement(By.XPath("//b[contains(text(),'Select View:')]"));
        }
        public IWebElement dd_AdvancedViewSelect()
        {
            return driver.FindElement(By.Id("viewData"));
        }
        public IWebElement Lbl_ViewName()
        {
            return driver.FindElement(By.XPath("//b[contains(text(),'View Name')]"));
        }
        public IWebElement Txtbox_ViewName()
        {
            return ReturnMeWebElement(By.XPath("//input[@id='viewName']"));
        }
        public IWebElement Lbl_ViewDescription()
        {
            return driver.FindElement(By.XPath("//b[contains(text(),'View Description')]"));
        }
        public IWebElement Txtbox_ViewDescription()
        {
            return ReturnMeWebElement(By.XPath("//textarea[@id='viewDescription']"));
        }
        public IWebElement Btn_AddFilter()
        {
            return driver.FindElement(By.XPath("//button[@id='btnCreate']"));
        }
        public IWebElement Btn_Find()
        {
            return ReturnMeWebElement(By.XPath("//button[@id='btnFind']"));
        }
        public IWebElement Btn_SetDefaultView()
        {
            return ReturnMeWebElement(By.Id("btnSet"));
        }
        public IWebElement Btn_SaveView()
        {
            return ReturnMeWebElement(By.XPath("//button[@id='btnSave']"));
        }

        public IWebElement Col_SolutionSource()
        {
        return driver.FindElement(By.XPath("//div[contains(text(),'SolutionSource')]"));
        }
        public IWebElement Col_CreatedBy()
        { return driver.FindElement(By.XPath("//div[contains(text(),'CreatedBy')]")); }
        public IWebElement Col_ModifiedBy()
        { return driver.FindElement(By.XPath("//div[contains(text(),'ModifiedBy')]")); }
        public IWebElement Col_ChannelPartnerAffinityId()
        { return driver.FindElement(By.XPath("//div[contains(text(),'ChannelPartnerAffinityId')]")); }
        public IWebElement Col_ChannelPartnerName()
        { return driver.FindElement(By.XPath("//div[contains(text(),'ChannelPartnerName')]")); }
        public IWebElement Col_AffinityId()
        { return driver.FindElement(By.XPath("//div[contains(text(),'AffinityId')]")); }
        public IWebElement Col_CustomerName()
        { return driver.FindElement(By.XPath("//div[contains(text(),'CustomerName')]")); }
        public IWebElement Col_VCAssigned()
        { return driver.FindElement(By.XPath("//div[contains(text(),'VcAssigned')]")); }
        public IWebElement Col_RegionCode()
        { return driver.FindElement(By.XPath("//div[contains(text(),'RegionCode')]")); }
        public IWebElement Col_ProductLine()
        { return driver.FindElement(By.XPath("//div[contains(text(),'ProductLine')]")); }
        public IWebElement Col_Status()
        { return driver.FindElement(By.XPath("//div[contains(text(),'Status')]")); }
        public IWebElement Col_SfdcId()
        { return driver.FindElement(By.XPath("//div[contains(text(),'SfdcId')]")); }
        public IWebElement Col_OrderType()
        { return driver.FindElement(By.XPath("//div[contains(text(),'OrderType')]")); }
        //public IWebElement Col_SolutionRegion()
        //{ return driver.FindElement(By.XPath("//div[contains(text(),'SolutionRegion')]")); }

        public IList<IWebElement> btn_FilterRemovel()
        {
            IList<IWebElement> FilterRemover = driver.FindElements(By.XPath("//i[@title='Remove']"));
            return FilterRemover;
        }
        public IWebElement ErrorMsg_SameViewNameExist()
        {
            return driver.FindElement(By.Id("toast-container"));
        }
        public IWebElement TextBox_SeachEle()
        {
            return driver.FindElement(By.Id("filterText"));
        }


        //Methods

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
        /// This method is to click on the Create New View Button
        /// </summary>
        /// <returns></returns>
        public AdvancedFind_Page click_CreateNewViewButton()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_AdvancedViewSelect());
            Btn_CreateView().Click();
            return new AdvancedFind_Page(driver);
        }

        /// <summary>
        /// This method is the field validations on the advanced find page.
        /// </summary>
        /// <returns></returns>
        public AdvancedFind_Page CreateNewView_FieldValidations()
        {
            Assert.True(Lbl_ViewName().Displayed);
            Assert.True(Txtbox_ViewName().Enabled);
            Assert.True(Lbl_ViewDescription().Displayed);
            Assert.True(Txtbox_ViewDescription().Enabled);
                                   
            Assert.True(Btn_AddFilter().Displayed);

            CommonMethods.WebdriverWait_TillElementReady(driver, Col_SolutionSource());
            Assert.True(Col_SolutionSource().Displayed);
            Assert.True(Col_CreatedBy().Displayed);
            Assert.True(Col_ModifiedBy().Displayed);
            Assert.True(Col_ChannelPartnerAffinityId().Displayed);
            Assert.True(Col_ChannelPartnerName().Displayed);
            Assert.True(Col_AffinityId().Displayed);
            Assert.True(Col_CustomerName().Displayed);
            Assert.True(Col_VCAssigned().Displayed);
            Assert.True(Col_RegionCode().Displayed);
            Assert.True(Col_ProductLine().Displayed);
            Assert.True(Col_Status().Displayed);
            Assert.True(Col_SfdcId().Displayed);
            Assert.True(Col_OrderType().Displayed);
            //Assert.True(Col_SolutionRegion().Displayed);
            
            return new AdvancedFind_Page(driver);
        }

        /// <summary>
        /// This method is to Enter the New view details on the corresponding fields
        /// The data is passed through JSON file
        /// </summary>
        /// <param name="DataObj"></param>
        /// <returns></returns>
        public AdvancedFind_Page Entering_NewView_Details(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");
            String Viewname = data["View"].ToString();
            String ViewDesc = data["ViewDesc"].ToString();
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewName());
            Txtbox_ViewName().SendKeys(Viewname);
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewDescription());
            Txtbox_ViewDescription().SendKeys(ViewDesc);
            AddingStatus_Denitedfilter();
                        
            return new AdvancedFind_Page(driver);
        }

        /// <summary>
        /// this method is to click on the "create view" button on the advanced find page
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist Click_CreateView()
        {
            //CommonMethods.WebdriverWait_ElementClickable(driver, Btn_CreateView());
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_CreateView());
            Btn_CreateView().Click();

            try
            { 
                if(ErrorMsg_SameViewNameExist().Displayed)
                {
                    Btn_CreateView().SendKeys(Keys.Escape);
                }
            }
            catch
            {
                return new XPOD_HomePage_Xpodlist(driver);
            }

            return new XPOD_HomePage_Xpodlist(driver);
        }

        /// <summary>
        /// This method is to click "Find" Button
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist Click_Find()
        {
           CommonMethods.WebdriverWait_ElementClickable(driver, Btn_Find());           
            Btn_Find().Click();           
            return new XPOD_HomePage_Xpodlist(driver);
        }

        /// <summary>
        /// This method is to add some default filter with status as denited in the 
        /// filter conditions
        /// </summary>
        public void AddingStatus_Denitedfilter()
        {
            SelectElement dd_column = new SelectElement(driver.FindElement(By.Id("Column0")));
            dd_column.SelectByText("Status");
            CommonMethods.WebdriverWait_ElementClickable(driver, driver.FindElement(By.Id("Operator0")));
            IWebElement Ele = driver.FindElement(By.Id("Operator0"));
            SelectElement dd_operator = new SelectElement(Ele);
            CommonMethods.WebdriverWait_TillElementReady(driver, Ele);
            dd_operator.SelectByText("NotIn");
            dd_operator.SelectByText("In");
            driver.FindElement(By.XPath("//i[@title='openDialog']")).Click();
            IWebElement Btn_Denied = driver.FindElement(By.XPath("//input[@value='Denied']"));
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_Denied);
            driver.FindElement(By.XPath("//input[@value='Denied']")).Click();
            driver.FindElement(By.XPath("//button[text()='Add']")).Click();
        }

        /// <summary>
        /// this method is to select dropdown view in the advanced find page
        /// </summary>
        /// <param name="DataObj"></param>
        /// <param name="TestName"></param>
        /// <param name="TestValue"></param>
        /// <returns></returns>
        public AdvancedFind_Page AdvancedFind_SelectView(Object DataObj,String TestName,String TestValue)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            var viewname = data[TestValue];
            SelectElement View = new SelectElement(dd_AdvancedViewSelect());
            View.SelectByText(viewname.ToString());
            return new AdvancedFind_Page(driver);
        }

        /// <summary>
        /// This method is to close the advanced find window by clicking escape button
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist AdvanceFind_CloseFun()
        {
            
            Btn_AddFilter().SendKeys(Keys.Escape);
            return new XPOD_HomePage_Xpodlist(driver);
        }

        public AdvancedFind_Page Method_EditAdvanvedFind_Views(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "TestData");
            String strEditedViewName = data["EditViewname"].ToString();
            String strEditViewDesc = data["EditViewdesc"].ToString();

            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewName());
            Txtbox_ViewName().Clear();
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewName());
            Txtbox_ViewName().SendKeys(strEditedViewName);
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewDescription());
            Txtbox_ViewDescription().Clear();
            CommonMethods.WebdriverWait_TillElementReady(driver, Txtbox_ViewDescription());
            Txtbox_ViewDescription().SendKeys(strEditViewDesc);
            //Method_Remove_AllFilter();
            //Thread.Sleep(2000);
            //Btn_AddFilter().Click();
            Method_AddSourceOSC_Filter();
            Assert.True(Btn_SaveView().Enabled);            
            return new AdvancedFind_Page(driver);
        }

        /// <summary>
        /// This method is to remove all the added filter from the selected view
        /// </summary>
        public void Method_Remove_AllFilter()
        {
            IList<IWebElement> Filters = btn_FilterRemovel();
            foreach(var btn_rmv in Filters)
            {
                btn_rmv.Click();
            }
        }
        
        /// <summary>
        /// This method is to add filter as Source as OSC
        /// </summary>
        public void Method_AddSourceOSC_Filter()
        {
            IWebElement Col0 = driver.FindElement(By.Id("Column0"));
            CommonMethods.WebdriverWait_TillElementReady(driver, Col0);
            SelectElement dd_column = new SelectElement(Col0);
            dd_column.SelectByText("SolutionSource");
            IWebElement Oper0 = driver.FindElement(By.Id("Operator0"));
            CommonMethods.WebdriverWait_TillElementReady(driver,Oper0);
            SelectElement dd_operator = new SelectElement(Oper0);
            dd_operator.SelectByText("Contains");
            dd_operator.SelectByText("Equals");
            driver.FindElement(By.XPath("//input[@id='value0']")).Clear();
            driver.FindElement(By.XPath("//input[@id='value0']")).SendKeys("OSC");
        }
        public XPOD_HomePage_Xpodlist Method_ClickSaveView_Button()
        {
            CommonMethods.WebdriverWait_TillElementReady(driver, Btn_SaveView());
            Btn_SaveView().Click();
            return new XPOD_HomePage_Xpodlist(driver);
        }



        //Below methods are in progress
        public XPOD_HomePage_Xpodlist Clicking_SetDefaultView()
        {
            
            CommonMethods.WebdriverWait_ElementClickable(driver, Btn_SetDefaultView());
            Btn_SetDefaultView().Click();
            return new XPOD_HomePage_Xpodlist(driver);
            
        }
        public void Method_ComparingDefaultView_UsergivenValue(Object DataObj,String TestName,String TestVal)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            var view = data[TestVal];
            SelectElement sel = new SelectElement(dd_AdvancedViewSelect());
            String defaultvalue = sel.SelectedOption.Text;
            String uservalue = view.ToString().Trim();
            if(defaultvalue.Equals(uservalue))
            {
                Console.Write("The mentioned View is already the Default View for the user");
                AdvanceFind_CloseFun();                
            }
            else
            {
            AdvancedFind_SelectView(DataObj, "Test5867945", "View1").Clicking_SetDefaultView();
            
            }
            
        }
        public String Method_GetSelected_ViewName()
        {
            SelectElement dd_viewname = new SelectElement(dd_AdvancedViewSelect());
            strDefaultViewname = dd_viewname.SelectedOption.Text;
            return strDefaultViewname;
        }

    }
}
