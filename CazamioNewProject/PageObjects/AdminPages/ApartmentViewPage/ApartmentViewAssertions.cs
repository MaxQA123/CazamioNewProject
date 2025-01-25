using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [AllureStep("VerifyTitleAddApartmentsPage")]
        public ApartmentView VerifyTitleApartmentViewPage()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleApartmentViewPage));
            KeyBoardActions.ScrollToUp();

            return this;
        }

        [AllureStep("VerifyCopiedTheLinkToApplication")]
        public ApartmentView VerifyCopiedTheLinkToApplication()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageCopiedTheLinkToApplication));

            return this;
        }
    }
}
