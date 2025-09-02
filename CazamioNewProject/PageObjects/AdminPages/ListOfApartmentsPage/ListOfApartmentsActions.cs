using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [AllureStep("Wait appearing First row in List of Apartments")]
        public ListOfApartments WaitFirstRowInListOfApartments()
        {
            WaitUntil.CustomElementIsVisible(FirstRowInListOfApartments);

            return this;
        }

        [AllureStep("ClickButtonAdd")]
        public ListOfApartments ClickButtonAdd()
        {
            WaitUntil.WaitSomeInterval(10000);
            Button.Click(ButtonAdd);

            return this;
        }
    }
}
