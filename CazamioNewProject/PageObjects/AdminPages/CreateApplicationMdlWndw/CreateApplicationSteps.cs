using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [AllureStep("PassFirstStepRandomEmail")]
        public CreateApplicationMdlWndw PassFirstStepRandomEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);
            WaitUntil.WaitSomeInterval(2000);
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

        [AllureStep("PassSecondStepOneOneOneAEastStPedestrianCrossingAddress")]
        public CreateApplicationMdlWndw PassSecondStepOneOneOneAEastStPedestrianCrossingAddress()
        {
            Pages.CreateApplicationMdlWndw
                .EnterOneOneOneAEastStPedestrianCrossingAddress();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("PassSecondStepOneWashingtonSquareAddress")]
        public CreateApplicationMdlWndw PassSecondStepOneWashingtonSquareAddress()
        {
            Pages.CreateApplicationMdlWndw
                .EnterOneWashingtonSquareAddress();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            Button.Click(ButtonNext);

            return this;
        }

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
            InputGeneral.InputFunctionWithClear(FieldInputRentalTerms, application.RentalTerms.TwelveMonth);
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
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceSecondStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositSecondStatic);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.OneMonth);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.TwoMonth);
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

        [AllureStep("PassThirdStepOneWashingtonSquareAddress")]
        public CreateApplicationMdlWndw PassThirdStepOneWashingtonSquareAddress()
        {

            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.SecondPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceSecondStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositSecondStatic);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputMonthsFree, application.MonthsFree.OneMonth);
            //WaitUntil.WaitSomeInterval(100);
            //InputGeneral.InputFunctionWithClear(FieldInputAdditionalInfo, apartment.SettingsConcessions.AdditionalInfoLong);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMonthlyRentsPrePayment, application.MonthlyRentsPrePayment.TwoMonth);
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
    }
}
