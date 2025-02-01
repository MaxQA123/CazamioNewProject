using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw
{
    public partial class PaymentOptionsMdlWndw
    {

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

        [AllureStep("SelectPaymentMethodsCrdtCrdAch")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsCrdtCrdAch()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemCreditCard);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemAch);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectScreeningFeeAllPaymentMethods")]
        public PaymentOptionsMdlWndw SelectScreeningFeeAllPaymentMethods()
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

        [AllureStep("SelectAllPaymentMethodsWithoutAchHoldDepositApartment")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethodsWithoutAchHoldDepositApartment()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemCreditCard);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemDeliverCheck);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemZelle);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemVenmo);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteApartment, paymentOptions.DeliverCheckNote.ForApartment);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneApartment, paymentOptions.Zelle.ForApartment);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_APARTMENT));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectHoldDepositAllPaymentMethods")]
        public PaymentOptionsMdlWndw SelectHoldDepositAllPaymentMethods()
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

        [AllureStep("SelectCrdtCrdDlvrChckZlVnmForHoldBuilding")]
        public PaymentOptionsMdlWndw SelectCrdtCrdDlvrChckZlVnmForHoldBuilding()
        {
            WaitUntil.WaitSomeInterval(100);
            //Button.Click(ItemCreditCard);
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

        [AllureStep("SelectPaymentMethodsCrdtCrdAchZll")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsCrdtCrdAchZll()
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

        [AllureStep("SelectCrdtCrdAchForHoldBuilding")]
        public PaymentOptionsMdlWndw SelectCrdtCrdAchForHoldBuilding()
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
