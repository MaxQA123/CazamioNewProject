using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [AllureStep("VerifyTitleBuildingViewPage")]
        public BuildingView VerifyTitleBuildingViewPage()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            WaitUntil.CustomElementIsVisible(TitleBuildingViewPage);
            Assert.IsTrue(Successfully.IsVisible(TitleBuildingViewPage));

            return this;
        }

        [AllureStep("VerifyBuildingAddress")]
        public BuildingView VerifyBuildingAddress(string getAddressNewBuildingActual, string building)
        {
            WaitUntil.WaitSomeInterval(100);
            Assert.AreEqual(getAddressNewBuildingActual, building);

            return this;
        }
    }
}
