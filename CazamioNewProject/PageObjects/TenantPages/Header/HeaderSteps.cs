﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.Header
{
    public partial class Header
    {
        [AllureStep("SelectItemMyAccountViaButtonInFormAvatar")]
        public Header SelectItemMyAccountViaButtonInFormAvatar()
        {
            WaitUntil.CustomElementIsVisible(ButtonInFormAvatar);
            Button.Click(ButtonInFormAvatar);
            WaitUntil.CustomElementIsVisible(ButtonMyAccount);
            Button.Click(ButtonMyAccount);

            return this;
        }

        [AllureStep("LogOutViaHeader")]
        public Header LogOutViaHeader()
        {
            WaitUntil.CustomElementIsVisible(ButtonInFormAvatar);
            WaitUntil.CustomElementIsClickable(ButtonInFormAvatar);
            Button.Click(ButtonInFormAvatar);
            WaitUntil.CustomElementIsVisible(ButtonSignOut);
            Button.Click(ButtonSignOut);
            //Pages.MdlWndwAreYouSureLogOut
            //    .ClickButtonYesIamSure();

            return this;
        }
    }
}
