using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        [AllureStep("EnterEmailPasswordAsTenantCreator")]
        public LogInTenant EnterEmailPasswordAsTenantCreator()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmailAddress);
            WaitUntil.CustomElementIsClickable(FieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, tenantCreator.EmailMySpace.EmailAlreadyCreated);
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
