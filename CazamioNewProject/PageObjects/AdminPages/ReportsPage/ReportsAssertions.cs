using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ReportsPage
{
    public partial class Reports
    {
        [AllureStep("VerifyTitleReportsPage")]
        public Reports VerifyTitleReportsPage()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleReportsPage));

            return this;
        }
    }
}
