using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.Page;
using TechnicalValidationTool.TestAutomation.Workflow;

[assembly: CollectionBehavior(MaxParallelThreads = 1)]
namespace TechnicalValidationTool.TestAutomation.Test.BVT_TestFiles
{
    public class BVTTests_Pagination_Validation : TestBase
    {

        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void pagination_Validations(Object Value)
        {
            
            new Workflows(webDriverTest).BVT_Pagination_Test(Value);
        }
       
    }

    public class BVTTests_HomrField_Validation : TestBase
    {
                
        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void HomePage_Field_validations(Object DataObj)
        {

            new Workflows(webDriverTest).BVT_HomepageField_Validation(DataObj);
        }        

    }
    public class BVTTests_SearchFunction_Validation : TestBase
    {

        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void SearchFunction_Validatons(Object DataObj)
        {
            new Workflows(webDriverTest).BVT_SeachFunction_Validations(DataObj);
        }

    }
    public class BVTTests_GenTabFields_Validation : TestBase
    {

        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]

        public void GeneralTab_Field_Validations(Object DataObj)
        {
            new Workflows(webDriverTest).BVT_GenralTab_feild_Validations(DataObj);
        }

    }
    public class BVTTests_NotesSection_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void Notes_Section_Validations(Object DataObj)
        {

            new Workflows(webDriverTest).BVT_Notes_Section_Validations(DataObj);
        }

    }

    public class BVTTests_ActivitesTab_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "BVT_TestCase")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void Activites_Tab_validations(Object DataObj)
        {
            new Workflows(webDriverTest).BVT_Activites_Tab_Validations(DataObj);
        }


    }
}
