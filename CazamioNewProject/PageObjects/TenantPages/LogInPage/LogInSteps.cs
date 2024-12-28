using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        [AllureStep("EnterEmailPasswordAsTenantCreatorWithoutCreditReport")]
        public LogInTenant EnterEmailPasswordAsTenantCreatorWithoutCreditReport()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantCreatorMySpace.CreatedWitoutCreditReport.Email);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        //[AllureStep("EnterEmailPasswordAsOccupant")]
        //public LogInTenant EnterEmailPasswordAsOccupant()
        //{
        //    WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
        //    InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantOccupant.EmailAddressTenant);
        //    InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

        //    return this;
        //}

        //[AllureStep("EnterEmailPasswordAsGuarantor")]
        //public LogInTenant EnterEmailPasswordAsGuarantor()
        //{
        //    WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
        //    InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantGuarantor.EmailAddressTenant);
        //    InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

        //    return this;
        //}

        //[AllureStep("EnterEmailNewPassword")]
        //public LogInTenant EnterEmailNewPassword()
        //{
        //    WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
        //    InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantApplicant.EmailAddressTenant);
        //    WaitUntil.WaitSomeInterval(500);
        //    InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_NEW_GENEREAL);

        //    return this;
        //}
    }
}
