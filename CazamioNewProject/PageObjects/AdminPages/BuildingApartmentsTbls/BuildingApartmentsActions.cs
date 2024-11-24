using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

        [AllureStep("ClickFirstRow")]
        public BuildingApartments ClickFirstRow()
        {
            WaitUntil.WaitSomeInterval(5000);
            WaitUntil.CustomElementIsVisible(FirstRow);
            WaitUntil.CustomElementIsClickable(FirstRow);
            Button.Click(FirstRow);

            return this;
        }

        [AllureStep("ClickFirstRow")]
        public BuildingApartments ClickDemo()
        {
            WaitUntil.CustomElementIsVisible(DemoOne);
            Button.Click(DemoOne);

            return this;
        }
    }
}
