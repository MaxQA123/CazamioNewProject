using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

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
            //WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            //InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, tenantCreatorMySpace.Emails.RandomMainApplicantEmail);

            return this;
        }
    }
}
