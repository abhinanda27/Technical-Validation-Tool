using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class XPOD_HomePage_Xpodlist : PageBase
    {
        public IWebDriver driver;
        String DefaultViewName;
        CommonMethods CommonMethods;


        public XPOD_HomePage_Xpodlist(IWebDriver driverinstance)
        {
            driver = driverinstance;
            CommonMethods = new CommonMethods();
            //if (!Validator())
            //{
            //    throw new Exception("Page is not loaded correct");
            //}

        }
        /// <summary>
        /// Method checks the first element in the XPOD list is displayed or not. This is for making 
        /// sure that the page is loaded fully when its called.
        /// </summary>
        /// <returns></returns>
        public Boolean Validator()
        {
            while (Table_FirstEle().Displayed == false)
            {
                Thread.Sleep(1000);
            }

            return true;
        }

        public int NoOfRows()
        {
            return driver.FindElements(By.XPath("//mat-table[@id='validationList']//mat-row")).Count;
        }
        public IWebElement Table_FirstEle()
        {
            return ReturnMeWebElement(By.XPath("//mat-table[@id='validationList']//mat-row[1]//mat-cell[1]"));
        }

        public IWebElement dd_Pagecount10()
        {
            return driver.FindElement(By.XPath("//div[@class='mat-form-field-infix']"));
        }
        public IWebElement dd_Pagecount5()
        {
            return driver.FindElement(By.XPath("//mat-option[@id='mat-option-0']//span[@class='mat-option-text'][contains(text(),'5')]"));
        }
        public IWebElement dd_PageCount15()
        {
            return driver.FindElement(By.XPath("//span[@class='mat-option-text'][contains(text(),'15')]"));
        }
        public IWebElement dd_PagecountArrow()
        {
            return driver.FindElement(By.XPath("//div[@class='mat-select-arrow']"));
        }
        public IWebElement dd_views()
        {
            return ReturnMeWebElement(By.XPath("//select[@id='viewSelect']"));
        }
        public IWebElement btn_AdvancedFind()
        {
            return ReturnMeWebElement(By.Id("advanceFindIcon"));
        }
        public IWebElement TextBox_SeachEle()
        {
            return driver.FindElement(By.Id("filterText"));
        }
        public IList<IWebElement> TableHeaderRows()
        {
            IList<IWebElement> HeaderRows = driver.FindElements(By.XPath("//mat-header-row//mat-header-cell"));
            return HeaderRows;
        }
        public IWebElement Status_Column()
        {
            return driver.FindElement(By.XPath("//mat-header-cell//strong[contains(text(),' Status ')]"));
        }
        public IList<IWebElement> Columns(String ColName)
        {
            return driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + ColName + " mat-column-" + ColName + " ng-star-inserted']"));

        }

        public By selectingsomething()
        {
            return By.XPath("//div[@class='mat-select-arrow']");
        }
        public By XpodTable()
        {
            return By.Id("validationList");
        }
        public By PageLoader()
        {
            return By.XPath("//div[@class='icon-ui-loading']");
        }
        public IWebElement Btn_Nextpage()
        {
            return driver.FindElement(By.XPath("//div[@class='mat-paginator-range-actions']//button[3]"));
        }

        //Actions

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

        /// <summary>
        /// Method is to check search an element in the XPOD list and return whether its present or not
        /// 
        /// </summary>
        /// <param name="DataObj"></param>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist searchfunction(Object DataObj)
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "BVT_TestData");
            var SearchVal = data["Searchvalue"];
            CommonMethods.WebdriverWait_ElementClickable(driver, Table_FirstEle());
            if (NoOfRows() == 0)
            {
                Console.WriteLine("Search element is not present");
            }
            else
            {
                for (int i = 1; i <= NoOfRows(); i++)
                {
                    int counter = 0;

                    IList<IWebElement> rowele = driver.FindElements(By.XPath("//mat-table[@id='validationList']//mat-row[" + i + "]/mat-cell"));

                    foreach (var Ele in rowele)
                    {

                        if (Ele.Text.Equals(SearchVal.ToString()) || Ele.Text.Contains(SearchVal.ToString()))
                        {

                            counter = counter + 1;

                        }
                    }
                    Assert.NotEqual(0, counter);


                }
            }

            return new XPOD_HomePage_Xpodlist(driver);
        }
        /// <summary>
        /// Click on the first element request number(first row) from the XPOD list table visible
        /// </summary>
        /// <returns>This will navigate to General Page, hence returning General RI Page</returns>
        public XPOD_General_RI_Page First_tableEle_Click()
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_ElementClickable(driver, Table_FirstEle());
            Table_FirstEle().Click();
            return new XPOD_General_RI_Page(driver);
        }

        /// <summary>
        /// Validating the pagingation default value and the values 5,10 and 15.
        /// </summary>
        /// <returns>returning the same page</returns>
        public XPOD_HomePage_Xpodlist Pagination_validation()
        {
            Assert.Equal("10", dd_Pagecount10().Text);//default value check

            CommonMethods.WebdriverWait_ElementClickable(driver, dd_PagecountArrow());
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_PagecountArrow());
            driver.FindElement(By.XPath("//div[@class='mat-select-arrow-wrapper']")).Click();

            CommonMethods.WebdriverWait_ElementClickable(driver, dd_Pagecount5());
            Assert.Equal("5", dd_Pagecount5().Text);
            Assert.Equal("10", dd_Pagecount10().Text);
            Assert.Equal("15", dd_PageCount15().Text);
            return new XPOD_HomePage_Xpodlist(driver);

        }
        /// <summary>
        /// Method to scroll down the page till end
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist ScrollTillEnd()
        {
            CommonMethods.Page_Scrolldown(driver);
            return new XPOD_HomePage_Xpodlist(driver);
        }

        /// <summary>
        ///Method to enter the search value in the search text box.
        ///Search value have passed as object JSON Objects
        /// </summary>
        /// <param name="DataObj"></param>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist Method_Enter_SearchElement(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "BVT_TestData");
            var SearchVal = data["Searchvalue"];
            TextBox_SeachEle().SendKeys(SearchVal.ToString());//sending the search value to the search textbox
            return new XPOD_HomePage_Xpodlist(driver);
        }
        /// <summary>
        /// To validate the Search box and Advanced find button is enabled
        /// </summary>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist Method_FieldValidations()
        {
            Assert.True(TextBox_SeachEle().Enabled);//element searchbox is enables or not
            Assert.True(btn_AdvancedFind().Displayed);//advanced find button validation
            return new XPOD_HomePage_Xpodlist(driver);
        }

        /// <summary>
        /// this method is to compare the dropdown view values and the list of mandatory values 
        /// given in the JSON file
        /// </summary>
        /// <param name="DataObj"></param>
        /// <returns></returns>
        public XPOD_HomePage_Xpodlist Method_SystemViewOptions_Validation(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "ViewList");
            int NumberofRec = 8;//Convert.ToInt16( data["NoRec"]);

            CommonMethods.WebdriverWait_ElementClickable(driver, dd_views());
            SelectElement options = new SelectElement(dd_views());
            IList<IWebElement> ViewOptions = options.Options;

            for (int i = 1; i <= NumberofRec; i++)
            {
                String s = i.ToString();
                int counter = 0;
                foreach (var Ele in ViewOptions)
                {
                    if ((data[s].ToString().Trim()).Equals(Ele.Text.Trim()))
                    {
                        counter = counter + 1;
                    }
                }
                Assert.NotEqual(0, counter);
            }

            return new XPOD_HomePage_Xpodlist(driver);
        }

        public XPOD_HomePage_Xpodlist SystemView_SelectionValidations(Object DataObj)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, "ViewList");
            int NumberofRec = 2;
            CommonMethods.WebdriverWait_ElementClickable(driver, dd_views());
            SelectElement options = new SelectElement(dd_views());
            for (int i = 0; i <= NumberofRec; i++)
            {
                options.SelectByText((data[i.ToString()]).ToString());

                if (i == 1)
                {
                    Status_Column();
                }

            }
            return new XPOD_HomePage_Xpodlist(driver);

        }
        /// <summary>
        /// Selecting the view value from the dropdown.
        /// values are passed through parameters.
        /// </summary>
        /// <param name="DataObj"></param>
        /// <param name="TestName"></param>
        /// <param name="TestValue"></param>
        /// <returns></returns>   

        public XPOD_HomePage_Xpodlist Method_SelectViewValue(Object DataObj, String TestName, String TestValue)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            var viewName = data[TestValue];
            CommonMethods.WebdriverWait_ElementClickable(driver, dd_views());
            SelectElement options = new SelectElement(dd_views());
            options.SelectByText(viewName.ToString());
            return new XPOD_HomePage_Xpodlist(driver);
        }
        /// <summary>
        /// This method is to click on the advanced find button
        /// </summary>
        /// <returns></returns>
        public AdvancedFind_Page Method_Clicking_AdvancedFind()
        {

            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_TillElementReady(driver, btn_AdvancedFind());
            btn_AdvancedFind().Click();
            return new AdvancedFind_Page(driver);
        }
        /// <summary>
        /// This method is to compare the given Column name and the column value
        /// </summary>
        /// <param name="ColumnName"></param>
        /// <param name="value"></param>
        public XPOD_HomePage_Xpodlist Method_validating_TableColumnValue(String ColumnName, String value)
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_TillElementReady(driver, Table_FirstEle());
            CommonMethods.WebdriverWait_TillElementReady(driver, Table_FirstEle());
            int counter = 0;
            IList<IWebElement> HeaderElements = TableHeaderRows();
            foreach (var colvalue in HeaderElements)
            {
                if (colvalue.Text == ColumnName)
                {
                    //counter = counter + 1;
                    String str = colvalue.GetAttribute("class");
                    String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                    IList<IWebElement> ColumnValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute + " mat-column-" + strHeaderAttribute + " ng-star-inserted']"));
                    if (ColumnValues.Count > 0)
                    {
                        counter = counter + 1;
                    }
                    foreach (var Ele in ColumnValues)
                    {
                        Assert.Contains(value, Ele.Text);
                    }

                }


            }

            if (counter == 0)
            {
                Console.WriteLine("The mentioned column is not avaiable in the screen");
                Assert.True(false);
            }

            return new XPOD_HomePage_Xpodlist(driver);

        }

        /// <summary>
        /// This method is to close the browser
        /// </summary>
        public void Method_closebrowser()
        {
            driver.Quit();
        }

        /// <summary>
        /// This method is to compare the passed view name and the default view name
        /// </summary>
        /// <param name="DataObj"></param>
        /// <param name="TestName"></param>
        /// <param name="TestValue"></param>
        public XPOD_HomePage_Xpodlist Method_ViewDropdown_ValueValidation(Object DataObj, String TestName, String TestValue)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            var viewname = data[TestValue];
            CommonMethods.WebdriverWait_ElementClickable(driver, dd_views());
            SelectElement dropdown = new SelectElement(dd_views());
            String str = dropdown.SelectedOption.Text;
            Assert.Equal(str.Trim(), viewname.ToString().Trim());
            return new XPOD_HomePage_Xpodlist(driver);
        }

        public XPOD_HomePage_Xpodlist Method_HeaderSortFunctionality_ASC()
        {
            IList<IWebElement> ListHeaderRows = TableHeaderRows();
            foreach (var HeaderEle in ListHeaderRows)
            {
                CommonMethods.WebdriverWait_TillElementReady(driver, HeaderEle);
                HeaderEle.Click();
                String str = HeaderEle.GetAttribute("class");
                String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                IList<IWebElement> ColumnEle = Columns(strHeaderAttribute);
                for (int i = 0; i < ColumnEle.Count; i++)
                {
                    int res=0;
                    if (HeaderEle.Text == "Created On")
                    {
                        if (i != ColumnEle.Count - 1)
                        {
                            CommonMethods.WebdriverWait_TillElementReady(driver, ColumnEle[i]);
                            DateTime dt1 = DateTime.ParseExact(ColumnEle[i].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime dt2 = DateTime.ParseExact(ColumnEle[i + 1].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            var tttt = ColumnEle[i].Text;
                            string tetst = ColumnEle[i].Text;
                            if (dt1 < dt2)
                            {
                                res = -1;
                            }
                        }
                    
                    }
                    else
                    { 
                        res = 0;
                        if (i != ColumnEle.Count - 1)
                        {                        
                            res = String.Compare(ColumnEle[i].Text, ColumnEle[i + 1].Text);
                        }
                    }

                    if (res > 0)
                    {
                        Assert.True(false);
                    }

                }


            }

            return new XPOD_HomePage_Xpodlist(driver);
        }

        public XPOD_HomePage_Xpodlist Method_HeaderSortFunctionality_DSC()
        {
            IList<IWebElement> ListHeaderRows = TableHeaderRows();
            foreach (var HeaderEle in ListHeaderRows)
            {
                
                HeaderEle.Click();
                HeaderEle.Click();
                String str = HeaderEle.GetAttribute("class");
                String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();
                IList<IWebElement> ColumnEle = Columns(strHeaderAttribute);

                for (int i = 0; i < ColumnEle.Count; i++)
                {
                    int res = 0;
                    if (HeaderEle.Text == "Created On")
                    {
                        if (i != ColumnEle.Count - 1)
                        {
                            DateTime dt1 = DateTime.ParseExact(ColumnEle[i].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            DateTime dt2 = DateTime.ParseExact(ColumnEle[i + 1].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            var tttt = ColumnEle[i].Text;
                            string tetst = ColumnEle[i].Text;
                            if (dt1 > dt2)
                            {
                                res = 1;
                            }
                        }
                    }
                    else
                    {
                        res = 0;
                        if (i != ColumnEle.Count - 1)
                        {
                            res = String.Compare(ColumnEle[i].Text, ColumnEle[i + 1].Text);
                        }
                    }

                    if (res < 0)
                    {
                        Assert.True(false);
                    }

                }


            }

            return new XPOD_HomePage_Xpodlist(driver);
        }
        public XPOD_HomePage_Header Method_ReloadApplication()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().Refresh();
            CommonMethods.PageLoadWait(driver, PageLoader());
            return new XPOD_HomePage_Header(driver);
        }

        public XPOD_HomePage_Xpodlist Method_ValidateDefaultView(Object DataObj, String TestName, String TestValue)
        {
            var data = GetDataAsJsonObject.DataReaderJobject(DataObj, TestName);
            SelectElement dd_Select = new SelectElement(dd_views());
            CommonMethods.WebdriverWait_TillElementReady(driver, dd_views());
            String strDefalutvalue = dd_Select.SelectedOption.Text.Trim();
            String strUsergivenView = data[TestValue].ToString().Trim();
            Assert.True(strDefalutvalue.Equals(strUsergivenView));
            return new XPOD_HomePage_Xpodlist(driver);
        }
        public XPOD_General_RI_Page Method_ClickXPODReqNo(String ColumnName, String value)
        {
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_ElementClickable(driver, Table_FirstEle());
            int counter = 0;
            IList<IWebElement> HeaderElements = TableHeaderRows();
            foreach (var colvalue in HeaderElements)
            {
                if (colvalue.Text == ColumnName)
                {
                    //counter = counter + 1;
                    String str = colvalue.GetAttribute("class");              
                    String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                    IList<IWebElement> ColumnValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute + " mat-column-" + strHeaderAttribute + " ng-star-inserted']"));
                    for (int i = 0; i < ColumnValues.Count; i++)
                    {
                        if (ColumnValues[i].Text.Equals(value))
                        {
                            IList<IWebElement> ReqnoList = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-refId mat-column-refId ng-star-inserted']"));
                            ReqnoList[i].Click();
                            return new XPOD_General_RI_Page(driver);                      

                        }
                    }
                }

            }
            Assert.True(false);
            return new XPOD_General_RI_Page(driver);

        }
        public XPOD_General_RI_Page Method_ClickXPODReqNo(String Col1, String val1,String Col2,String val2,String Col3, String val3)
        {
            //CommonMethods.Page_Scrolldown(driver);
            label:
            CommonMethods.PageLoadWait(driver, PageLoader());
            CommonMethods.WebdriverWait_ElementClickable(driver, Table_FirstEle());
            
            
            IList<IWebElement> HeaderElements = TableHeaderRows();
            foreach (var colvalue in HeaderElements)
            {
                if (colvalue.Text == Col1)
                {
                   
                    String str = colvalue.GetAttribute("class");
                    String strHeaderAttribute = str.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                    IList<IWebElement> ColumnValues = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute + " mat-column-" + strHeaderAttribute + " ng-star-inserted']"));
                    for (int i = 0; i < ColumnValues.Count; i++)
                    {
                        if (ColumnValues[i].Text.Equals(val1))
                        {
                            IList<IWebElement> HeaderElements2 = TableHeaderRows();
                            foreach (var col2val in HeaderElements2)
                            {
                                if (col2val.Text == Col2)
                                {
                                    String str2 = col2val.GetAttribute("class");
                                    String strHeaderAttribute2 = str2.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                                    IList<IWebElement> Column2Values = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute2 + " mat-column-" + strHeaderAttribute2 + " ng-star-inserted']"));
                                    if (Column2Values[i].Text.Equals(val2))
                                    {
                                        IList<IWebElement> HeaderElements3 = TableHeaderRows();
                                        foreach (var col3val in HeaderElements3)
                                        {
                                            if (col3val.Text == Col3)
                                            {
                                                String str3 = col3val.GetAttribute("class");
                                                String strHeaderAttribute3 = str3.Split(new string[] { "cdk-column-" }, StringSplitOptions.None)[1].Split(' ')[0].Trim();

                                                IList<IWebElement> Column3Values = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-" + strHeaderAttribute3 + " mat-column-" + strHeaderAttribute3 + " ng-star-inserted']"));
                                                if (Column3Values[i].Text.Equals(val3))
                                                {
                                                    IList<IWebElement> ReqnoList = driver.FindElements(By.XPath("//mat-cell[@class='mat-cell cdk-column-refId mat-column-refId ng-star-inserted']"));
                                                    CommonMethods.WebdriverWait_ElementClickable(driver, ReqnoList[i]);
                                                    ReqnoList[i].Click();
                                                    return new XPOD_General_RI_Page(driver);
                                                }

                                            }

                                        }
                                    }
                                }
                            }
                                    

                        }
                    }
                }

            }
            CommonMethods.ScrollTillElementViible(driver, Btn_Nextpage());
            while(Btn_Nextpage().Enabled)
            {
                CommonMethods.Page_Scrolldown(driver);
                Btn_Nextpage().Click();
                goto label;
            }

            Assert.True(false);
            return new XPOD_General_RI_Page(driver);

        }
    }   
}

