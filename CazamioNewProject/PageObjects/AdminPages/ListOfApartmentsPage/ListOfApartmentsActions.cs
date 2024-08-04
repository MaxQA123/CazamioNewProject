using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [AllureStep("ClickButtonAdd")]
        public ListOfApartments ClickButtonAdd()
        {
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            WaitUntil.CustomElementIsVisible(ButtonAdd);
            WaitUntil.CustomElementIsClickable(ButtonAdd);
            Button.Click(ButtonAdd);

            return this;
        }
    }
}
