using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Newtonsoft.Json.Linq;
using TechnicalValidationTool.TestAutomation;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace TechnicalValidationTool.TestAutomation.CommonMethod
{
    public class CommonMethods
    {
        
        
        public IWebDriver Page_Scrolldown(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            return driver;
        }
        //Webdriver Wait
        public IWebDriver WebdriverWait_ElementClickable(IWebDriver driver, IWebElement Element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Element));
            return driver;
        }
        public IWebDriver Page_ScrollUp(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-1000)");
            return driver;
        }
        public IWebDriver WebdriverWait_ElementToBeSelected(IWebDriver driver, IWebElement Element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeSelected(Element));
            return driver;
        }
        public IWebDriver WebdriverWait_TillElementReady(IWebDriver driver, IWebElement Element)
        {
            Thread.Sleep(2000);
            int MinWatiTime = 500;int Loopcount=10;
            switch (Element.TagName)
            {
                
                case "select":

                    lb:
                    try
                    {
                        SelectElement Select = new SelectElement(Element);
                        String str = Select.SelectedOption.Text;
                        for (int i = 0; i < Loopcount; i++)
                        {
                            if (Select.SelectedOption.Text == null)
                            {
                                Thread.Sleep(MinWatiTime);
                            }
                            
                        }
                        return driver;
                    }

                    catch
                    {
                        Thread.Sleep(MinWatiTime);
                        goto lb;

                    }
                    

                case "input":
                    try { 
                            for( int i=0;i<Loopcount;i++)
                            {
                                if(!Element.Displayed||!Element.Enabled)
                                {
                                    Thread.Sleep(MinWatiTime);
                                }

                            }
                        return driver;
                        }
                        catch
                        {
                             return driver;
                        }
                case "div":
                    try
                    {
                        for (int i = 0; i < Loopcount; i++)
                        {
                            if (!Element.Displayed||!Element.Enabled)
                            {
                                Thread.Sleep(MinWatiTime);
                            }

                        }
                        return driver;
                    }
                    catch
                    {
                        return driver;
                    }
                case "button":
                    try
                    {
                        for (int i = 0; i < Loopcount; i++)
                        {
                            if (!Element.Enabled)
                            {
                                Thread.Sleep(MinWatiTime);
                            }

                        }
                        return driver;
                    }
                    catch
                    {
                        return driver;
                    }
                case "mat-table":
                    try
                    {
                        for (int i = 0; i < Loopcount; i++)
                        {
                            if (!Element.Displayed)
                            {
                                Thread.Sleep(MinWatiTime);
                            }

                        }
                        return driver;
                    }
                    catch
                    {
                        return driver;
                    }
                default:
                    return driver;
                
            }
        }
        public IWebDriver PageLoadWait(IWebDriver driver, By by)
        {
            try
            {
                int counter = 1;
                while(driver.FindElement(by).Displayed==true)
                {
                    Thread.Sleep(500);
                    if(counter >20)
                    {
                        break;
                    }
                    counter = counter + 1;
                }
            }
            catch
            {                
                return driver;
            }

            Console.Write("page is not loading");
            return driver;
        }

        public IWebDriver Wait_TillTextbox_Clear(IWebDriver driver, IWebElement Element)
        {
            lb:
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Element.Text!=null)
                    {
                        Element.Clear();
                        Thread.Sleep(500);
                    }
                }
            }
            catch
            {
                goto lb;
            }
            return driver;
        }

        public void ScrollTillElementViible(IWebDriver driver, IWebElement Element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", Element);
        }
                     
    }
    }
