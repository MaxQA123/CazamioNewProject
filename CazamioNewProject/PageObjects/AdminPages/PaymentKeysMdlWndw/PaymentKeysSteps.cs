using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentKeysMdlWndw
{
    public partial class PaymentKeysMdlWndw
    {
        [AllureStep("SelectPaymentSystemAuthorizeNet")]
        public PaymentKeysMdlWndw SelectPaymentSystemAuthorizeNet()
        {
            WaitUntil.CustomElementIsVisible(ButtonSearchPaymentSystem);
            WaitUntil.CustomElementIsClickable(ButtonSearchPaymentSystem);
            Button.Click(ButtonSearchPaymentSystem);
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ItemAuthorizeNet);

            return this;
        }
    }
}
