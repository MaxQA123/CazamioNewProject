using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [AllureStep("VerifyTitleListOfApplications")]
        public ListOfApplications VerifyTitleListOfApplications()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfApplications));

            return this;
        }
    }
}
