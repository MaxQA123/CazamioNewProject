using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ReportsPage
{
    public partial class Reports
    {
        [AllureStep("Verify Title Reports page")]
        public Reports VerifyTitleReportsPage()
        {
            WaitUntil.CustomElementIsVisible(TitleReportsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleReportsPage));

            return this;
        }
    }
}
