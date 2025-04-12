using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureDeleteTemplteMdlWndw
{
    public partial class AreYouSureDeleteTemplteMdlWndw
    {
        [AllureStep("VerifyTitleAreYouSure")]
        public AreYouSureDeleteTemplteMdlWndw VerifyTitleAreYouSure()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAreYouSure));

            return this;
        }

        [AllureStep("VerifySubTitleAreYouSureYouWantDeleteTemplate")]
        public AreYouSureDeleteTemplteMdlWndw VerifySubTitleAreYouSureYouWantDeleteTemplate()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(SubTitleAreYouSureYouWantDeleteTemplate));

            return this;
        }
    }
}
