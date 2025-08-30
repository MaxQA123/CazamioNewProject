using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentSettingsPage
{
    public partial class PaymentSettings
    {
        [AllureStep("Verify Title Payment Settings Page")]
        public PaymentSettings VerifyTitlePaymentSettingsPage()
        {
            WaitUntil.CustomElementIsVisible(TitlePaymentSettingsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitlePaymentSettingsPage));

            return this;
        }
    }
}
