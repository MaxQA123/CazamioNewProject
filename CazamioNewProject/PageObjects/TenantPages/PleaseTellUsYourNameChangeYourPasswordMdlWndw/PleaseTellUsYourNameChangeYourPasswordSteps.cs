using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
{
    public partial class PleaseTellUsYourNameChangeYourPasswordMdlWndw
    {
        [AllureStep("QuicklyPassTenantCreatorMySpace")]
        public PleaseTellUsYourNameChangeYourPasswordMdlWndw QuicklyPassTenantCreatorMySpace()
        {
            VerifyTitlePleaseTellUsYourNameAndChangeYourPassword();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSuccessfullyUpdatedNameAndPassword();

            return this;
        }

        [AllureStep("QuicklyPassTenantOccupantMySpace")]
        public PleaseTellUsYourNameChangeYourPasswordMdlWndw QuicklyPassTenantOccupantMySpace()
        {
            VerifyTitlePleaseTellUsYourNameAndChangeYourPassword();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantOccupantMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantOccupantMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSuccessfullyUpdatedNameAndPassword();

            return this;
        }

        [AllureStep("QuicklyPassTenantGuarantorMySpace")]
        public PleaseTellUsYourNameChangeYourPasswordMdlWndw QuicklyPassTenantGuarantorMySpace()
        {
            VerifyTitlePleaseTellUsYourNameAndChangeYourPassword();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantGuarantorMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantGuarantorMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.WaitSomeInterval(100);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSuccessfullyUpdatedNameAndPassword();

            return this;
        }
    }
}
