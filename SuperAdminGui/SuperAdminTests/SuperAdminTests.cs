using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace SuperAdminGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : SuperAdminBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.LogInLandlord
                .EnterEmailPasswordAsSuperAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifySuperAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            WaitUntil.WaitSomeInterval(2000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateMarketplaceAdmin")]

        public void CreateMarketplaceAdmin()
        {
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsSuperAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifySuperAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

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

            //WaitUntil.WaitSomeInterval(500);
            //var marketplaceIdFromDb = DBRequestAspNetUsers.AspNetUsers.GetMarketplaceIdByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            //Console.WriteLine($"MarketplaceId from DB: {marketplaceIdFromDb.MarketplaceId}");

            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.TitleLetterCreateAdminMySpace, partEmailPutsBox);
            Pages.EmailPutsBox
                .VerifyTitleLetterCreateAdmin()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.CopyPasswordFromEmailForCreateAdmin();

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

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }
    }
}
