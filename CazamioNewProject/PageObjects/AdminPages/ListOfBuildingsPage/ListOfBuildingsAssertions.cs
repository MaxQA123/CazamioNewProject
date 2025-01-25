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
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfBuildingsPage));

            return this;
        }
    }
}
