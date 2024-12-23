﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw
{
    public partial class PaymentOptionsMdlWndw
    {
        [AllureStep("TitlePaymentOptionsMdlWndwOptns")]
        public PaymentOptionsMdlWndw VerifyTitlePaymentOptions()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePaymentOptions));

            return this;
        }

        [AllureStep("VerifySuccessSelectPmntMthds")]
        public PaymentOptionsMdlWndw VerifySuccessSelectPmntMthds()
        {
            WaitUntil.CustomElementIsVisible(MessageSuccessMdlWndwOptns);
            Assert.IsTrue(Successfully.IsVisible(MessageSuccessMdlWndwOptns));

            return this;
        }
    }
}
