using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AgentGuiTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : AgentBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
               .EnterEmailPasswordAsAgent()
               .ClickIconShow()
               .ClickButtonLetsGo();

            string getUserNameCompare = Pages.Sidebar.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.Sidebar.GetUserNameRoleFromSideBar();

            Pages.Sidebar
                .VerifyAgentUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
