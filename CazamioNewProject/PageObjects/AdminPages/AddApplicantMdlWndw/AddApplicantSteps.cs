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
    }
}
