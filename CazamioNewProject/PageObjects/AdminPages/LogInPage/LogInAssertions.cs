using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("VerifyTitle")]
        public LogInLandlord VerifyTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleLogInPg));

            return this;
        }
    }
}
