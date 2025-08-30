using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("Verify Title Login page")]
        public LogInLandlord VerifyTitleLogInPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleLogInPg));

            return this;
        }
    }
}
