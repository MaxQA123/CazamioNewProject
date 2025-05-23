﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [AllureStep("EditApplicationNineNineNineEightSaintJohnsonPlace")]
        public (EditApplicationMdlWndw Window, 
            string MainApplicantPartEmail, string OccupantPartEmail, string GuarantorPartEmail,
            string MainApplicantFullEmailFromEditApp, string OccupantFullEmailFromEditApp, string GuarantorFullEmailFromEditApp)
        EditApplicationNineNineNineEightSaintJohnsonPlace()
        {
            WaitUntil.CustomElementIsInVisible(LoaderHidden);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ApplicationDetail
                .ClickEditApplicationBtn();
            VerifyEditApplicationTitle();
            InputGeneral.InputFunctionWithClear(RequestedOfferPriceFieldInput, application.RequestedOfferPrice.SixthPriceStatic);
            InputGeneral.InputFunctionWithClear(LeasePriceFieldInput, application.LeasePrice.SixthPriceStatic);
            InputGeneral.InputFunctionWithClear(SecurityDepositFieldInput, application.SecurityDeposit.SixthPriceStatic);
            Button.Click(RemoveConcessionBtn);
            Button.Click(MoveInDateFieldButton);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            InputGeneral.InputFunctionWithClear(RentalTermsFieldInput, application.RentalTerms.TwelveMonths);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(MonthlyRentsPrePaymentFieldInput, application.MonthlyRentsPrePayment.TwoMonths);
            Button.Click(ReferralAgentCheckTheBox);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(ReferralDetailsFieldInput, application.ReferralDetails.LongTextNineNineNineEightSaintJohnsonPlace);
            Button.Click(PlusAddRequestedWorkBtn);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(RequestedWorkFieldInput, application.RequestedWork.LongTextNineNineNineEightSaintJohnsonPlace);
            Button.Click(AssignedAgentBtn);
            Button.Click(SetAgentAgentusBrokerusItem());
            InputGeneral.InputFunctionWithClear(EmailAddressMainApplicantFieldInput, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);
            string mainApplicantPartEmail = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressMainApplicant();
            string mainApplicantFullEmailFromEditApp = Pages.EditApplicationMdlWndw.GetFullEmailAddressMainApplicant();
            Button.Click(PlusAddApplicantBtn);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantOccupantMySpace.Emails.RandomEmail);
            string occupantPartEmail = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressOccupant();
            string occupantFullEmailFromEditApp = Pages.EditApplicationMdlWndw.GetFullEmailAddressOccupantFromFirstFieldInput();
            Button.Click(PlusAddApplicantBtn);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddress, tenantGuarantorMySpace.Emails.RandomEmail);
            string guarantorPartEmail = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressGuarantor();
            string guarantorFullEmailFromEditApp = Pages.EditApplicationMdlWndw.GetFullEmailAddressGuarantorFromSecondFieldInput();
            Button.Click(CheckBoxThisIsAGuarantorSecondEmailAddressField);
            Button.Click(EditBtn);
            VerifyEditApplicationTitle();
            VerifySureYouWantToEditThisApplicationSubTitle();
            Button.Click(EditBtnForConfirmation);
            Pages.ToasterMessagesLandlord
                .VerifyMessageApplicationEditSuccessful();

            return (this, 
                mainApplicantPartEmail, occupantPartEmail, guarantorPartEmail,
                mainApplicantFullEmailFromEditApp, occupantFullEmailFromEditApp, guarantorFullEmailFromEditApp);
        }

        [AllureStep("EditFirstApplicationOneTwoFiveSixSevenDeanStreet")]
        public (EditApplicationMdlWndw Window,
            string MainApplicantNewlyCreatedPartEmailOld, string OccupantPartEmailOld, string GuarantorPartEmailOld)
        EditFirstApplicationOneTwoFiveSixSevenDeanStreet()
        {
            WaitUntil.CustomElementIsInVisible(LoaderHidden);
            WaitUntil.WaitSomeInterval(2000);
            Pages.ApplicationDetail
                .ClickEditApplicationBtn();
            VerifyEditApplicationTitle();
            Button.Click(MoveInDateFieldButton);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            InputGeneral.InputFunctionWithClear(RentalTermsFieldInput, application.RentalTerms.TwentyFourMonths);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(MonthlyRentsPrePaymentFieldInput, application.MonthlyRentsPrePayment.OneMonth);
            Button.Click(ReferralAgentCheckTheBox);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(ReferralDetailsFieldInput, application.ReferralDetails.ShortTextDeanStreet);
            Button.Click(PlusAddRequestedWorkBtn);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(RequestedWorkFieldInput, application.RequestedWork.ShortTextDeanStreet);
            Button.Click(AssignedAgentBtn);
            Button.Click(SetAgentAgentusBrokerusItem());

            string mainApplicantNewlyCreatedPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressMainApplicant();
            InputGeneral.InputFunctionWithClear(EmailAddressMainApplicantFieldInput, tenantCreatorMySpace.CreatedWithoutCreditReport.Email);
            string occupantPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressOccupant();
            string guarantorPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressGuarantor();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CrossBtnFirstForDeleting);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CrossBtnFirstForDeleting);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(EditBtn);
            VerifyEditApplicationTitle();
            VerifySureYouWantToEditThisApplicationSubTitle();
            Button.Click(EditBtnForConfirmation);
            Pages.ToasterMessagesLandlord
                .VerifyMessageApplicationEditSuccessful();

            return (this,
                mainApplicantNewlyCreatedPartEmailOld, occupantPartEmailOld, guarantorPartEmailOld);
        }

        [AllureStep("EditFirstApplicationOneOneOneAEastStPerestrian")]
        public (EditApplicationMdlWndw Window,
            string MainApplicantNewlyCreatedPartEmailOld, string OccupantPartEmailOld, string GuarantorPartEmailOld)
        EditFirstApplicationOneOneOneAEastStPerestrian()
        {
            WaitUntil.CustomElementIsInVisible(LoaderHidden);
            WaitUntil.WaitSomeInterval(2000);
            Pages.ApplicationDetail
                .ClickEditApplicationBtn();
            VerifyEditApplicationTitle();
            Button.Click(MoveInDateFieldButton);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            InputGeneral.InputFunctionWithClear(RentalTermsFieldInput, application.RentalTerms.OneYear);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            InputGeneral.InputFunctionWithClear(MonthlyRentsPrePaymentFieldInput, application.MonthlyRentsPrePayment.ThreeMonths);
            Button.Click(ReferralAgentCheckTheBox);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(ReferralDetailsFieldInput, application.ReferralDetails.ShortTextDeanStreet);
            Button.Click(PlusAddRequestedWorkBtn);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(RequestedWorkFieldInput, application.RequestedWork.ShortTextDeanStreet);
            Button.Click(AssignedAgentBtn);
            Button.Click(SetAgentAgentusBrokerusItem());

            string mainApplicantNewlyCreatedPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressMainApplicant();
            InputGeneral.InputFunctionWithClear(EmailAddressMainApplicantFieldInput, tenantCreatorMySpace.CreatedWithoutCreditReport.Email);
            string occupantPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressOccupant();
            string guarantorPartEmailOld = Pages.EditApplicationMdlWndw.GetRandomEmailBeforeDogFromEmailAddressGuarantor();
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CrossBtnFirstForDeleting);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(CrossBtnFirstForDeleting);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(EditBtn);
            VerifyEditApplicationTitle();
            VerifySureYouWantToEditThisApplicationSubTitle();
            Button.Click(EditBtnForConfirmation);
            Pages.ToasterMessagesLandlord
                .VerifyMessageApplicationEditSuccessful();

            return (this,
                mainApplicantNewlyCreatedPartEmailOld, occupantPartEmailOld, guarantorPartEmailOld);
        }
    }
}
