using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BrokersAgentsTable;
using CazamioNewProject.DbHelpers.LandlordsBrokersTable;
using CazamioNewProject.DbHelpers.Marketplaces;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;

namespace MarketplaceAdminGuiTest
{
    [TestFixture]
    [AllureNUnit]

    // Amount order 16 next must be 17
    // Basic settings for autotests:
    // 1. Need to comment out the “AddGroupBuildingsViaApiBasicStatic” case after the first run of the automated tests if all buildings were soft deleted.
    // 2. SettingsMarketplaceViaApiDb case.
    // 3. SettingsMarketplacePage case.

    public class TestsBaseGui : MarketplaceAdminBase
    { 
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("Login to My Space marketplace")]

        public void LogIn_Success()
        {
            #region Test

            // flow: Login > Verify user role and user name > Success code 200.
            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("Update Settings for Marketplace Page")]

        public void Update_Settings_MarketplacePage()
        {
            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonMarketplace();

            #endregion

            #region Test

            Pages.Marketplace
                .FillInBrandNameAndDisclosureInformation();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("Basic Update Brand Name MySpace Via DB")]

        public void Basic_Update_Brand_Name_MySpace_Via_DB()
        {
            #region Test

            MarketplacesDbRequests.MarketplacesDbTable.UpdateBrandForMarketplaceMySpace();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("Verify Sidebar")]

        public void Verify_Sidebar()
        {
            // Upload images logo marketplace and user avatar.
            // Select the tabs.

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImagesUserAndLogoMarketplaceOfMA()
                .ClickingAllTabsOfMA();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateBroker")]

        public void CreateBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

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
            string getEmailBeforeDog = Pages.CreateANewBrokerMdlWndw.GetSymbolsBeforeDogFromFieldInputEmail();

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
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, getEmailBeforeDog);
            Pages.EmailPutsBox
                .VerifyTitleLetterCreateBroker()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.GetPasswordFromEmailForCreaationUser();

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

            #endregion

        }

        [Test]
        [Order(6)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ClickButtonAgents();
            Pages.ListOfAgents
                .ClickButtonCreateAgent();
            Pages.CreateNewAgentMdlWndw
                .EnterFullData();

            string fullEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailFromFieldEmail();
            string partEmailPutsBox = Pages.CreateNewAgentMdlWndw.GetSymbolsBeforeDogFromFieldInputEmail();


            Pages.CreateNewAgentMdlWndw
                .ClickButtonSave()
                .VerifyMessageNewAgentCreatedSuccessfully();
            KeyBoardActions.ClickEscapeButton();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateAgentMySpace()
                .ClickButtonHtml();

            string getTextPasswordActual = Pages.EmailPutsBox.GetPasswordFromEmailForCreaationUser();

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

            #endregion

        }

        [Test]
        [Order(7)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateOwnerWithAssignedBroker")]

        public void CreateOwnerWithAssignedBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

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

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

        }

        [Test]
        [Order(8)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateOwnerWithAssignedAgent")]

        public void CreateOwnerWithAssignedAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();

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

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion

        }

        [Test]
        [Order(9)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("AddBuildingAssignedBroker")]

        public void AddBuildingAssignedBroker()
        {
            #region SettingsForBuilding

            //Washington Square

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
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

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();
            string getValueHoldDeposit = Pages.NewBuilding.GetValueFromFieldHoldDeposit();
         
            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .VerifyValueByDefaulHoldDeposit(getValueHoldDeposit)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectAllPaymentMethods();
            Pages.NewBuilding
                .ClickBtnSelectPaymentMethodsForHoldDeposit();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectAllPaymentMethods();
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
                .ClickButtonSaveBuilding();
            Pages.ToasterMessagesLandlord
                .VerifyMessageSavedSuccessfullyIfCreatedBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(10)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("AddBuildingAssignedBroker")]

        public void AddBuildingAssignedAgent()
        {

            #region SettingsForBuilding

            //Saint Johnson Place

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
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
                .SelectPaymentMethodsAchZll();
            Pages.NewBuilding
                .ClickThreeTimesButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                .ClickTabConcessions()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                .ClickButtonGeneralNext()
                .ClickButtonSaveBuilding();
            Pages.ToasterMessagesLandlord
                .VerifyMessageSavedSuccessfullyIfCreatedBuilding();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView);

            WaitUntil.WaitSomeInterval(1000);

            #endregion

        }

        [Test]
        [Order(11)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("AddGroupBuildingsViaApiBasicStatic")]

        public void AddGroupBuildingsViaApiBasicStatic()
        {

            #region SettingsForBuilding

            //9998 Saint Johnson Place
            //1 Washington Square

            #endregion

            #region Test Data

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Preconditions API LogIn as Marketplace Admin

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Test create the 9998 Saint Johnson Place building

            var buildingRequestBodySaintJohnsonPl = BuildingCreationMandatoryData.RequestBodyCreateBuildingNineNineNineEightSaintJohnsonPlace();
            var responseBuildingSaintJohnsonPl = BuildingCreationMandatoryData.CreateBuildingNineNineNineEightSaintJohnsonPlace(responseMarketplaceAdmin.AuthData.Token, buildingRequestBodySaintJohnsonPl);

            #endregion

            #region Test create the 1 Washington Square building

            var buildingRequestBodyWashingtonSquare = BuildingCreationMandatoryData.RequestBodyCreateBuildingOneWashingtonSquare();
            var responseBuildingWashingtonSquare = BuildingCreationMandatoryData.CreateBuildingOneWashingtonSquare(responseMarketplaceAdmin.AuthData.Token, buildingRequestBodyWashingtonSquare);

            WaitUntil.WaitSomeInterval(1000);

            #endregion

        }

        [Test]
        [Order(12)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("AddApartmentAssignedBroker")]

        public void AddApartmentAssignedBroker()
        {
            #region SettingsForBuilding

            //1 Washington Square

            #endregion

            #region Test data

            Building building = Building.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchBuildingOneWashingtonSquare()
                .SelectOneWashingtonSquare();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.WashingtonSquare.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .VerifyTitleAddApartmentsPage();

            string getBuildingNameFromAddApartments = Pages.AddApartments.GetBuildingNameOneWashingtonSquare();

            Pages.AddApartments
                .VerifyBuildingName(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments)
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
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(13)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("AddApartmentAssignedAgent")]
        public void AddApartmentAssignedAgent()
        {
            #region SettingsForBuilding

            //9998 Saint Johnson Place

            #endregion

            #region Test data

            Building building = Building.Generate();
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineNineNineEightSaintJohnsonPlace()
                .SelectNineNineNineEightSaintJohnsonPlace();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.SaintJohnsonPl.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .VerifyTitleAddApartmentsPage();

            string getBuildingNameFromAddApartments = Pages.AddApartments.GetBuildingNameNineNineNineEightSaintJohnsonPlace();

            Pages.AddApartments
                .VerifyBuildingName(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments)
                .EnterMandatoryFieldsNineNineNineEightSaintJohnsonPlace()
                .SelectCurrentDateAvailableFrom()
                .SelectStatusDepositReceived()
                .SelectApartmentTypeSingleFamily()
                .ClickButtonPaymentMethods();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodsDlvrChckZllVnm();
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
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(14)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateApplicationForApartmentDepositReceived")]
       public void CreateApplicationForApartmentDepositReceived()
        {
            #region SettingsForBuilding

            //9998 Saint Johnson Place

            #endregion

            #region Test data

            Building building = Building.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineNineNineEightSaintJohnsonPlace();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingView = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingView, building.SaintJohnsonPl.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentSaintJohnsonPlace();

            Pages.BuildingApartmentsTbl
                .ClickRowByDepositReceived();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage()
                .EnterRandomEmailGetApplicationLink();

            string leasePriceFromUnit = Pages.ApartmentView.GetLeasePriceValueOfString();
            string partEmailPutsBox = Pages.ApartmentView.CopyEmailBeforeDogFromFieldGetApplicationLink();

            Pages.ApartmentView
                .ClickButtonGetLink()
                .ClickTabApplications();
            KeyBoardActions.ScrollToDown();

            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string firstNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetFirstNameTenantMainApplicantFromFirstRow();
            string lastNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetLastNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApp = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApp = Pages.ApartmentApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusFrstRw().Text;
            string closeNameBtnFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnCloseBtnFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyFullDataByApplicationTenantMain
                (getAddressBuildingView, apartmentAddressFromApp, 
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantFirstNameTenant, firstNameTenantMainApplicantFromApp, 
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantLastNameTenant, lastNameTenantMainApplicantFromApp, 
                leasePriceFromUnit, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                application.BasicData.NotAssignetLabel, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, closeNameBtnFromApp);
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.LeasePriceAdjustmentMdlWndw
                .ClickSaveBtn();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(15)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateApplicationForApartmentVacant")]

        public void CreateApplicationForApartmentVacant()
        {
            #region SettingsForBuilding

            //1 Washington square

            #endregion

            #region Test data

            Building building = Building.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            Agent agent = Agent.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                 .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchBuildingOneWashingtonSquare();
            Pages.ListOfBuildings
                .SelectItemFirst();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.WashingtonSquare.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithAgentWashingtonSquare();

            Pages.BuildingApartmentsTbl
                .ClickRowByVacant();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage();
            Pages.ApartmentView
                .ClickButtonPlusApplication();
            Pages.CreateApplicationMdlWndw
                .VerifyTitleCreateApplication()
                .PassFirstStepRandomEmail();

            string partEmailPutsBox = Pages.CreateApplicationMdlWndw.CopyEmailBeforeDogFromFieldGetApplicationLink();

            Pages.CreateApplicationMdlWndw
                .PassThirdStepFullData()
                .VerifyTitleApplicationSuccessfullyCreated()
                .VerifyTextLinkAlreadyCopied()
                .ClickButtonClose();
            Pages.ApartmentView
                .ClickTabApplications();

            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string firstNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetFirstNameTenantMainApplicantFromFirstRow();
            string lastNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetLastNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApp = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApp = Pages.ApartmentApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusFrstRw().Text;
            string closeNameBtnFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnCloseBtnFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyFullDataByApplicationTenantMain
                (getAddressBuildingViewActual, apartmentAddressFromApp,
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantFirstNameTenant, firstNameTenantMainApplicantFromApp,
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantLastNameTenant, lastNameTenantMainApplicantFromApp,
                application.LeasePrice.SecondPriceStatic, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                agent.CreatedAgentLulaMySpace.FullName, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, closeNameBtnFromApp);

            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaPlusAppWithAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.LeasePriceAdjustmentMdlWndw
                .ClickCancelBtn();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(16)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("CreateNewDocumentLeaseSignTemplateWithBrokerSign")]

        public void CreateNewDocumentLeaseSignTemplateWithBrokerSign()
        {
            #region Preconditions

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
               .ClickButtonLeaseSignDocuments();

            #endregion

            #region Test

            Pages.Templates
                .VerifyTitleTemplatesPage()
                .CreateNewTemplateWithBrokerSignUserMarketplaceAdmin();

            #endregion

            #region Postconditions

            Pages.Templates
                .DeleteItemFirstNameForMySpace();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(17)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Marketplace Admin role")]
        [AllureSubSuite("EditApplicationNineNineNineEightSaintJohnsonPlace")]

        public void EditApplicationNineNineNineEightSaintJohnsonPlace()
        {
            #region SettingsForBuilding

            //9998 Saint Johnson Place

            #endregion

            #region Test Data

            Broker broker = Broker.Generate();
            Building building = Building.Generate();

            #endregion

            #region Preconditions API create apartment

            var responseBroker = LogInApiBroker.ExecuteLogIn();
            LogInApiBroker.VerifyUserData(responseBroker, broker);
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentForAppNineNineNineEightSaintJohnsonPlaceActions();
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseBroker.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsMarketplaceAdminMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineNineNineEightSaintJohnsonPlace()
                .SelectNineNineNineEightSaintJohnsonPlace();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.SaintJohnsonPl.NumberNameAddressStaticForSearch)
                .ClickTabApartments();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithAgentBrokerSaintJohnsonPlace();

            KeyBoardActions.ScrollToDown();
            Pages.BuildingApartmentsTbl
                .ClickRowByDepositReceived();
            Pages.ApartmentView
                .VerifyTitleApartmentViewPage()
                .EnterRandomEmailGetApplicationLink();
            Pages.ApartmentView
                .ClickButtonGetLink();
            Pages.ApartmentView
                .ClickTabApplications();

            string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();

            KeyBoardActions.ScrollToDown();
            Pages.ApartmentApplicationsTbl
                .ClickFirstRow();
            Pages.ApplicationDetail
                .VerifyTitleApplicationDetailPage();

            #endregion

            #region Test

            var (window, mainApplicantPartEmail, occupantPartEmail, guarantorPartEmail,
                mainApplicantFullEmailFromEditApp, occupantFullEmailFromEditApp, guarantorFullEmailFromEditApp) =
                Pages.EditApplicationMdlWndw.EditApplicationNineNineNineEightSaintJohnsonPlace();
            //Main applicant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, mainApplicantPartEmail);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            //Pages.EmailPutsBox
            //    .VerifySubjectLetterCreateTenantViaGetLinkWithBrokerAsAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivatedWithDiv();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.LeasePriceAdjustmentMdlWndw
                .ClickSaveBtn();

            string applicationIdFromAppTenantMain = Pages.SubmittingApplication.GetApplicationIdVl();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, applicationIdFromAppTenantMain);
            Pages.HeaderTenants
                .LogOut();
            //Occupant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, occupantPartEmail);
            Pages.EmailPutsBox
            //    .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail)
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantOccupantMySpace();

            string applicationIdFromAppTenantOccupant = Pages.SubmittingApplication.GetApplicationIdVl();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantOccupant(applicationIdFromAppLandlord, applicationIdFromAppTenantOccupant);
            Pages.HeaderTenants
                .LogOut();
            //Guarantor
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, guarantorPartEmail);
            Pages.EmailPutsBox
                //.VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail)
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantGuarantorMySpace();

            string applicationIdFromAppTenantGuarantor = Pages.SubmittingApplication.GetApplicationIdVl();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantGuarantor(applicationIdFromAppLandlord, applicationIdFromAppTenantGuarantor);
            Pages.HeaderTenants
                .LogOut();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }  
    }
}