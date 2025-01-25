using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [AllureStep("VerifyTitleListOfCommissions")]
        public ListOfCommissions VerifyTitleListOfCommissions()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfCommissions));

            return this;
        }
    }
}
