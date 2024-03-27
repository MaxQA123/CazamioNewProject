using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BrokerGuiTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : BrokerBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordAsBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.Sidebar.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.Sidebar.GetUserNameRoleFromSideBar();

            Pages.Sidebar
                .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}
