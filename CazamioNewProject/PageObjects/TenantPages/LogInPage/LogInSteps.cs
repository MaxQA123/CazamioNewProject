using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        #region My Space

        [AllureStep("LogInAsCreatorWithoutCreditReportMySpace")]
        public LogInTenant LogInAsCreatorWithoutCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantCreatorMySpace.CreatedWithoutCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("LogInAsCreatorWithCreditReportMySpace")]
        public LogInTenant LogInAsCreatorWithCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantCreatorMySpace.CreatedWithCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("LogInAsOccupantWithoutCreditReportMySpace")]
        public LogInTenant LogInAsOccupantWithoutCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantOccupantMySpace.CreatedWithoutCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("LogInAsOccupantWithCreditReportMySpace")]
        public LogInTenant LogInAsOccupantWithCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantOccupantMySpace.CreatedWithCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("LogInAsGuarantorWithoutCreditReportMySpace")]
        public LogInTenant LogInAsGuarantorWithoutCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantGuarantorMySpace.CreatedWitoutCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("LogInAsGuarantorWithCreditReportMySpace")]
        public LogInTenant LogInAsGuarantorWithCreditReportMySpace()
        {
            Pages.HeaderTenants
               .ClickButtonLogIn();
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantGuarantorMySpace.CreatedWithCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(CheckBoxRememberMe);
            Button.Click(ButtonLogIn);

            return this;
        }

        #endregion
    }
}
