using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.VisitLogsPage
{
    public partial class VisitLogs
    {
        [AllureStep("VerifyTitleVisitLogsPg")]
        public VisitLogs VerifyTitleVisitLogsPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleVisitLogsPg));

            return this;
        }
    }
}
