using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        #region First step

        [AllureStep("PassFirstStepRandomEmail")]
        public CreateApplicationMdlWndw PassFirstStepRandomEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);
            WaitUntil.WaitSomeInterval(3000);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("PassFirstStepCreatorWithCreditReportMySpace")]
        public CreateApplicationMdlWndw PassFirstStepCreatorWithCreditReportMySpace()
        {
            Pages.ListOfApplications
                .ClickButtonPlusApplication();
            Pages.CreateApplicationMdlWndw
                .VerifyTitleCreateApplication()
                .EnterEmailCreatedTenantCreatorWithCreditReportMySpace()
                .ClickButtonNext();

            return this;
        }

        [AllureStep("PassFirstStepCreatorWithoutCreditReportMySpace")]
        public CreateApplicationMdlWndw PassFirstStepCreatorWithoutCreditReportMySpace()
        {
            Pages.ListOfApplications
                .ClickButtonPlusApplication();
            Pages.CreateApplicationMdlWndw
                .VerifyTitleCreateApplication()
                .EnterEmailCreatedTenantCreatorWithoutCreditReportMySpace()
                .ClickButtonNext();

            return this;
        }

        #endregion

        #region Second step

        [AllureStep("PassSecondStepOneOneOneAEastStPedestrianCrossingAddress")]
        public CreateApplicationMdlWndw PassSecondStepOneOneOneAEastStPedestrianCrossingAddress()
        {
            Pages.CreateApplicationMdlWndw
                .EnterOneOneOneAEastStPedestrianCrossingAddress();
            Button.Click(SetOneOneOneAEastStPedestrianCrossingAddressAddress());
            WaitUntil.CustomElementIsVisible(ButtonNext);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("PassSecondStepGatesAvenueAddress")]
        public CreateApplicationMdlWndw PassSecondStepGatesAvenueAddress()
        {
            Pages.CreateApplicationMdlWndw
                .EnterOneTwoEightSixSevenGatesAvenueAddress();
            Button.Click(SetOneTwoEightSixSevenGatesAvenueAddress());
            WaitUntil.CustomElementIsVisible(ButtonNext);
            Button.Click(ButtonNext);

            return this;
        }

        #endregion

        #region Third step

        [AllureStep("PassThirdStepFullData")]
        public CreateApplicationMdlWndw PassThirdStepFullData()
        {
            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.FirstPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFirstStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFirstStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.OneMonth);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.OneMonth);
            Button.Click(FieldButtonMoveInDate);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            WaitUntil.WaitSomeInterval(5000);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTerms, application.RentalTerms.TwelveMonths);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickTab();
            Button.Click(CheckTheBoxReferralAgent);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputReferralDetails, application.ReferralDetails.LongTextWashingtonSquare);
            Button.Click(ButtonPlusAddRequestedWork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedWork, application.RequestedWork.LongTextWashingtonSquare);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("PassThirdStepAddressNineAAlbermaleRd")]
        public CreateApplicationMdlWndw PassThirdStepAddressNineAAlbermaleRd()
        {
            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            Button.Click(ButtonPlusAddConcession);
            WaitUntil.CustomElementIsVisible(FieldInputMonthsFree);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.TwoMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoShort);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.OneMonth);
            Button.Click(FieldButtonMoveInDate);
            //Pages.DatePicker
            //    .ClickButtonDropDownYearMonth()
            //    .SelectCurrentYear();
            //Pages.DatePicker
            //    .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            Button.Click(ButtonCreate);
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }

        [AllureStep("PassThirdStepOneOneOneAEastStPedestrianCrossingAddress")]
        public CreateApplicationMdlWndw PassThirdStepOneOneOneAEastStPedestrianCrossingAddress()
        {

            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.SecondPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, application.LeasePrice.FirstPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, application.SecurityDeposit.FirstPriceStatic);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.OneMonth);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.TwoMonths);
            Button.Click(FieldButtonMoveInDate);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            WaitUntil.WaitSomeInterval(5000);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTerms, application.RentalTerms.TwoYears);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickTab();
            Button.Click(CheckTheBoxReferralAgent);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputReferralDetails, application.ReferralDetails.ShortTextEastStreet);
            Button.Click(ButtonPlusAddRequestedWork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedWork, application.RequestedWork.ShortTextEastStreet);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("PassThirdStepGatesAvenueAddressFrstFlow")]
        public CreateApplicationMdlWndw PassThirdStepGatesAvenueAddressFrstFlow()
        {

            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.ThirdPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, application.LeasePrice.ThirdPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, application.SecurityDeposit.ThirdPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPlusAddConcession);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.ThreeMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, application.AdditionalInfo.LongTextGatesAvenue);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.OneMonth);
            Button.Click(FieldButtonMoveInDate);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            WaitUntil.WaitSomeInterval(5000);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTerms, application.RentalTerms.NineMonths);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickTab();
            Button.Click(CheckTheBoxReferralAgent);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputReferralDetails, application.ReferralDetails.LongTextGatesAvenue);
            Button.Click(ButtonPlusAddRequestedWork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedWork, application.RequestedWork.LongTextGatesAvenue);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("PassThirdStepGatesAvenueAddressScndFlow")]
        public CreateApplicationMdlWndw PassThirdStepGatesAvenueAddressScndFlow()
        {

            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.FourthPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, application.LeasePrice.FourthPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, application.SecurityDeposit.FourthPriceStatic);
            Button.Click(ButtonPlusAddConcession);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.OneMonth);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, application.AdditionalInfo.ShortTextGatesAvenue);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.TwoMonths);
            Button.Click(FieldButtonMoveInDate);
            Pages.DatePicker
                .ClickButtonDropDownYearMonth()
                .SelectCurrentYear();
            Pages.DatePicker
                .SelectNextMonth();
            Pages.DatePicker
                .SelectFisrtDayInNextMonth();
            WaitUntil.WaitSomeInterval(5000);
            InputGeneral.InputFunctionWithClear(FieldInputRentalTerms, application.RentalTerms.TwentyFourMonths);
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            WaitUntil.WaitSomeInterval(100);
            KeyBoardActions.ClickTab();
            Button.Click(CheckTheBoxReferralAgent);
            KeyBoardActions.ClickTab();
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputReferralDetails, application.ReferralDetails.LongTextGatesAvenue);
            Button.Click(ButtonPlusAddRequestedWork);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedWork, application.RequestedWork.LongTextGatesAvenue);
            Button.Click(ButtonCreate);

            return this;
        }

        #endregion
    }
}
