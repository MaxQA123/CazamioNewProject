using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [AllureStep("PassFirstStep")]
        public CreateApplicationMdlWndw PassFirstStep()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonNext);

            return this;
        }

        [AllureStep("PassThirdStepFullData")]
        public CreateApplicationMdlWndw PassThirdStepFullData()
        {
            WaitUntil.CustomElementIsVisible(StringLeadEmail);
            InputGeneral.InputFunctionWithClear(FieldInputRequestedOfferPrice, application.RequestedOfferPrice.FirstPriceStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLeasePrice, apartment.UnitBasicData.LeasePriceFourNumbersStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputSecurityDeposit, apartment.UnitBasicData.SecurityDepositFourNumbersStatic);
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
            WaitUntil.WaitSomeInterval(5000);

            return this;
        }
    }
}
