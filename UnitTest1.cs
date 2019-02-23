//using System;
//using TechnicalValidationTool.TestAutomation.Base;
//using TechnicalValidationTool.TestAutomation.Page;
//using TechnicalValidationTool.TestAutomation.Workflow;
//using Xunit;


//[assembly: CollectionBehavior(MaxParallelThreads = 1)]
//namespace TechnicalValidationTool.TestAutomation
//{
//    public class UnitTest1 : TestBase
//    {


        //        public UnitTest1():base()
        //        {

        //        }

//        [Theory]
//[Trait("Category", "DynamicReroutingTests")]
//[JsonFileData("Data\\GE1\\Datajson.json")]
//public void Test1(object value)
//{
//    new Workflows(webDriverTest).googleTest1();


//    //PageBase.googlePage.DriverInstance.Navigate().GoToUrl("http://www.google.com");
//    //PageBase.googlePage.searchBox.SendKeys("wwwwwwwwwwwwwwwwwwwwwwwwww");
//    //System.Threading.Thread.Sleep(2000);
//    //Assert.False(true);
//}


//    }

//    public class UnitTest2 : TestBase, IDisposable
//    {

//        public UnitTest2():base()
//        {
//        }
//        [Fact]
//        public void Test2()
//        {

//            new Workflows(webDriverTest).googleTest2();
//            //new GooglePage().DriverInstance.Navigate().GoToUrl("http://www.google.com");
//            //new GooglePage().searchBox.SendKeys("popopoppoo");
//            //System.Threading.Thread.Sleep(4000);
//            //Assert.False(false);
//        }
//    }
//}
