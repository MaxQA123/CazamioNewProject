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
            #region Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

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
                .VerifyRewmoveAvatarImageLandlord();
            //    .ClickButtonDashboardSidebar();
            //Pages.Dashboard
            //    .VerifyTitleOfDashboardPg();
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
                .ClickButtonBrokers();
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg();
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
                .ClickButtonCommissions();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();
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
            Pages.SidebarLandlord
                .ClickButtonReports();
            Pages.Reports
                .VerifyTitleReportsPage();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitle();

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateBroker")]

        public void CreateBroker()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonBrokers();
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg()
                .ClickButtonCreateBroker();
            Pages.CreateANewBrokerMdlWndw
                .VerifyTitleCreateNewBroker()
                .EnterFirstLastNamesEmail();

            string getFullEmail = Pages.CreateANewBrokerMdlWndw.CopyEmailFromModalWindowCreateNewBroker();
            string getEmailBeforeDog = Pages.CreateANewBrokerMdlWndw.CopyEmailBeforeDogFromModalWindowCreateNewBroker();

            Pages.CreateANewBrokerMdlWndw
                .ClickButtonCreate();
            Pages.ListOfBrokers
                .VerifyMessageBrokerHasBeenSuccessfullyCreated();

            //WaitUntil.WaitSomeInterval(500);
            //var marketplaceIdFromDb = DBRequestAspNetUsers.AspNetUsers.GetMarketplaceIdByEmailAndMarketplaceId(getFullEmail, marketplaceId);
            //Console.WriteLine($"MarketplaceId from DB: {marketplaceIdFromDb.MarketplaceId}");

            string getEmailFromListOfBrokers = Pages.ListOfBrokers.CopyEmailFirstRecordEmailForFirstBrokerInList();

            Pages.ListOfBrokers
                .VerifyEmailInListOfBrokers(getFullEmail, getEmailFromListOfBrokers);
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.TitleLetterCreateBrokerMySpace, getEmailBeforeDog);
            Pages.EmailPutsBox
                .VerifyTitleLetterCreateBroker()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.CopyPasswordFromEmailForCreateAdmin();

            Pages.EmailPutsBox
                .ClickButtonConfirmEmailForAdmin();

            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateBroker(getFullEmail)
                .PasteForEnterPsswrdFromEmailCreateBroker(getTextPasswordActual)
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameRoleCompareBroker = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyBrokerUserNameAndRoleCreating(getUserNameRoleCompareBroker);

            #endregion

            WaitUntil.WaitSomeInterval(2000);

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonAgents();
            Pages.ListOfAgents
                .ClickButtonCreateAgent();
            Pages.CreateNewAgentMdlWndw
                .EnterFirstLastNameEmailPhnNmbrCell()
                .EnterBrokerAgentCommission();

            string fullEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailFromMdlWndwCreateAgent();
            string partEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailBeforeDogFromModalWindowCreateNewAgent();

            Pages.CreateNewAgentMdlWndw
                .ClickButtonSave()
                .VerifyMessageNewAgentCreatedSuccessfully();
            KeyBoardActions.ClickEscapeButton();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.TitleLetterCreateAgentMySpace, partEmailPutsBox);
            Pages.EmailPutsBox
                .VerifyTitleLetterCreateAgent()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.CopyPasswordFromEmailForCreateAdmin();

            Pages.EmailPutsBox
                .ClickButtonConfirmEmailForAdmin();
            Pages.LogInLandlord
                .PasteForEnterEmailFromEmailCreateAgent(fullEmailPutsBox)
                .PasteForEnterPsswrdFromEmailCreateAgent(getTextPasswordActual)
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameRoleCompareAgent = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentUserNameAndRoleCreating(getUserNameRoleCompareAgent);

            #endregion

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedBroker")]

        public void CreateOwnerWithAssignedBroker()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonOwners();
            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.CreateANewOwnerMdlWndw
                .VerifyTitleCreateANewOwner()
                .EnterCompanyNameForBrokerRole()
                .EnterOwnerName()
                .EnterOwnerEmaiL()
                .EnterOfficeLocation()
                .SelectBroker()
                .EnterInternalNotes()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneExtensionNumbers()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.CreateANewOwnerMdlWndw
                .EnterDataOwnerPays();

            string getOwnerEmailFromModalWndw = Pages.CreateANewOwnerMdlWndw.GetEmailFromFieldOwnerEmail();

            Pages.CreateANewOwnerMdlWndw
                .ClickButtonCreate();
            Pages.ListOfOwners
                .VerifyMessageSuccessCreatedOwner();

            string getLastEmailFromPage = Pages.ListOfOwners.GetFirstEmailFromTable();

            Pages.ListOfOwners
                .VerifyEmailForNewOwner(getOwnerEmailFromModalWndw, getLastEmailFromPage);

            #endregion

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedAgent")]

        public void CreateOwnerWithAssignedAgent()
        {
            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonOwners();
            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.CreateANewOwnerMdlWndw
                .VerifyTitleCreateANewOwner()
                .EnterCompanyNameForAgentRole()
                .EnterOwnerName()
                .EnterOwnerEmaiL()
                .EnterOfficeLocation()
                .SelectAgent()
                .EnterInternalNotes()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneExtensionNumbers()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.CreateANewOwnerMdlWndw
                .SwitchingItemsPays()
                .ClickButtonAddMgmt()
                .ClickButtonPayType()
                .SelectItemOwnerAndTenantPays()
                .EnterDataOwnerAndTenantPays()
                .ScrollDown()
                .EnterFullDataMgmt();

            string getOwnerEmailFromModalWndw = Pages.CreateANewOwnerMdlWndw.GetEmailFromFieldOwnerEmail();

            Pages.CreateANewOwnerMdlWndw
                .ClickButtonCreate();
            Pages.ListOfOwners
                .VerifyMessageSuccessCreatedOwner();

            string getLastEmailFromPage = Pages.ListOfOwners.GetFirstEmailFromTable();

            Pages.ListOfOwners
                .VerifyEmailForNewOwner(getOwnerEmailFromModalWndw, getLastEmailFromPage);

            #endregion

            WaitUntil.WaitSomeInterval(2000);

        }
    }
}