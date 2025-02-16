using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameMdlWndw
{
    public partial class PleaseTellUsYourNameMdlWndw
    {
        [AllureStep("QuicklyPass")]
        public PleaseTellUsYourNameMdlWndw QuicklyPass()
        {
            VerifyTitle();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.CustomElementIsInVisible(FieldInputLastName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);

            return this;
        }
    }
}
