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

        [AllureStep("Verify message Email is required under field email")]
        public LogInLandlord VerifyMessageEmailIsRequired()
        {
            Assert.IsTrue(MessagesUnderFieldsCheck.IsVisible(MessageEmailIsRequired));

            return this;
        }

        [AllureStep("Verify message Password is required under field passowrd")]
        public LogInLandlord VerifyMessagePasswordIsRequired()
        {
            Assert.IsTrue(MessagesUnderFieldsCheck.IsVisible(MessagePasswordIsRequired));

            return this;
        }
    }
}
