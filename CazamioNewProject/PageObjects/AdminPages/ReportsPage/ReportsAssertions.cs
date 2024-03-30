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
            WaitUntil.WaitSomeInterval(1000);
            Assert.IsTrue(Successfully.IsVisible(TitleReportsPage));

            return this;
        }
    }
}
