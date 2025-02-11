using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.AddApplicantMdlWndw
{
    public partial class AddApplicantMdlWndw
    {
        [AllureStep("VerifyTitleAddApplicantMdlWndw")]
        public AddApplicantMdlWndw VerifyTitleAddApplicantMdlWndw()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAddApplicantMdlWndw));

            return this;
        }
    }
}
