using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalValidationTool.TestAutomation.Base;
using TechnicalValidationTool.TestAutomation.Page;
using TechnicalValidationTool.TestAutomation.CommonMethod;
using Xunit;
using System.Threading;

namespace TechnicalValidationTool.TestAutomation.Workflow
{
    public class Workflows : PageBase
    {
        private static IWebDriver webDriver;

        public Workflows(IWebDriver driverInstance)
        {
            webDriver = driverInstance;
        }

        //public void googleTest1()
        //{
        //   //new GooglePage(webDriver).NaviagateToGoogle();
        //   new GooglePage(webDriver).searchBox.SendKeys("wewewewewwwwwwwwwwwww");
        //   System.Threading.Thread.Sleep(2000);
        //  Assert.False(true);
        //}

        //public void googleTest2()
        //{
        //    new GooglePage(webDriver).NaviagateToGoogle();
        //    new GooglePage(webDriver).searchBox.SendKeys("pppppppppppppppppppppppppp");
        //    System.Threading.Thread.Sleep(2000);
        //    //Assert.False(true);
        //}

        public void BVT_Pagination_Test(Object value)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(value);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(value, "BVT_TestData", "Viewname").ScrollTillEnd().Pagination_validation();
        }
        public void BVT_HomepageField_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj).Field_Validations();
            new XPOD_HomePage_Xpodlist(webDriver).Method_FieldValidations().Method_SelectViewValue(DataObj, "BVT_TestData", "Viewname");
        }
        public void BVT_SeachFunction_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_Enter_SearchElement(DataObj).searchfunction(DataObj);
        }

        public void BVT_GenralTab_feild_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations();
        }

        public void BVT_Notes_Section_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).First_tableEle_Click().Switching_GeneralBasePage().Clicking_NotesTab();
            int beforeNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).Creating_Notes(DataObj).CreatedNote_Validation(DataObj, beforeNotesCount);

        }
        public void BVT_Activites_Tab_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "BVT_TestData", "Viewname").First_tableEle_Click().Switching_GeneralBasePage().Clicking_ActivitesTab().Activity_Table_Generation_Validation();
        }

        public void Installation_SecValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "BVT_TestData", "Viewname").First_tableEle_Click().Switching_GeneralBasePage().Clicking_InstallationSec().InstallSec_Fields_Validations().installSecPage_FeildsArenotNull_validation().FieldEdit_Validation(DataObj).SwitchingTo_GenBasePage().Clicking_NotesTab().SwitchingTo_GenBasePage().Clicking_InstallationSec().Validating_Edited_Fields(DataObj);

        }
        public void Attachment_SecValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "BVT_TestData", "Viewname").First_tableEle_Click().Switching_GeneralBasePage().Clicking_AttachementTab().AttachmentTab_Validation();

        }
        public void SystemView_Dropdown_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SystemViewOptions_Validation(DataObj).Method_SelectViewValue(DataObj, "ViewList", "3").Method_validating_TableColumnValue("Status", "Canceled");
        }

        public void GenTabButton_XPOD_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations().GeneralTabButton_Validations_PendingSubmissionXPODs();
            new XPOD_HomePage_Header(webDriver).Method_Clicking_ValidationListButton();

            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations().GeneralTabButton_Validations_PendingSubmissionXPODs();
            new XPOD_HomePage_Header(webDriver).Method_Clicking_ValidationListButton();

            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View3").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations().GeneralTabButton_Validations_CanDenApprovedXPODs();
            new XPOD_HomePage_Header(webDriver).Method_Clicking_ValidationListButton();

            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View4").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations().GeneralTabButton_Validations_CanDenApprovedXPODs();
            new XPOD_HomePage_Header(webDriver).Method_Clicking_ValidationListButton();

            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View5").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_Genral_OI_Page(webDriver).General_OIFeild_Validations().GeneralTabButton_Validations_CanDenApprovedXPODs();
        }

        public void FullDbSearch_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj).EnterSearchElement_FullDbSearch(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).searchfunction(DataObj);
        }
        public void CreateandEditView_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_Clicking_AdvancedFind().click_CreateNewViewButton().CreateNewView_FieldValidations().Entering_NewView_Details(DataObj).Click_CreateView().Method_SelectViewValue(DataObj, "TestData", "View").Method_validating_TableColumnValue("Status", "Denied");
            new XPOD_HomePage_Xpodlist(webDriver).Method_Clicking_AdvancedFind().AdvancedFind_SelectView(DataObj, "TestData", "View").Method_EditAdvanvedFind_Views(DataObj).Method_ClickSaveView_Button().Method_validating_TableColumnValue("Source", "OSC").Method_ViewDropdown_ValueValidation(DataObj, "TestData", "EditViewname");
        }

        public void AdvancedFind_RetriveRecord_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_Clicking_AdvancedFind().click_CreateNewViewButton().Entering_NewView_Details(DataObj).Click_Find().Method_validating_TableColumnValue("Status", "Denied"); ;
        }
        public void AdvacnedFind_CloseFunction_validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);

            new XPOD_HomePage_Xpodlist(webDriver).Method_Clicking_AdvancedFind().AdvancedFind_SelectView(DataObj, "Test5867945", "View1").AdvanceFind_CloseFun();
        }
        public void SetDefaultView_validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_Clicking_AdvancedFind().Method_ComparingDefaultView_UsergivenValue(DataObj, "Test5867945", "View1");
            new XPOD_HomePage_Xpodlist(webDriver).Method_ReloadApplication();
            new XPOD_HomePage_Xpodlist(webDriver).Method_ValidateDefaultView(DataObj, "Test5867945", "View1");
        }


        public void GenTab_FieldEditandSave_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "BVT_TestData", "Viewname").First_tableEle_Click().Method_EditFields(DataObj);
            new XPOD_Genral_OI_Page(webDriver).Method_EditDealID_Field(DataObj).Mehod_ClickSaveButton().Method_SwitchingtoStaticPage().Clicking_NotesTab().SwitchingTo_GenBasePage().SwitchingTo_GenRIPage().Method_Validate_EditedFields(DataObj);
            new XPOD_Genral_OI_Page(webDriver).Method_Validate_EditedOIPageFields(DataObj);

        }
        public void SortFunctionality_Validations(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_HeaderSortFunctionality_ASC().Method_HeaderSortFunctionality_DSC();

        }
               
        //new methods

        public void validateAssign(Object DataObj)
        {

            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click().General_RIFeild_Validations();
            new XPOD_AssignPage(webDriver).clickSECDropdown();
            new XPOD_AssignPage(webDriver).selectSEC(DataObj, "SECList", "1");
        }
        public void validateXPODList(Object DataObj)
        {

            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click();
            new XPOD_ActivitesTab_Page(webDriver).validateList();
        }

        public void validateSaveAndNotify(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click();
            new XPOD_ActivitesTab_Page(webDriver).saveNotify();
        }

        public void validateBtn(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click();
            new XPOD_ValidatePage(webDriver).validateXPOD();
        }

        public void validateViewSub(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").First_tableEle_Click();
            new XPOD_ActivitesTab_Page(webDriver).viewSub();
        }

        public void Homepage_ViewDropdown_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View3").Method_validating_TableColumnValue("Status", "Approved").Method_SelectViewValue(DataObj, "Test5867945", "View4").Method_validating_TableColumnValue("Status", "Canceled");
        }
        public void AssignedCMLNewSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned", "Product Line", "CML", "Order Type", "New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Assigned").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForAssignedXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_AssignedCMLNewSys(RIData, OIData).Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void SubmittedCMLNewSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted", "Product Line", "CML", "Order Type", "New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Submitted").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForSubmittedCMLXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_SubmittedCMLXPOD(RIData, OIData);
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void AssignedCMLUpgradeNewSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned", "Product Line", "CML", "Order Type", "Upgrade New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Assigned").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForAssignedXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_AssignedCMLNewSys(RIData, OIData).Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void AssignedCMLUpgradeExistingSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned", "Product Line", "CML", "Order Type", "Upgrade Existing System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Assigned").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForAssignedXPOD(RIData, OIData).Method_ValidateEmailBody_AssignedCMLNewSys(RIData, OIData).Method_ViewSystSummaryRep_Validation().Method_ViewWebCST_Validation().Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void SubmittedCMLUpgradeExistingSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted", "Product Line", "CML", "Order Type", "Upgrade Existing System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Submitted").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForSubmittedCMLXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_SubmittedCMLXPOD(RIData, OIData).Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation().Method_ViewSystSummaryRep_Validation().Method_ViewWebCST_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void SubmittedEQLXPOD_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted", "Product Line", "EQL", "Order Type", "Non-Standard Reference Architecture");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Submitted").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForEQLXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_SubmittedEQLXPOD(RIData, OIData).Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation().Method_DellSupportLink_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void AssignedEQLXPOD_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned", "Product Line", "EQL", "Order Type", "Non-Standard Reference Architecture");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmailExclude("Status", "Assigned").Method_ValidateEmailHeaderLabels().Method_ValidateEmailHeaderFields_ForEQLXPOD(RIData, OIData).EmailBody_ViewValReqLink_Validation(RIData).Method_ValidateEmailBody_AssignedEQLXPOD(RIData, OIData).Method_EmailValidateBtn_Validation().Method_EmailAssignBtn_Validation().Method_DellSupportLink_Validation();
            new XPOD_Email_SubmissionInformation_Page(webDriver).Method_EmailCustSolutioinInfo_Validation(RIData, OIData).Method_OtherEmailSectionValidation(RIData);
        }
        public void ValidateResponse_InsertApprovedResp_CMLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 12).Method_SelectResponse("BP Install");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "BP Install").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "BP Install", InitialNotesCount);
        }
        public void ValidateResponse_InsertApprovedResp_CMLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 12).Method_SelectResponse("FS8600");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "FS8600").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "FS8600", InitialNotesCount);
        }
        public void ValidateResponse_InsertApprovedResp_CMLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "AMER").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 12).Method_SelectResponse("16GB FC CARD");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "16GB FC CARD").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "16GB FC CARD", InitialNotesCount);
        }
        public void ValidateResponse_InsertApprovedResp_EQLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 0).Method_SelectResponse("Blank");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "Blank").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "Blank", InitialNotesCount);
        }
        public void ValidateResponse_InsertApprovedResp_EQLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 0).Method_SelectResponse("Blank");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "Blank").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "Blank", InitialNotesCount);
        }
        public void ValidateResponse_InsertApprovedResp_EQLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "AMER").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValRespforEQLAMER", 35).Method_SelectResponse("LIMITED SWITCH DESIGN FOR FS76XX");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "LIMITED SWITCH DESIGN FOR FS76XX").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "LIMITED SWITCH DESIGN FOR FS76XX", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_EQLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "AMER").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertPendingValRespEQLAMER", 7).Method_SelectResponse("MISSING END USER INSTALLATION");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "MISSING END USER INSTALLATION").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "MISSING END USER INSTALLATION", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_EQLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 0).Method_SelectResponse("Blank");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "Blank").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "Blank", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_EQLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertAppValResp", 0).Method_SelectResponse("Blank");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "Blank").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "Blank", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_CMLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertPendingValRespCML", 7).Method_SelectResponse("REPLICATION");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "REPLICATION").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "REPLICATION", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_CMLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertPendingValRespCML", 7).Method_SelectResponse("I/O PORTS");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "I/O PORTS").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "I/O PORTS", InitialNotesCount);
        }
        public void ValidateResponse_InsertPendingResp_CMLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Pending Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertPendingValRespCML", 7).Method_SelectResponse("MIXED DRIVES");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "MIXED DRIVES").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "MIXED DRIVES", InitialNotesCount);
        }
        public void ValidateResponse_InsertDeniedResp_EQLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "AMER").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertDeniedValRespEQL", 4).Method_SelectResponse("Denial Note via DellStar");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "Denial Note via DellStar").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "Denial Note via DellStar", InitialNotesCount);
        }
        public void ValidateResponse_InsertDeniedResp_EQLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Assigned").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_EmptyValResp_Validation();
        }
        public void ValidateResponse_InsertDeniedResp_EQLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("EqualLogic", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_EmptyValResp_Validation();
        }
        public void ValidateResponse_InsertDeniedResp_CMLAMER_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "AMER").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertDeniedValRespCML", 2).Method_SelectResponse("ENV INFO MISSING");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "ENV INFO MISSING").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "ENV INFO MISSING", InitialNotesCount);
        }
        public void ValidateResponse_InsertDeniedResp_CMLAPJ_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertDeniedValRespCML", 1).Method_SelectResponse("ENV INFO MISSING");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "ENV INFO MISSING").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "ENV INFO MISSING", InitialNotesCount);
        }
        public void ValidateResponse_InsertDeniedResp_CMLEMEA_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted").Switching_GeneralBasePage().Clicking_NotesTab();
            int InitialNotesCount = new XPOD_NotesTab_Page(webDriver).Getting_NotesTableCount();
            new XPOD_NotesTab_Page(webDriver).SwitchingTo_GenBasePage().SwitchingTo_GenRIPage();
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Insert Denied Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "EMEA").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_ValidateResponsesInMultiselectValues(DataObj, "InsertDeniedValRespCML", 1).Method_SelectResponse("ENV INFO MISSING");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_SelectedResComment(DataObj, "ValRespComments", "ENV INFO MISSING").Method_Click_AddCommentsButton();
            webDriver.SwitchTo().Window(MainWindow);
            new XPOD_General_StaticEle_Page(webDriver).Clicking_NotesTab().Method_Validate_ResponseComments(DataObj, "ValRespComments", "ENV INFO MISSING", InitialNotesCount);
        }
        public void ValidateResponse_AddandEditNewValidationTemp_Validation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View1").Method_ClickXPODReqNo("Status", "Submitted");
            String MainWindow = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_RightClickComments().Method_Validate_ValidateRightClickOption();
            String ChildWindValidate = webDriver.CurrentWindowHandle;
            new XPOD_ValidatePage(webDriver).Method_Click_ValidateOptions("Add New Response Template");
            new XPOD_AddNewValidationTemp_Page(webDriver).Method_AddNewValResp_PageFields_Validation().Method_ddProductLine_Validation().Method_ddRegion_Validation().Method_ddValReqstatus_Validation().CreateTemplate("Approved", "Dell Storage", "APJ").Validate_TempAlreadyExisit();
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Rightclick().Method_Click_ValidateOptions("Insert Approved Validation Response").Method_ValidatePageFields().Method_SelectProductLineandRegioin("Dell Storage", "APJ").Method_Click_BtnOk().Method_Validate_SpecificValRespTemp("AutomationTest Template new").Method_Click_BtnCancel();
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Rightclick().Method_Click_ValidateOptions("Edit Existing Validation Response");
            new XPOD_EditExistingValRespTemp_Page(webDriver).Method_EditRespTemp_FieldValidations().SelectTemplateOptions("Approved", "Dell Storage", "APJ").Method_SelectRespTemp("AutomationTest Template new").Method_EditTempName("Edited Automation Test Template Latest").Method_EditTempDescp("Edited Automation Test Template Description123").Click_BtnAdd();
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Rightclick().Method_Click_ValidateOptions("Insert Approved Validation Response").Method_SelectProductLineandRegioin("Dell Storage", "APJ").Method_Click_BtnOk().Method_ValidateResponsePageFields().Method_SelectResponse("Edited Automation Test Template Latest");
            webDriver.SwitchTo().Window(ChildWindValidate);
            new XPOD_ValidatePage(webDriver).Method_Validate_ResponseComment("Edited Automation Test Template Description123");

        }
        //New Methods
        public void ApprovedCML_EmailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View3").Method_ClickXPODReqNo("Status", "Approved", "Product Line", "CML", "Order Type", "New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Approved").Method_ValidateEmailHeaderFieldsApprovedCML(RIData, OIData).EmailBody_ViewReqLink_ValidationPending(RIData).EmailBody_ValReqLink_ValidationPending(RIData);
            //new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(RIData, OIData).EmailBody_ValReqLink_ValidationPending(RIData);
        }
       
        public void DeniedEQL_EmailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View5").Method_ClickXPODReqNo("Status", "Denied", "Product Line", "EQL", "Order Type", "Non-Standard Reference Architecture");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Denied").Method_ValidateEmailHeaderFieldsDenied(RIData, OIData).EmailBody_ViewReqLink_ValidationPending(RIData).EmailBody_ValReqLink_ValidationDenied(RIData);
            //new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(RIData, OIData).EmailBody_ValReqLink_ValidationPending(RIData);
        }
        public void PendingDellStorageNewSystem_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending", "Product Line", "CML", "Order Type", "New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingNewSystem(RIData, OIData).EmailBody_ViewReqLink_ValidationPending(RIData);            
        }
        public void PendingDellStorageUpgrade_emailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending", "Product Line", "CML", "Order Type", "Upgrade New System");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(RIData, OIData).EmailBody_ViewReqLink_ValidationPending(RIData).EmailBody_ValReqLink_ValidationPending(RIData);
            //new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(RIData, OIData).EmailBody_ValReqLink_ValidationPending(RIData);
        }
        public void PendingEQL_EmailValidation(Object DataObj)
        {
            new XPOD_HomePage_Header(webDriver).Login_XPOD(DataObj);
            new XPOD_HomePage_Xpodlist(webDriver).Method_SelectViewValue(DataObj, "Test5867945", "View2").Method_ClickXPODReqNo("Status", "Pending", "Product Line", "EQL", "Order Type", "Non-Standard Reference Architecture");
            Dictionary<String, String> RIData = new XPOD_General_RI_Page(webDriver).GetRIData_FieldValues();
            Dictionary<String, String> OIData = new XPOD_Genral_OI_Page(webDriver).GetOI_FieldValues();
            new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingEQL(RIData, OIData).EmailBody_ViewReqLink_ValidationPending(RIData).EmailBody_ValReqLink_ValidationPending(RIData);
            //new XPOD_Genral_OI_Page(webDriver).Method_SwitchingtoStaticPage().Clicking_ActivitesTab().Method_ClickEmail("Status", "Pending").Method_ValidateEmailHeaderFieldsPendingUpgradeNewSys(RIData, OIData).EmailBody_ValReqLink_ValidationPending(RIData);
        }

    }
}
