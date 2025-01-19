﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [AllureStep("VerifyTitleCreateApplication")]
        public CreateApplicationMdlWndw VerifyTitleCreateApplication()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateApplication));

            return this;
        }

        [AllureStep("VerifyTitleApplicationSuccessfullyCreated")]
        public CreateApplicationMdlWndw VerifyTitleApplicationSuccessfullyCreated()
        {
            WaitUntil.CustomElementIsVisible(TitleApplicationSuccessfullyCreated);
            Assert.IsTrue(Successfully.IsVisible(TitleApplicationSuccessfullyCreated));

            return this;
        }

        [AllureStep("VerifyTextLinkAlreadyCopied")]
        public CreateApplicationMdlWndw VerifyTextLinkAlreadyCopied()
        {
            WaitUntil.CustomElementIsVisible(TextLinkAlreadyCopied);
            Assert.IsTrue(Successfully.IsVisible(TextLinkAlreadyCopied));

            return this;
        }
    }
}
