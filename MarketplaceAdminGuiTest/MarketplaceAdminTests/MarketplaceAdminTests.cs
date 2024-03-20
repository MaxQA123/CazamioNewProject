using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace MarketplaceAdminGuiTest
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : MarketplaceAdminBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("LogIn")]
        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShowLogInPg()
                .ClickButtonLetsGoLogInPg();

            //string getUserNameCompare = Pages.SideBarLandlord.GetUserNameFromSideBar();
            //string getUserNameRoleCompare = Pages.SideBarLandlord.GetUserNameRoleFromSideBar();

            //Pages.SideBarLandlord
            //    .VerifyBrokerUserName(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}