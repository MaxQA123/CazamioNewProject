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
            Button.Click(ItemCreditCard);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodAch")]
        public PaymentOptionsMdlWndw SelectPaymentMethodAch()
        {
            Button.Click(ItemAch);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethoddeliverCheck")]
        public PaymentOptionsMdlWndw SelectPaymentMethoddeliverCheck()
        {
            Button.Click(ItemDeliverCheck);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodZelle")]
        public PaymentOptionsMdlWndw SelectPaymentMethodZelle()
        {
            Button.Click(ItemZelle);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectPaymentMethodVenmo")]
        public PaymentOptionsMdlWndw SelectPaymentMethodVenmo()
        {
            Button.Click(ItemVenmo);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();
            WaitUntil.SuccessCustomElementIsVisible(MessageSuccessPaymentMethodsSelectedMdlWndwOptns);

            return this;
        }

        [AllureStep("SelectAllPaymentMethods")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethods()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingScreening);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingScreening);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_SCREENING));
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();

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
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectAllPaymentMethodsForHoldBuilding")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethodsForHoldBuilding()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING));
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectPaymentMethodsCrdtCrdAchZll")]
        public PaymentOptionsMdlWndw SelectPaymentMethodsCrdtCrdAchZll()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectCrdtCrdDlvrChckZlVnmForHoldBuilding")]
        public PaymentOptionsMdlWndw SelectCrdtCrdDlvrChckZlVnmForHoldBuilding()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteBuilding, paymentOptions.DeliverCheckNote.ForBuildingHold);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneBuilding, paymentOptions.Zelle.ForBuildingHold);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_BUILDING));
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();

            return this;
        }

        [AllureStep("SelectAllPaymentMethodsForHoldApartment")]
        public PaymentOptionsMdlWndw SelectAllPaymentMethodsForHoldApartment()
        {
            Button.Click(ItemCreditCard);
            Button.Click(ItemAch);
            Button.Click(ItemDeliverCheck);
            Button.Click(ItemZelle);
            Button.Click(ItemVenmo);
            InputGeneral.InputFunctionWithClear(FieldInputDeliverCheckNoteApartment, paymentOptions.DeliverCheckNote.ForApartment);
            InputGeneral.InputFunctionWithClear(FieldInputZelleAddressOrPhoneApartment, paymentOptions.Zelle.ForApartment);
            ButtonForVenmoQrCodeImage.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.IMAGE_FOR_PAYMENT_VENMO_HOLD_APARTMENT));
            Button.Click(ButtonSave);
            VerifySuccessSelectPmntMthds();

            return this;
        }
    }
}
