using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.Header
{
    public partial class HeaderTenants
    {
        [AllureStep("SelectItemMyAccountViaButtonInFormAvatar")]
        public HeaderTenants SelectItemMyAccountViaButtonInFormAvatar()
        {
            WaitUntil.CustomElementIsVisible(ButtonInFormAvatar);
            Button.Click(ButtonInFormAvatar);
            WaitUntil.CustomElementIsVisible(ButtonMyAccount);
            Button.Click(ButtonMyAccount);

            return this;
        }

        [AllureStep("LogOut")]
        public HeaderTenants LogOut()
        {
            WaitUntil.CustomElementIsVisible(ButtonInFormAvatar);
            WaitUntil.CustomElementIsClickable(ButtonInFormAvatar);
            Button.Click(ButtonInFormAvatar);
            WaitUntil.CustomElementIsVisible(ButtonSignOut);
            Button.Click(ButtonSignOut);
            Pages.ConfirmLogOutMdlWndw
                .ConmfirmLogOut();

            return this;
        }
    }
}
