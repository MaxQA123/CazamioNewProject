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
            WaitUntil.CustomElementIsVisible(TitleLogInPg);
            Assert.IsTrue(Successfully.IsVisible(TitleLogInPg));

            return this;
        }
    }
}
