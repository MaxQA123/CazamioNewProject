using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AgentBrokerGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : AgentBrokerBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("AgentBroker")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsAgentBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.Sidebar.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.Sidebar.GetUserNameRoleFromSideBar();

            Pages.Sidebar
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);

            #endregion

        }
    }
}