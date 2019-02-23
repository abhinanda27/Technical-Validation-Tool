using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.Workflow;

namespace TechnicalValidationTool.TestAutomation.Test.P1_TestFiles
{
    public class InstallationSection_Validation:TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void Installation_Section_Validations(Object DataObj)
        {
            new Workflows(webDriverTest).Installation_SecValidation(DataObj);
        }
        
    }
    //2
    public class AttachmentSection_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void Attachment_Section_Validations(Object DataObj)
        {
            new Workflows(webDriverTest).Attachment_SecValidation(DataObj);
        }
    }
    //3
    public class SystemViewDropdown_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void SystemViews_Dropdown_Validations(Object DataObj)
        {
            new Workflows(webDriverTest).SystemView_Dropdown_Validation(DataObj);
        }
    }
    //4
    public class GenTabButtons_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void GenTabButton_XPOD_Validations(Object DataObj)
        {
            new Workflows(webDriverTest).GenTabButton_XPOD_Validations(DataObj);
        }
    }
    //5
    public class FullDBSearch_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void FullDbSearch_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).FullDbSearch_Validations(DataObj);
        }
    }
    //6    
    public class CreateandEditView_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void CreateandEdit_View_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).CreateandEditView_Validation(DataObj);
        }
    }
    //7
    public class AdvancedFind_RetriveRecord_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void RetriveRecrod_AdvancedFind_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).AdvancedFind_RetriveRecord_Validation(DataObj);
        }
    }
    //8
    public class AdvancedFind_CloseFun_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void AdvancedFind_closefunction_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).AdvacnedFind_CloseFunction_validation(DataObj);
        }
    }
    //9
    public class SetDefaultView_Function_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void SetDefaultView_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).SetDefaultView_validation(DataObj);

        }
    }   
     //10
     public class GenTab_EditandSaveFields_Validation : TestBase

     {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void GenTab_FieldEditandSave_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).GenTab_FieldEditandSave_Validations(DataObj);
        }
     }
    //11
     public class XPODList_SortFunction_Validation : TestBase

     {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void SortFunctionality_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).SortFunctionality_Validations(DataObj);
        }
    }
    
    //13
    public class GenTab_AssignButton_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void GenTab_AssignBtn_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).validateAssign(DataObj);
        }

    }
    //14
    public class GenTab_ValidationListButton_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5841136--author Abhi
        public void GenTab_ValidationListBtn_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).validateXPODList(DataObj);
        }
    }

    //15
    public class ValidateButton_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        //Test Case 5841136--author Abhi
        public void GenTab_ValidateBtn_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).validateBtn(DataObj);
        }
    }

    //16
    public class GenTab_SaveandNotfyButton_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        //Test Case 5841136--author Abhi
        public void GenTab_SaveandNotofyBtn_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).validateSaveAndNotify(DataObj);
        }
    }

    //17
    public class GenTab_ViewSubButton_Validation : TestBase

    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5841136--author Abhi
        public void GenTab_ViewSubBtn_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).validateViewSub(DataObj);

        }
    }

    //P2&P3 Cases
    //18
    public class XPODHomePage_ViewSelection_Validation : TestBase
    {
       [Theory]
       [Trait("Category", "Regression_TestCases")]
       [JsonFileData("Data\\BVT_TestData.json")]
       public void Homepage_Viewdropdownselection_Validation(Object DataObj)
       {
            new Workflows(webDriverTest).Homepage_ViewDropdown_Validation(DataObj);
       }
    }

    //19
    public class EmailValidation_AssignedCMLNewSystemXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_AssignedCMLNewSystem(Object DataObj)
        {
            new Workflows(webDriverTest).AssignedCMLNewSystem_emailValidation(DataObj);
        }
    }  

    public class EmailValidation_AssignedCMLUpgradeNewSystemXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_ForAssignedCMLUpgradeNewSystemXPOD(Object DataObj)
        {
            new Workflows(webDriverTest).AssignedCMLUpgradeNewSystem_emailValidation(DataObj);
        }
    }
    public class EmailValidation_AssignedCMLUpgradeExistingSystemXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_ForAssignedCMLUpgradeExistingSystem(Object DataObj)
        {
            new Workflows(webDriverTest).AssignedCMLUpgradeExistingSystem_emailValidation(DataObj);
        }
    }
    public class EmailValidation_SubmittedCMLNewSystemXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_SubmittedCMLNewSystem(Object DataObj)
        {
            new Workflows(webDriverTest).SubmittedCMLNewSystem_emailValidation(DataObj);
        }
    }
    public class EmailValidation_SubmittedCMLUpgradeExistingSystemXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_ForSubmittedCMLUpgradeExistingSystem(Object DataObj)
        {
            new Workflows(webDriverTest).SubmittedCMLUpgradeExistingSystem_emailValidation(DataObj);
        }
    }
    public class EmailValidation_SubmittedEQLXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_ForSubmittedEQLXPOD(Object DataObj)
        {
            new Workflows(webDriverTest).SubmittedEQLXPOD_emailValidation(DataObj);
        }
    }
    public class EmailValidation_AssignedEQLXPOD : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void EmailValidation_ForAssignedEQLXPOD(Object DataObj)
        {
            new Workflows(webDriverTest).AssignedEQLXPOD_emailValidation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_CML_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_CMLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_CMLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_CML_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_CML_EMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_CMLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_CML_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_CML_AMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_CMLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_EQL_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_EQLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_EQLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_EQL_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_EQLEMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_EQLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertApproved_EQL_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertApprovedValidationResponse_EQLAMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertApprovedResp_EQLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_EQL_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_EQLAMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_EQLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_EQL_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_EQLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_EQLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_EQL_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_EQLEMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_EQLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_CML_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_CMLAMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_CMLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_CML_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_CMLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_CMLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertPending_CML_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertPendingValidationResponse_CMLEMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertPendingResp_CMLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_EQL_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_EQLAMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_EQLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_EQL_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_EQLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_EQLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_EQL_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_EQLEMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_EQLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_CML_AMER_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_CMLAMER_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_CMLAMER_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_CML_APJ_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_CMLAPJ_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_CMLAPJ_Validation(DataObj);
        }
    }
    public class ValidateResponse_InsertDenied_CML_EMEA_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void InsertDeniedValidationResponse_CMLEMEA_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_InsertDeniedResp_CMLEMEA_Validation(DataObj);
        }
    }
    public class ValidateResponse_AddandEditNewRespTemp_Validation : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        public void AddandEditNewValidationTemp_Validation(Object DataObj)
        {
            new Workflows(webDriverTest).ValidateResponse_AddandEditNewValidationTemp_Validation(DataObj);
        }
    }

    /// <summary>
    /// new methods
    /// </summary>
    public class EmailValidation_PendingDellStorageUpgrade : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5867896-- Abhi
        public void EmailValidation_PendingDellStorageUpg(Object DataObj)
        {
            new Workflows(webDriverTest).PendingDellStorageUpgrade_emailValidation(DataObj);
        }
    }


    public class EmailValidation_PendingEqualLogic : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5867884-- Abhi
        public void EmailValidation_PendingEQL(Object DataObj)
        {
            new Workflows(webDriverTest).PendingEQL_EmailValidation(DataObj);
        }
    }

    public class EmailValidation_DeniedEmail : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5867926-- Abhi
        public void EmailValidation_Denied(Object DataObj)
        {
            new Workflows(webDriverTest).DeniedEQL_EmailValidation(DataObj);
        }
    }

    public class EmailValidation_ApprovedEmail : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5867937-- Abhi
        public void EmailValidation_Approved(Object DataObj)
        {
            new Workflows(webDriverTest).ApprovedCML_EmailValidation(DataObj);
        }
    }
    
    public class EmailValidation_PendingDellStorageNewSys : TestBase
    {
        [Theory]
        [Trait("Category", "Regression_TestCases")]
        [JsonFileData("Data\\BVT_TestData.json")]
        ////Test Case 5867896-- Abhi
        public void EmailValidation_PendingDellStorageNewSystem(Object DataObj)
        {
            new Workflows(webDriverTest).PendingDellStorageNewSystem_emailValidation(DataObj);
        }
    }

}
