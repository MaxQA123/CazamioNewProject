using Allure.Commons;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.MarketplaceAdminsTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;

namespace SuperAdminGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : SuperAdminBase
    {
        //Amount order 2 next must be 3
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Super Admin")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .LogInAsSuperAdmin();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Super Admin")]
        [AllureSubSuite("Create Marketplace Admin")]

        public void CreateMarketplaceAdmin()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsSuperAdmin();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonMarketplaceAdmins();
            Pages.ListOfMarketplaceAdmins
                .VerifyTitleListOfMarketplaceAdmins()
                .ClickButtonCreateMarketplaceAdmin();
            Pages.CreateANewMarketplaceAdminMdlWindow
                .VerifyTitleCreateANewMarketplaceadmin()
                .FillInMandatoryFields();

            string fullEmailPutsBox = Pages.CreateANewMarketplaceAdminMdlWindow.GetEmailFromFieldInputEmail();
            string partEmailPutsBox = Pages.CreateANewMarketplaceAdminMdlWindow.CopyEmailBeforeDogFromFieldInputEmail();

            Pages.CreateANewMarketplaceAdminMdlWindow
                .ClickButtonCreate();
            Pages.ListOfMarketplaceAdmins
                .VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);
            Pages.EmailPutsBox
                .VerifySubjectNotificationCreateAdmin()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.GetPasswordFromEmailForCreaationUser();

            Pages.EmailPutsBox
                .ClickButtonConfirmEmailForAdmin();

            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateAdmin(fullEmailPutsBox)
                .PasteForEnterPsswrdFromEmailCreateAdmin(getTextPasswordActual)
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameRoleMarketplaceAdmin = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRoleCreating(getUserNameRoleMarketplaceAdmin);

            WaitUntil.WaitSomeInterval(1000);

            #endregion

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            Console.WriteLine($"{fullEmailPutsBox}");
            WaitUntil.WaitSomeInterval(100);
            MarketplaceAdminsDbRequests.MarketplaceAdmins.DeleteNewlyCreatedMarketplaceAdmin(fullEmailPutsBox, marketplaceId);

            #endregion
        }

        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Super Admin")]
        [AllureSubSuite("Verify Sidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                .LogInAsSuperAdmin();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImageUserOfSuperAdmin()
                .ClickingAllTabsOfSuperAdmin();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitle();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }
    }
}
