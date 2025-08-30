using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [AllureStep("Verify Title List of Commissions page")]
        public ListOfCommissions VerifyTitleListOfCommissions()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfCommissions);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfCommissions));

            return this;
        }
    }
}
