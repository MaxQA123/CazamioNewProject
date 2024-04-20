using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureLogOutMdlWndw
{
    public partial class AreYouSureLogOutLandlordMdlWndw
    {
        [AllureStep("ClickButtonYesIAmSure")]
        public AreYouSureLogOutLandlordMdlWndw ClickButtonYesIAmSure()
        {
            WaitUntil.CustomElementIsVisible(ButtonYesIAmSureOnMdlwndw);
            Button.Click(ButtonYesIAmSureOnMdlwndw);

            return this;
        }

        [AllureStep("ClickButtonCancel")]
        public AreYouSureLogOutLandlordMdlWndw ClickButtonCancel()
        {
            WaitUntil.CustomElementIsVisible(ButtonCancelOnMdlwndw);
            Button.Click(ButtonCancelOnMdlwndw);

            return this;
        }

        [AllureStep("MakeLogOut")]
        public AreYouSureLogOutLandlordMdlWndw MakeLogOut()
        {
            WaitUntil.WaitSomeInterval(1000);
            Pages.SidebarLandlord
                .ClickButtonLogOutSidebar();
            WaitUntil.WaitSomeInterval(1000);
            Pages.AreYouSureLogOutLandlordMdlWndw
                .ClickButtonYesIAmSure();

            return this;
        }
    }
}
