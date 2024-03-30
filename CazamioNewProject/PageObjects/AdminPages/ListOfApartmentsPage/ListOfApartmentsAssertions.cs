using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [AllureStep("VerifyTitleListOfApartments")]
        public ListOfApartments VerifyTitleListOfApartments()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfApartmentsPage);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfApartmentsPage));

            return this;
        }
    }
}
