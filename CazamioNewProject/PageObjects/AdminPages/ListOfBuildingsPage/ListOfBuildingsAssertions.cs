using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        [AllureStep("VerifyTitleListOfBuildings")]
        public ListOfBuildings VerifyTitleListOfBuildings()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfBuildingsPage);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfBuildingsPage));

            return this;
        }
    }
}
