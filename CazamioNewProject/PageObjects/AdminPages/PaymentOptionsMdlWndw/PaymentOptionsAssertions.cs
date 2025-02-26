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
            Assert.IsTrue(TitlesCheck.IsVisible(TitlePaymentOptions));

            return this;
        }
    }
}
