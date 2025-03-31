using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.AddApplicantMdlWndw
{
    public partial class AddApplicantMdlWndw
    {
        [AllureStep("AddOneNewlyCreatedOccupantGuarantor")]
        public AddApplicantMdlWndw AddOneNewlyCreatedOccupantGuarantor()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantOccupantMySpace.Emails.RandomEmail);
            Button.Click(BtnPlusAddAnotherApplicant);
            WaitUntil.CustomElementIsClickable(SecondFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddress, tenantGuarantorMySpace.Emails.RandomEmail);
            WaitUntil.CustomElementIsClickable(CheckBoxThisIsAGuarantorSecondEmailAddressField);
            Button.Click(CheckBoxThisIsAGuarantorSecondEmailAddressField);
           
            return this;
        }

        [AllureStep("AddOnCreatedOccupantWithoutCrdtRprtGuarantorWithCrdtRprt")]
        public AddApplicantMdlWndw AddOnCreatedOccupantWithoutCrdtRprtGuarantorWithCrdtRprt()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantOccupantMySpace.CreatedWitoutCreditReport.Email);
            Button.Click(BtnPlusAddAnotherApplicant);
            WaitUntil.CustomElementIsClickable(SecondFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(SecondFieldInputEmailAddress, tenantGuarantorMySpace.CreatedWithCreditReport.Email);
            WaitUntil.CustomElementIsClickable(CheckBoxThisIsAGuarantorSecondEmailAddressField);
            Button.Click(CheckBoxThisIsAGuarantorSecondEmailAddressField);

            return this;
        }

        [AllureStep("AddOneAlreadyExistOccupantWithCreditReport")]
        public AddApplicantMdlWndw AddOneAlreadyExistOccupantWithCreditReport()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantOccupantMySpace.CreatedWithCreditReport.Email);

            return this;
        }

        [AllureStep("AddOneAlreadyExistOccupantWithoutCreditReport")]
        public AddApplicantMdlWndw AddOneAlreadyExistOccupantWithoutCreditReport()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantOccupantMySpace.CreatedWitoutCreditReport.Email);

            return this;
        }

        [AllureStep("AddOneAlreadyExistGuarantorWithCreditReport")]
        public AddApplicantMdlWndw AddOneAlreadyExistGuarantorWithCreditReport()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantGuarantorMySpace.CreatedWithCreditReport.Email);

            return this;
        }

        [AllureStep("AddOnlyAlreadyExistGuarantorWithoutCreditReport")]
        public AddApplicantMdlWndw AddOnlyAlreadyExistGuarantorWithoutCreditReport()
        {
            VerifyTitleAddApplicantMdlWndw();
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            InputGeneral.InputFunctionWithClear(FirstFieldInputEmailAddress, tenantGuarantorMySpace.CreatedWitoutCreditReport.Email);
            WaitUntil.CustomElementIsClickable(CheckBoxThisIsAGuarantorFirstEmailAddressField);
            Button.Click(CheckBoxThisIsAGuarantorFirstEmailAddressField);

            return this;
        }
    }
}
