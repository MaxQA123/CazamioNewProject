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
            WaitUntil.CustomElementIsVisible(FieldInputMainApplicantEmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputMainApplicantEmailAddress, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonNext);

            return this;
        }
    }
}
