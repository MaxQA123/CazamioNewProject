using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [AllureStep("Verify Title List of applications page")]
        public ListOfApplications VerifyTitleListOfApplications()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfApplications);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfApplications));

            return this;
        }
    }
}
