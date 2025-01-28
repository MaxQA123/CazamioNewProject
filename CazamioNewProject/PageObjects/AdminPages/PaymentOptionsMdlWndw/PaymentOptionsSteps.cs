using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw
{
    public partial class PaymentOptionsMdlWndw
    {
        [AllureStep("SelectPaymentMethodCreditCard")]
        public PaymentOptionsMdlWndw SelectPaymentMethodCreditCard()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemCreditCard);
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
            Button.Click(ItemAch);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectPaymentMethodDeliverCheck")]
        public PaymentOptionsMdlWndw SelectPaymentMethodDeliverCheck()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemDeliverCheck);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectPaymentMethodZelle")]
        public PaymentOptionsMdlWndw SelectPaymentMethodZelle()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemZelle);
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

        [AllureStep("SelectPaymentMethodsCrdtCrdDlvrChck")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsCrdtCrdDlvrChck()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemCreditCard);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemDeliverCheck);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteApartment, paymentOptions.DeliverCheckNote.ForApartment);
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
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingScreening);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingScreening);
            WaitUntil.WaitSomeInterval(100);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_SCREENING));
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
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            WaitUntil.WaitSomeInterval(100);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_SCREENING));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectPaymentMethodsWithoutCrdtCrd")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsWithoutCrdtCrd()
        {
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingScreening);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingScreening);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_SCREENING));
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }

        [AllureStep("SelectAllPaymentMethodsForHoldBuilding")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethodsForHoldBuilding()
        {
            //Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING));
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
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingScreening);
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
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            WaitUntil.WaitSomeInterval(100);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING));
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSave);
            Pages.ToasterMessages
                .VerifyMessagePaymentMethodsSelected();

            return this;
        }
    }
}
