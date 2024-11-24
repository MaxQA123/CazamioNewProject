using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Tables.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        BuildingApartments buildingApartments = BuildingApartments.Generate();

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
