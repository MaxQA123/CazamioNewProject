﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseChangeYourPasswordMdlWndw
{
    public partial class PleaseChangeYourPasswordMdlWndw
    {
        [AllureStep("VerifyTitle")]
        public PleaseChangeYourPasswordMdlWndw VerifyTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitlePleaseChangeYourPassword));

            return this;
        }
    }
}
