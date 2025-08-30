using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureLogOutMdlWndw
{
    public partial class AreYouSureLogOutLandlordMdlWndw
    {
        [AllureStep("Click Button Yes I Am Sure")]
        public AreYouSureLogOutLandlordMdlWndw ClickButtonYesIAmSure()
        {
            WaitUntil.CustomElementIsVisible(ButtonYesIAmSureOnMdlwndw);
            Button.Click(ButtonYesIAmSureOnMdlwndw);

            return this;
        }

        [AllureStep("Click Button Cancel")]
        public AreYouSureLogOutLandlordMdlWndw ClickButtonCancel()
        {
            WaitUntil.CustomElementIsVisible(ButtonCancelOnMdlwndw);
            Button.Click(ButtonCancelOnMdlwndw);

            return this;
        }

        [AllureStep("Make Log Out")]
        public AreYouSureLogOutLandlordMdlWndw MakeLogOut()
        {
            Pages.SidebarLandlord
                .ClickButtonLogOutSidebar();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .VerifyTitleAreYouSureMdlwndw()
                .ClickButtonYesIAmSure();
            Pages.LogInLandlord.VerifyTitleLogInPg();

            return this;
        }
    }
}
