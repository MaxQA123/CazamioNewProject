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
        [AllureStep("VerifyTitlePaymentSettingsPage")]
        public PaymentSettings VerifyTitlePaymentSettingsPage()
        {
            Assert.IsTrue(Successfully.IsVisible(TitlePaymentSettingsPage));

            return this;
        }
    }
}
