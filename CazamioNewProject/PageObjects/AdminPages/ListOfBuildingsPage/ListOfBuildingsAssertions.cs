using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        [AllureStep("Verify Title List of buildings page")]
        public ListOfBuildings VerifyTitleListOfBuildings()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfBuildingsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfBuildingsPage));

            return this;
        }
    }
}
