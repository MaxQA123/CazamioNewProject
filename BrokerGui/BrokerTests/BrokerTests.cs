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
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsBroker()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
            #endregion

            #region Preconditions

            Pages.SidebarLandlord
                .UploadImageLogoLandlordFirst()
                .VerifyChangingLogoImageLandlord()
                .UploadImageLogoLandlordSecond()
                .VerifyChangingLogoImageLandlord()
                .UploadImageAvatarUserLandlordFirst()
                .VerifyChangingAvatarImageLandlord()
                .UploadImageAvatarUserLandlordSecond()
                .VerifyChangingAvatarImageLandlord()
                .ClicklinkRemovePhotoOfLandlord()
                .VerifyRewmoveAvatarImageLandlord()
                .ClickButtonDashboard();
            Pages.Dashboard
                .VerifyTitleOfDashboardPg();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            Pages.SidebarLandlord
                .ClickButtonApartments();
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            Pages.SidebarLandlord
                .ClickButtonLeaseSignDocuments();
            Pages.Templates
                .VerifyTitleTemplatesPage();
            Pages.SidebarLandlord
                .ClickButtonPaymentSettings();
            Pages.PaymentSettings
                .VerifyTitlePaymentSettingsPage();
            Pages.SidebarLandlord
                .ClickButtonTransactions();
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            Pages.SidebarLandlord
               .ClickButtonLeads();
            Pages.ListOfLeads
                .VerifyTitleLeads();
            Pages.SidebarLandlord
                .ClickButtonAgents();
            Pages.ListOfAgents
                .VerifyTitleAgentsPg();
            Pages.SidebarLandlord
                .ClickButtonOwners();
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            Pages.SidebarLandlord
               .ClickButtonMarketplace();
            Pages.Marketplace
                .VerifyTitleMarketplacePg();
            Pages.AreYouSureLogOutLandlord
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitle();

            #endregion
        }
    }
}
