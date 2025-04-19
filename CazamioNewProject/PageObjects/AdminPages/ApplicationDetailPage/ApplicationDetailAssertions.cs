using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [AllureStep("VerifyTitleApplicationDetailPage")]
        public ApplicationDetail VerifyTitleApplicationDetailPage()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleApplicationDetailPage));

            return this;
        }
    }
}
