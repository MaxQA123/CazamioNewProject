using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [AllureStep("VerifyTitleBuildingViewPage")]
        public BuildingView VerifyTitleBuildingViewPage()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden);
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.CustomElementIsVisible(TitleBuildingViewPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleBuildingViewPage));

            return this;
        }

        [AllureStep("VerifyBuildingAddress")]
        public BuildingView VerifyBuildingAddress(string getAddressNewBuildingActual, string getAddressBuildingView)
        {
            WaitUntil.WaitSomeInterval(100);
            Assert.AreEqual(getAddressNewBuildingActual, getAddressBuildingView);

            return this;
        }
    }
}
