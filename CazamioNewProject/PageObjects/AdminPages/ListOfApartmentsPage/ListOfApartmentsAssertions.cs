using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [AllureStep("Verify Title List of apartments page")]
        public ListOfApartments VerifyTitleListOfApartments()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            WaitUntil.CustomElementIsVisible(TitleListOfApartmentsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfApartmentsPage));

            return this;
        }
    }
}
