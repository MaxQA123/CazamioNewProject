using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [AllureStep("EditApplicationNineNineNineEightSaintJohnsonPlace")]
        public EditApplicationMdlWndw EditApplicationNineNineNineEightSaintJohnsonPlace()
        {
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
            InputGeneral.InputFunctionWithClear(MonthlyRentsPrePaymentFieldInput, application.MonthlyRentsPrePayment.TwoMonth);
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
            Button.Click(PlusAddApplicantBtn);
            //Button.Click(ButtonCreate);

            return this;
        }
    }
}
