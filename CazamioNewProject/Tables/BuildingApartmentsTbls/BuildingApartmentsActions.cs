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
        [AllureStep("ClickFirstRow")]
        public BuildingApartments ClickFirstRow()
        {
            WaitUntil.CustomElementIsVisible(FirstRow);
            Button.Click(FirstRow);

            return this;
        }
    }
}
