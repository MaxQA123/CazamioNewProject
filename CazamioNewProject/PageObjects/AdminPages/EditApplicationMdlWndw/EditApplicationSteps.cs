using CazamioNewProject.GuiHelpers;
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
    }
}
