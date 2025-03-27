using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
        //TenantGuarantor tenantGuarantor = new TenantGuarantor().Generate();
        TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();

        [AllureStep("ClickIconShow")]
        public LogInTenant ClickIconShow()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(IconShow);

            return this;
        }

        [AllureStep("SetCheckBoxRememberMe")]
        public LogInTenant SetCheckBoxRememberMe()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CheckBoxRememberMe);

            return this;
        }

        [AllureStep("ClickButtonLogIn")]
        public LogInTenant ClickButtonLogIn()
        {
            WaitUntil.CustomElementIsClickable(ButtonLogIn);
            Button.Click(ButtonLogIn);

            return this;
        }

        [AllureStep("CopiedForEnterEmail")]
        public LogInTenant CopiedForEnterEmail(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddress, _email);

            return this;
        }

        [AllureStep("EnterPassword")]
        public LogInTenant EnterPassword()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("ClickButtonForgotPassword")]
        public LogInTenant ClickButtonForgotPassword()
        {
            WaitUntil.CustomElementIsVisible(ButtonForgotPassword);
            WaitUntil.CustomElementIsClickable(ButtonForgotPassword);
            Button.Click(ButtonForgotPassword);

            return this;
        }
    }
}
