using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [AllureStep("VerifyEditApplicationTitle")]
        public EditApplicationMdlWndw VerifyEditApplicationTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(EditApplicationTitle));

            return this;
        }

        [AllureStep("VerifySureYouWantToEditThisApplicationSubTitle")]
        public EditApplicationMdlWndw VerifySureYouWantToEditThisApplicationSubTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(SureYouWantToEditThisApplicationSubTitle));

            return this;
        }
    }
}
