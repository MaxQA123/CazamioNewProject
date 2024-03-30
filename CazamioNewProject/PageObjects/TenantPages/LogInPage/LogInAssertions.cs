using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        [AllureStep("VerifyMessageAccountWasSuccessfullyActivated")]
        public LogInTenant VerifyMessageAccountWasSuccessfullyActivated()
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.IsTrue(Successfully.IsVisible(MessageAccountWasSuccessfullyActivated));

            return this;
        }

        [AllureStep("VerifyMessageYouHaveSuccesfullyChangedYourPassword")]
        public LogInTenant VerifyMessageYouHaveSuccesfullyChangedYourPassword()
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.IsTrue(Successfully.IsVisible(MessageYouHaveSuccesfullyChangedYourPassword));

            return this;
        }
    }
}
