using Allure.Commons;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BrokersAgentsTable;
using CazamioNewProject.DbHelpers.LandlordsBrokersTable;
using CazamioNewProject.DbHelpers.OwnerCommissionsStructureTable;
using CazamioNewProject.DbHelpers.OwnerManagementsTable;
using CazamioNewProject.DbHelpers.OwnerPhoneNumbersTable;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;

namespace MarketplaceAdminGuiTest
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : MarketplaceAdminBase
    {
        //Amount order 12 next must be 13
        [Test]
        [Order(2)]
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
        [Order(1)]
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
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateBroker")]

        public void CreateBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

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

            string getFullEmail = Pages.CreateANewBrokerMdlWndw.CopyEmailFromFieldEmail();
            string getEmailBeforeDog = Pages.CreateANewBrokerMdlWndw.CopyEmailBeforeDogFromModalWindowCreateNewBroker();

            Pages.CreateANewBrokerMdlWndw
                .ClickButtonCreate();
            Pages.ListOfBrokers
                .VerifyMessageBrokerHasBeenSuccessfullyCreated();

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

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(getFullEmail, marketplaceId);
            Console.WriteLine($"{getFullEmail}");
            WaitUntil.WaitSomeInterval(100);
            LandlordsBrokersDbRequests.LandlordsBrokers.DeleteNewlyCreatedBroker(getFullEmail, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(getFullEmail, marketplaceId);

            #endregion

        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

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

            string fullEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailFromFieldEmail();
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
                .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateAgentMySpace, partEmailPutsBox);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateAgentMySpace()
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

            #region Postconditions

            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            Console.WriteLine($"{fullEmailPutsBox}");
            WaitUntil.WaitSomeInterval(100);
            BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(fullEmailPutsBox, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(fullEmailPutsBox, marketplaceId);

            #endregion

        }

        [Test]
        [Order(6)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedBroker")]

        public void CreateOwnerWithAssignedBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

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
                .EnterCompanyNameOneLetter()
                .EnterOwnerFirstName()
                .EnterOwnerEmaiLGmail()
                .EnterOfficeLocationWashington()
                .SelectBroker()
                .EnterInternalNotesShort()
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

            #region Postconditions

            OwnerCommissionsStructureDbRequests.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(getOwnerEmailFromModalWndw, marketplaceId);
            Console.WriteLine($"{getOwnerEmailFromModalWndw}");
            OwnerPhoneNumbersDbRequests.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(getOwnerEmailFromModalWndw, marketplaceId);
            OwnerManagementsDbRequsts.OwnerManagements.DeleteRecordAboutOwnerManagements(getOwnerEmailFromModalWndw, marketplaceId);
            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateOwnerWithAssignedAgent")]

        public void CreateOwnerWithAssignedAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

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
                .EnterCompanyNameAgentMaxSymbols()
                .EnterOwnerFirstLastName()
                .EnterOwnerEmaiLYahoo()
                .EnterOfficeLocationNewYork()
                .SelectAgent()
                .EnterInternalNotesLong()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneExtensionNumbersFull()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.CreateANewOwnerMdlWndw
                .SwitchingItemsPays()
                .ClickButtonAddMgmt()
                .ClickButtonPayType()
                .SelectItemOwnerAndTenantPays()
                .EnterDataOwnerAndTenantPaysMin()
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

            #region Postconditions

            OwnerCommissionsStructureDbRequests.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(getOwnerEmailFromModalWndw, marketplaceId);
            Console.WriteLine($"{getOwnerEmailFromModalWndw}");
            OwnerPhoneNumbersDbRequests.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(getOwnerEmailFromModalWndw, marketplaceId);
            OwnerManagementsDbRequsts.OwnerManagements.DeleteRecordAboutOwnerManagements(getOwnerEmailFromModalWndw, marketplaceId);
            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

        }

        [Test]
        [Order(7)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddBuildingAssignedBroker")]

        public void AddBuildingAssignedBroker()
        {
            #region SettingsForBuilding

            //Washington Square

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);
            Pages.SidebarLandlord
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerOwnerAndTenantPaysCommissionBroker()
                .EnterBuildingDataWashingtonSquare();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            Pages.NewBuilding
                .EnterLongInternalNotesDescription();
            KeyBoardActions.ClickTab();
            Pages.NewBuilding
                .ClickBtnEditForPaymentSystem();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();
            string getValueHoldDeposit = Pages.NewBuilding.GetValueFromFieldHoldDeposit();
            string getItemCardknoxActual = Pages.PaymentKeysMdlWndw.GetItemCardknox();
            string getItemApiKeyCardknoxActual = Pages.PaymentKeysMdlWndw.GetItemApiKeyCardknox();

            Pages.PaymentKeysMdlWndw
                .ClickButtonCross();
            Pages.PaymentKeysMdlWndw
                .VerifyApiKeyCardknox(getItemCardknoxActual, getItemApiKeyCardknoxActual);
            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .VerifyValueByDefaulHoldDeposit(getValueHoldDeposit)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectScreeningFeeAllPaymentMethods();
            Pages.NewBuilding
                .ClickBtnSelectPaymentMethodsForHoldDeposit();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectHoldDepositAllPaymentMethods();
            Pages.NewBuilding
                .ClickButtonSelectPetPolicies();
            Pages.PetPoliciesMdlWndw
                .VerifyTitlePetPoliciesMdlWndw()
                .SelectAllItems()
                .ClickButtonSave();
            KeyBoardActions.ScrollToUp();
            Pages.NewBuilding
            .ClickTabAmenities()
            .ClickFieldInputSearchForAmenities()
            .SelectFiveAmenities()
            .ClickTabAccess()
            .ClickButtonAddLock();

            string copyActualNameLocation = Pages.NewBuilding.CopyNameLocation();

            Pages.NewBuilding
                .VerifyLocationMainAccess(copyActualNameLocation)
                .AddItemAccessTypePinCode()
                .ClickButtonAddLock();

            string copyActualNameLocationTwo = Pages.NewBuilding.CopyNameLocation();

            Pages.NewBuilding
                .VerifyLocationApartment(copyActualNameLocationTwo)
                .AddItemAccessTypeNote();

            string copyActualNameNote = Pages.NewBuilding.GetNameNoteTypeAccessFromTable();
            string copyActualNamePinCode = Pages.NewBuilding.GetNamePinCodeTypeAccessFromTable();

            Pages.NewBuilding
                .VerifyTypeAccessFromTable(copyActualNameNote, copyActualNamePinCode)
                .ClickTabSpecials()
                .ClickButtonAddSpecials()
                .AddFirstConcessionIsActive();

            string getNameConcession = Pages.NewBuilding.GetNameConcessionFromTable();

            Pages.NewBuilding
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFirstFreeStuffIsActive();

            string getNameFreeStuff = Pages.NewBuilding.GetNameFreeStuffFromTable();

            Pages.NewBuilding
                .VerifyNameConcessionAndFreeStuff(getNameConcession, getNameFreeStuff)
                .ClickTabImages()
                .UploadFourImages()
                .ClickButtonSaveBuilding()
                .VerifyMessageSavedSuccessfullyBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            #endregion
        }

        [Test]
        [Order(8)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddBuildingAssignedBroker")]

        public void AddBuildingAssignedAgent()
        {

            #region SettingsForBuilding

            //Saint Johnson Place

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);
            Pages.SidebarLandlord
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerNoCommissionAgent()
                .EnterBuildingDataSaintJohnsonPl()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodsCrdtCrdAchZll();
            Pages.NewBuilding
                .ClickBtnEditForPaymentSystem();
            Pages.PaymentKeysMdlWndw
                .SelectPaymentSystemAuthorizeNet();

            string getItemAuthorizeNetActual = Pages.PaymentKeysMdlWndw.GetItemAuthorizeNet();
            string getItemApiKeyAuthorizeNetActual = Pages.PaymentKeysMdlWndw.GetItemApiKeyAuthorizeNet();

            Pages.PaymentKeysMdlWndw
                .VerifyApiKeyAuthorizeNet(getItemAuthorizeNetActual, getItemApiKeyAuthorizeNetActual);
            Pages.PaymentKeysMdlWndw
                .ClickButtonSave();
            Pages.NewBuilding
                .ClickThreeTimesButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                .ClickTabConcessions()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                .ClickButtonGeneralNext()
                .ClickButtonSaveBuilding()
                .VerifyMessageSavedSuccessfullyBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            #endregion

        }

        [Test]
        [Order(10)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddApartmentAssignedBroker")]

        public void AddApartmentAssignedBroker()
        {
            #region SettingsForBuilding

            //1 Washington Square

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchBuildingOneWashingtonSquare();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneWashingtonSquare)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .VerifyTitleAddApartmentsPage();

            string getBuildingNameFromAddApartments = Pages.AddApartments.GetBuildingName();

            Pages.AddApartments
                .VerifyBuildingNameAddApartmentsPage(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments)
                .EnterToAllFieldsOneWashingtonSquare();

            string getLeasePriceFromAddApartments = Pages.AddApartments.GetLeasePrice();
            string getUnitNumberFromAddApartments = Pages.AddApartments.GetUnitNumber();

            Pages.AddApartments
                //.SelectStatusVacant() By default the Vacant
                .SelectAgent()
                .SetFirstDayLastMonthsAvailableFrom()
                .SelectApartmentTypeMultiFamily();

            string getStatusFromAddApartments = Pages.AddApartments.GetStatus();

            JScriptExecutor.ScrollToDownWebPage();

            Pages.AddApartments
                .ClickButtonSetFromBuilding();

            string getApartmentHoldDepositFromAddApartments = Pages.AddApartments.GetApartmentHoldDeposit();

            Pages.AddApartments
                .VerifyApartmentHoldDepositAddApartmentsPage(getApartmentHoldDepositFromAddApartments);

            string getRentalTerms = Pages.AddApartments.GetRentalTerms();

            Pages.AddApartments
                .VerifyRentalTermsAddApartmentsPage(getRentalTerms);

            string getThreeRecentPaystubsAddApartments = Pages.AddApartments.GetRequiredDocumentTwoRecentPaystubs();
            string getEmploymentVerificationLetterAddApartments = Pages.AddApartments.GetRequiredDocumentItemEmploymentVerificationLetter();
            string getGovIssuedIdAddApartments = Pages.AddApartments.GetRequiredDocumentGovIssuedId();
            string getTwoMostRecentBankStatementsAddApartments = Pages.AddApartments.GetRequiredDocumentTwoMostRecentBankStatements();
            string getThreeMostRecentRentPaymentsAddApartments = Pages.AddApartments.GetRequiredDocumentThreeMostRecentRentPayments();
            string getMostRecentTaxReturnAddApartments = Pages.AddApartments.GetRequiredDocumentMostRecentTaxReturn();


            Pages.AddApartments
                .VerifyRequiredDocumentsByDefaultMySpaceAddApartments(getThreeRecentPaystubsAddApartments, getEmploymentVerificationLetterAddApartments, getGovIssuedIdAddApartments, getTwoMostRecentBankStatementsAddApartments, getThreeMostRecentRentPaymentsAddApartments, getMostRecentTaxReturnAddApartments)
                .EnterLongDescriptionInternalNotes()
                .ClickButtonGeneralNext()
                .SelectAllAmenitiesIncludedInMonthlyRent()
                .SelectFiveAmenities()
                .ClickButtonGeneralNext()
                .ClickButtonAddLock()
                .AddItemAccessTypePinCode()
                .ClickButtonAddLock()
                .AddItemAccessTypeNote()
                .ClickButtonAddLock()
                .AddItemAccessTypeExistingOccupant()
                //Add Assertion
                .ClickButtonGeneralNext()
                .ClickButtonAddSpecials()
                .AddConcessionIsActive()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActive()
                //Add Assertion
                .ClickButtonGeneralNext()
                .UploadFiveImages()
                .ClickButtonSaveApartment();
                //Add Assertion

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        [Order(9)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("AddApartmentAssignedAgent")]
        public void AddApartmentAssignedAgent()
        {
            #region SettingsForBuilding

            //9998 Saint Johnson Place

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineNineNineEightSaintJohnsonPlace();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.NineNineNineEightSaintJohnsonPlace)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .VerifyTitleAddApartmentsPage();

            string getBuildingNameFromAddApartments = Pages.AddApartments.GetBuildingName();

            Pages.AddApartments
                .VerifyBuildingNameAddApartmentsPage(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments)
                .EnterMandatoryFieldsNineNineNineEightSaintJohnsonPlace()
                .SelectCurrentDateAvailableFrom()
                .SelectStatusDepositReceived()
                .SelectApartmentTypeSingleFamily()
                .ClickButtonPaymentMethods();
            Pages.PaymentOptionsMdlWndw
                .SelectAllPaymentMethodsWithoutAchHoldDepositApartment();
            Pages.AddApartments
                .SetOneYearRentalTerms()
                .ClickTabAmenities()
                .ClickTabAccess()
                .ClickTabSpecials()
                .ClickButtonAddSpecials()
                .AddConcessionIsActive()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                //Add assertion
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActive()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                //Add assertion
                .ClickTabImages()
                .ClickButtonSaveApartment();

            #endregion

            WaitUntil.WaitSomeInterval(5000);
        }

        [Test]
        [Order(11)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationForApartmentDepositReceived")]

        public void CreateApplicationForApartmentDepositReceived()
        {
            #region SettingsForBuilding

            //Saint Johnson Place

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            ApartmentApplicationsTable apartmentApplicationsTable = ApartmentApplicationsTable.Generate();
            TenantCreator tenantCreator = TenantCreator.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .EnterEmailPasswordAsMarketplaceAdmin()
                .ClickIconShow()
                .ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineNineNineEightSaintJohnsonPlace();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.NineNineNineEightSaintJohnsonPlace)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectExpected();

            Pages.BuildingApartmentsTbl
                .ClickRowByDepositReceived();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage()
                .EnterFieldInputGetApplicationLink();

            string leasePriceFromUnit = Pages.ApartmentView.GetLeasePriceValueOfString();
            string partEmailPutsBox = Pages.ApartmentView.CopyEmailBeforeDogFromFieldGetApplicationLink();

            Pages.ApartmentView
                .ClickButtonGetLink()
                .VerifyCopiedTheLinkToApplication()
                .ClickTabApplications();
            KeyBoardActions.ScrollToDown();

            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string firstNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetFirstNameTenantMainApplicantFromFirstRow();
            string lastNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetLastNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApplication = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApplication = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApplication = Pages.ApartmentApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApplication = Pages.ApartmentApplicationsTbl.GetStatusFromFrstRw();

            Pages.ApartmentApplicationsTbl
                .VerifyFullDataByApplication(getAddressBuildingViewActual, apartmentAddressFromApp, tenantCreator.FirstLastNameData.ConstantFirstNameTenant, firstNameTenantMainApplicantFromApp, tenantCreator.FirstLastNameData.ConstantLastNameTenant, lastNameTenantMainApplicantFromApp, leasePriceFromUnit, leasePriceFromApplication, agentFromApplication, apartmentApplicationsTable.AgentColumn.NotAssigned, statusFromApplication, apartmentApplicationsTable.StatusColumn.Draft, dateCreatedFromApplication, apartmentApplicationsTable.CreatedOnColumn.DateCurrent);
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, partEmailPutsBox);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectLetterCreateTenantViaGetLink();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLink(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowlForTenant();
            Pages.SubmittingApplication
                .VerifyMessageAccountWasSuccessfullyActivated();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(12)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin")]
        [AllureSubSuite("CreateApplicationForApartmentVacant")]

        public void CreateApplicationForApartmentVacant()
        {
            //#region Test data

            //Apartment apartment = Apartment.Generate();

            //#endregion

            //#region Preconditions Test

            //Pages.LogInLandlord
            //    .EnterEmailPasswordAsMarketplaceAdmin()
            //    .ClickIconShow()
            //    .ClickButtonLetsGo();

            //string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            //string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            //Pages.SidebarLandlord
            //    .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);
            //Pages.SidebarLandlord
            //    .ClickButtonBuildings();
            //Pages.ListOfBuildings
            //    .SearchBuildingOneWashingtonSquare();
            //Pages.ListOfBuildings
            //    .SelectItemFirst();
            //Pages.BuildingView
            //    .VerifyTitleBuildingViewPage();

            //string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            //string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            //Pages.BuildingView
            //    .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneWashingtonSquare)
            //    .ClickTabApartments();
            //KeyBoardActions.ScrollToDown();
            //Pages.BuildingApartmentsTbl
            //    .ClickRowByVacant();
            //Pages.ApartmentView
            //    .VerifyTitleApartmentViewPage();
            //    //.CreateNewApplicationAndTenantViaButtonGetLink();

            //#endregion

            //WaitUntil.WaitSomeInterval(10000);
        }
    }
}