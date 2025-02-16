using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseChangeYourPasswordMdlWndw
{
    public partial class PleaseChangeYourPasswordMdlWndw
    {
        [AllureStep("QuicklyPass")]
        public PleaseChangeYourPasswordMdlWndw QuicklyPass()
        {
            VerifyTitle();
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);

            return this;
        }
    }
}
