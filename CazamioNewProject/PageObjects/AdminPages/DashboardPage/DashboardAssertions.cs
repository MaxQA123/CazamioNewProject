using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.DashboardPage
{
    public partial class Dashboard
    {
        [AllureStep("VerifyTitleOfDashboardPg")]
        public Dashboard VerifyTitleOfDashboardPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleDashboardPage));

            return this;
        }
    }
}
