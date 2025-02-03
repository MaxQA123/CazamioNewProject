using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw
{
    public partial class PaymentOptionsMdlWndw
    {
        [AllureStep("SelectAllPaymentMethods")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethods()
        {
            WaitUntil.WaitSomeInterval(100);
            //Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemDeliverCheck);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemZelle);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemVenmo);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectPaymentMethodsDlvrChckZllVnm")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsDlvrChckZllVnm()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemDeliverCheck);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemZelle);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemVenmo);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        //[AllureStep("SelectAllPaymentMethodsWithoutAch")]
        //public PaymentOptionsMdlWndw SelectAllPaymentMethodsWithoutAch()
        //{
        //    WaitUntil.WaitSomeInterval(100);
        //    Button.Click(ItemDeliverCheck);
        //    WaitUntil.WaitSomeInterval(100);
        //    Button.Click(ItemZelle);
        //    WaitUntil.WaitSomeInterval(100);
        //    Button.Click(ItemVenmo);
        //    WaitUntil.WaitSomeInterval(100);
        //    Button.Click(ButtonSave);
        //    Pages.ToasterMessages
        //        .VerifyMessagePaymentMethodsSelected();

        //    return this;
        //}

        [AllureStep("SelectPaymentMethodsAchZll")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsAchZll()
        {
            WaitUntil.WaitSomeInterval(100);
            //Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemZelle);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectPaymentMethodAch")]
        public PaymentOptionsMdlWndw SelectPaymentMethodAch()
        {
            WaitUntil.WaitSomeInterval(100);
            //Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }
    }
}
