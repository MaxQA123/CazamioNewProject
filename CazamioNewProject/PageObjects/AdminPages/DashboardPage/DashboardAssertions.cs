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
            WaitUntil.CustomElementIsVisible(TitleDashboardPage);
            Assert.IsTrue(Successfully.IsVisible(TitleDashboardPage));

            return this;
        }
    }
}
