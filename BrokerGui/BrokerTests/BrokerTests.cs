using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;
using CazamioNewProject.CreateApartmentMandatoryDataApi;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
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
        //Amount order 13 next must be 14
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();

            #endregion
        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                 .LogInAsBrokerMySpace();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImageUserOfBroker()
                .ClickingAllTabsOfBroker();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            //#region Preconditions

            //Pages.LogInLandlord
            //    .EnterEmailPasswordAsBroker()
            //    .ClickIconShow()
            //    .ClickButtonLetsGo();

            //string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            //string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            //Pages.SidebarLandlord
            //    .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            //#endregion

            //#region Test

            //Pages.SidebarLandlord
            //     .ClickButtonAgents();
            //Pages.ListOfAgents
            //    .ClickButtonCreateAgent();
            //Pages.CreateNewAgentMdlWndw
            //    .EnterFirstLastNameEmailPhnNmbrCell()
            //    .EnterBrokerAgentCommission();

            //string fullEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailFromMdlWndwCreateAgent();
            //string partEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailBeforeDogFromModalWindowCreateNewAgent();

            //Pages.CreateNewAgentMdlWndw
            //    .ClickButtonSave()
            //    .VerifyMessageNewAgentCreatedSuccessfully();
            //KeyBoardActions.ClickEscapeButton();
            //Pages.AreYouSureLogOutLandlordMdlWndw
            //    .MakeLogOut();
            //Pages.JScriptExecutor
            //    .OpenNewTab();
            //Pages.EmailHelper
            //    .OpenPutsBox(Pages.EmailPutsBox.TitleLetterCreateAgentMySpace, partEmailPutsBox);
            //Pages.EmailPutsBox
            //    .VerifyTitleLetterCreateAgent()
            //    .ClickButtonHtml();

            //string getTextPasswordActual = Pages.EmailPutsBox.CopyPasswordFromEmailForCreateAdmin();

            //Pages.EmailPutsBox
            //    .ClickButtonConfirmEmailForAdmin();

            //Pages.LogInLandlord
            //    .PasteForEnterEmailFromEmailCreateAgent(fullEmailPutsBox)
            //    .PasteForEnterPsswrdFromEmailCreateAgent(getTextPasswordActual)
            //    .ClickIconShow()
            //    .ClickButtonLetsGo();

            //string getUserNameRoleCompareAgent = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            //Pages.SidebarLandlord
            //   .VerifyAgentUserNameAndRoleCreating(getUserNameRoleCompareAgent);

            //#endregion

            //#region Postconditions

            //WaitUntil.WaitSomeInterval(100);
            //AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
            //Console.WriteLine($"{fullEmailPutsBox}");
            //WaitUntil.WaitSomeInterval(100);
            //BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(fullEmailPutsBox, marketplaceId);
            //WaitUntil.WaitSomeInterval(100);
            //AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(fullEmailPutsBox, marketplaceId);

            //#endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("CreateOwnerWithAssignedBroker")]

        public void CreateOwnerWithAssignedBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();

            #endregion

            #region Test

            Pages.SidebarLandlord
               .ClickButtonOwners();
            Pages.ListOfOwners
                .ClickButtonCreateOwner();
            Pages.CreateANewOwnerMdlWndw
                .VerifyTitleCreateANewOwner()
                .EnterCompanyNameBrokerMaxSymbols()
                .EnterOwnerFirstName()
                .EnterOwnerEmaiLXitroo()
                .EnterOfficeLocationDallas()
                .EnterInternalNotesShort()
                .ClickButtonAddPhoneNumber()
                .EnterPhoneNumber()
                .ClickButtonAddCommissionStructure();
            KeyBoardActions.ScrollToDown();
            Pages.CreateANewOwnerMdlWndw
                .ClickButtonAddMgmt()
                .SelectItemTenantPays()
                .EnterDataTenantPaysMax()
                .ScrollDown()
                .EnterMandatoryDataMgmt();

            string getOwnerEmailFromModalWndw = Pages.CreateANewOwnerMdlWndw.GetEmailFromFieldOwnerEmail();

            Pages.CreateANewOwnerMdlWndw
                .ClickButtonCreate();
            Pages.ListOfOwners
                .VerifyMessageSuccessCreatedOwner();

            string getLastEmailFromPage = Pages.ListOfOwners.GetFirstEmailFromTable();

            Pages.ListOfOwners
                .VerifyEmailForNewOwner(getOwnerEmailFromModalWndw, getLastEmailFromPage);

            WaitUntil.WaitSomeInterval(1000);

            #endregion

            #region Postconditions

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("AddGroupBuildingsViaApiBasicStatic")]

        public void AddGroupBuildingsViaApiBasicStatic()
        {

            #region SettingsForBuilding

            //9A Albermale Rd
            //30-39 Crown St
            //12567 Dean Street

            #endregion

            #region Test Data

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Preconditions API LogIn as Marketplace Admin

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Preconditions API create the 9A Albermale Rd building

            var buildingRequestBodyAlbermaleRd = BuildingCreationMandatoryData.RequestBodyCreateBuildingNineAAlbermaleRd();
            var responseBuildingAlbermaleRd = BuildingCreationMandatoryData.CreateBuildingNineAAlbermaleRd(responseMarketplaceAdmin.AuthData.Token, buildingRequestBodyAlbermaleRd);

            #endregion

            #region Preconditions API create the 30-39 Crown St building

            var buildingRequestBodyCrownSt = BuildingCreationMandatoryData.RequestBodyCreateBuildingThirtyDashTrirtyNineCrownSt();
            var responseBuildingCrownSt = BuildingCreationMandatoryData.CreateBuildingThirtyDashTrirtyNineCrownSt(responseMarketplaceAdmin.AuthData.Token, buildingRequestBodyCrownSt);

            #endregion

            #region Preconditions API create the 12567 Dean Street building

            var buildingRequestBody = BuildingCreationMandatoryData.RequestBodyCreateBuildingOneTwoFiveSixSevenDeanStreet();
            var responseBuilding = BuildingCreationMandatoryData.CreateBuildingOneTwoFiveSixSevenDeanStreet(responseMarketplaceAdmin.AuthData.Token, buildingRequestBody);

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(6)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("AddBuildingAssignedBroker")]
        public void AddBuildingAssignedBroker()
        {
            #region SettingsForBuilding

            //Crown St

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerOwnerPaysBroker()
                .EnterBuildingDataCrownSt()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee);
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
                .VerifyBuildingAddress(getAddressNewBuildingActual, getAddressBuildingView)
                .ClickTabApartments()
                .ClickButtonAddInTabApartments();
            Pages.AddApartments
                .EnterMandatoryFieldsThirtyDashThirtyNineCrownSt()
                .ClickButtonPaymentMethods();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodsDlvrChckZllVnm();
            Pages.AddApartments
                .ClickTabImages()
                .ClickButtonSelectVideo()
                .UplodImagesFileEnterLinksYouTubeVimeo()
                .ClickButtonSaveApartment();
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(7)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("AddBuildingAssignedAgent")]

        public void AddBuildingAssignedAgent()
        {
            #region SettingsForBuilding

            //Albermale Rd

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerTenantPaysCommissionAgent()
                .EnterBuildingDataAlbermaleRd();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            Pages.NewBuilding
                .EnterShortInternalNotesDescription();
            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();
         
            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .EnterCreditScreeningFeeHoldDeposit()
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectPaymentMethodsDlvrChckZllVnm();
            Pages.NewBuilding
                .ClickBtnSelectPaymentMethodsForHoldDeposit();
            Pages.PaymentOptionsMdlWndw
                .VerifyTitlePaymentOptions()
                .SelectPaymentMethodsDlvrChckZllVnm();
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
        [Order(8)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("AddApartmentAssignedBroker")]

        public void AddApartmentAssignedBroker()
        {
            #region SettingsForBuilding

            //30-39Crown St

            #endregion

            #region Test data

            Broker broker = Broker.Generate();

            #endregion

            #region Preconditions API Login as broker

            var responseBroker = LogInApiBroker.ExecuteLogIn();
            LogInApiBroker.VerifyUserData(responseBroker, broker);

            #endregion

            #region Preconditions API create an apartment

            var requestBodyApartment = ApartmentCreation.RequestBodyCreateApartmentWithImagesVideos();
            ApartmentCreation.CreateApartmentApplicationSubmitted(responseBroker.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchThirtyDashThirtyNineCrownSt()
                .SelectThirtyDashThirtyNineCrownSt();
            KeyBoardActions.ScrollToDown();
            WaitUntil.WaitSomeInterval(2000);
            Pages.BuildingView
                .ClickTabApartments()
                .ClickButtonClone();

            #endregion

            #region Test

            Pages.AddApartments
                .VerifyTitleAddApartmentsPage()
                .SelectBuildingThirtyDashTrirtyNineCrownSt()
                .EnterToAllFieldsThirtyDashThirtyNineCrownSt()
                //.SelectCurrentDateAvailableFrom()
                .SelectStatusApplicationSubmitted()
                .SelectAgent()
                .SelectApartmentTypePlex();
            JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .EnterHoldDepositOneThousand();
            Pages.AddApartments
                .ClickTabImages()
                .ClickEightTimesButtonRemove()
                .ClickButtonSelectVideo()
                .UplodImagesFileEnterLinksYouTubeVimeo()
                .ClickButtonSaveApartment();
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
               .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(1000);

            #endregion

        }

        [Test]
        [Order(9)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("AddApartmentAssignedAgent")]

        public void AddApartmentAssignedAgent()
        {
            #region SettingsForBuilding

            //9A Albermale Rd

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();

            #endregion

            #region Test

            Pages.ListOfApartments
                .ClickButtonAdd();
            Pages.AddApartments
                .SelectBuildingNineAAlbermaleRoad()
                .EnterDataInFieldsNineAAlbermaleRoad()
                .SelectStatusOccupied()
                .SetFirstDayNextMonthsAvailableFrom()
                .SelectApartmentTypeDuplex();
            JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .EnterHoldDepositThreeNumbers()
                .ClickButtonPaymentMethods();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodAch();
            Pages.AddApartments
                .EnterTenMonthsRentalTerms()
                .AddItemSocialSecurityCardRequiredDoc()
                .EnterShortDescriptionInternalNotes()
                .ClickButtonGeneralNext()
                .SelectFourtyFourAmenities()
                .SelectThreeAmenitiesIncludedInMonthlyRent();
            JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .ClickButtonGeneralNext()
                .ClickButtonAddLock()
                .AddItemAccessTypePinCodeWithoutImage()
                .ClickButtonAddLock()
                .AddItemAccessTypeNoteWithoutImage()
                .ClickTwiceButtonGeneralNext()
                .ClickButtonSelectVideo()
                .UplodFileVideoEnterLinksYouTubeVimeo()
                .ClickButtonSaveApartment();
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
               .VerifyTitleListOfApartments();

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
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("CreateApplicationForApartmentOccupied")]

        public void CreateApplicationForApartmentOccupied()
        {
            #region SettingsForBuilding

            //9A Albermale Rd

            #endregion

            #region Test data

            Broker broker = Broker.Generate();
            Building building = Building.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchNineAAlbermaleRd()
                .SelectItemNineAAlbermaleRd();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.AlbermaleRd.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentAlbermaleRd();

            Pages.BuildingApartmentsTbl
                .ClickRowByOccupied();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage();
            Pages.ApartmentView
                .ClickButtonPlusApplication();
            Pages.CreateApplicationMdlWndw
                .VerifyTitleCreateApplication()
                .PassFirstStepRandomEmail();

            string partEmailPutsBoxMainApplicant = Pages.CreateApplicationMdlWndw.CopyEmailBeforeDogFromFieldGetApplicationLink();

            Pages.CreateApplicationMdlWndw
                .PassThirdStepAddressNineAAlbermaleRd()
                .VerifyTitleApplicationSuccessfullyCreated()
                .VerifyTextLinkAlreadyCopied()
                .ClickButtonAddApplicant();
            Pages.AddApplicantMdlWndw
                .AddOneNewlyCreatedOccupantGuarantor();

            string partEmailPutsBoxOccupant = Pages.AddApplicantMdlWndw.CopyEmailBeforeDogFromFirstFieldInputEmailAddress();
            string partEmailPutsBoxGuarantor = Pages.AddApplicantMdlWndw.CopyEmailBeforeDogFromSecondFieldInputEmailAddress();

            Pages.AddApplicantMdlWndw
                 .ClickBtnAdd();
            Pages.ApartmentView
                .ClickTabApplications();

            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string firstNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetFirstNameTenantMainApplicantFromFirstRow();
            string lastNameTenantMainApplicantFromApp = Pages.ApartmentApplicationsTbl.GetLastNameTenantMainApplicantFromFirstRow();
            string firstLastNameOccupantFromApp = Pages.ApartmentApplicationsTbl.GetFirstLastNameTenantOccupantFromFirstRow();
            string leasePriceFromApp = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApp = Pages.ApartmentApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusFrstRw().Text;
            string closeNameBtnFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnCloseBtnFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyFullDataByApplicationTenantsMainOccupant
                (getAddressBuildingViewActual, apartmentAddressFromApp, 
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantFirstNameTenant, firstNameTenantMainApplicantFromApp, 
                tenantCreatorMySpace.FirstLastNameGeneralData.ConstantLastNameTenant, lastNameTenantMainApplicantFromApp, 
                tenantOccupantMySpace.FirstLastNameGeneralData.ConstantFirstLastNameTenant, firstLastNameOccupantFromApp,
                application.LeasePrice.FifthPriceStatic, leasePriceFromApp,
                broker.CreatedBrokerMySpace.FullName, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                application.Buttons.Close, closeNameBtnFromApp);
            //Main applicant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBoxMainApplicant);

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
            Pages.HeaderTenants
                .LogOut();
            //Occupant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBoxOccupant);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantOccupantMySpace();
            Pages.HeaderTenants
                .LogOut();
            //Guarantor
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBoxGuarantor);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantGuarantorMySpace();
            Pages.HeaderTenants
                .LogOut();

            #endregion

            #region Postconditions

            Pages.SwitchingBetweenBrowserTabsActions
                .CloseSecondThirdFourthTabs();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(11)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("CreateApplicationForApartmentApplicationSubmitted")]

        public void CreateApplicationForApartmentApplicationSubmitted()
        {
            #region SettingsForBuilding

            //30-39Crown St

            #endregion

            #region Test data

            Broker broker = Broker.Generate();
            Building building = Building.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();

            #endregion

            #region Preconditions API Login as broker

            var responseBroker = LogInApiBroker.ExecuteLogIn();
            LogInApiBroker.VerifyUserData(responseBroker, broker);

            #endregion

            #region Preconditions API create an apartment

            var requestBodyApartment = ApartmentCreation.RequestBodyCreateApartmentApplicationSubmitted();
            ApartmentCreation.CreateApartmentApplicationSubmitted(responseBroker.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchThirtyDashThirtyNineCrownSt()
                .SelectThirtyDashThirtyNineCrownSt();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.CrownSt.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentAlbermaleRd();

            Pages.BuildingApartmentsTbl
                .ClickRowByApplicationSubmitted();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage()
                .EnterExistEmailWithCreditReporGetApplicationLink();

            string leasePriceFromUnit = Pages.ApartmentView.GetLeasePriceValueOfString();

            Pages.ApartmentView
                .ClickButtonGetLink()
                .ClickTabApplications();
            KeyBoardActions.ScrollToDown();

            string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();
            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string fullNameTenantMainApplicantFromAppAr = Pages.ApartmentApplicationsTbl.GetFullNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApp = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApp = Pages.ApartmentApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusFrstRw().Text;
            string closeNameBtnFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnCloseBtnFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyFullDataByApplicationCreatedTenantMain
                (getAddressBuildingViewActual, apartmentAddressFromApp, 
                tenantCreatorMySpace.CreatedWithCreditReport.ConstantFirstLastName, fullNameTenantMainApplicantFromAppAr, 
                leasePriceFromUnit, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                broker.CreatedBrokerMySpace.FullName, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, closeNameBtnFromApp);
            Pages.JScriptExecutor
              .OpenNewTabHomePageTenant();
            Pages.LogInTenant
                .LogInAsCreatorWithCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string applicationIdFromAppTenant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, applicationIdFromAppTenant);

            #endregion

            #region Postconditions

            Pages.SwitchingBetweenBrowserTabsActions
                .CloseSecondTabAndSelectFirstTab();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [Order(12)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("CreateNewDocumentLeaseSignTemplateWithFullSettings")]

        public void CreateNewDocumentLeaseSignTemplateWithFullSettings()
        {
            #region Preconditions

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
               .ClickButtonLeaseSignDocuments();

            #endregion

            #region Test

            Pages.Templates
                .VerifyTitleTemplatesPage()
                .CreateNewTemplateWithFullSettingsUserBroker();

            WaitUntil.WaitSomeInterval(1000);

            #endregion

            #region Postconditions

            Pages.Templates
                .DeleteItemSecondNameForMySpace();

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(13)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("EditFirstApplicationOneTwoFiveSixSevenDeanStreet")]

        public void EditFirstApplicationOneTwoFiveSixSevenDeanStreet()
        {
            #region SettingsForBuilding

            //12567 Dean Street

            #endregion

            #region Test Data

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            Building building = Building.Generate();

            #endregion

            #region Preconditions API LogIn as MarketplaceAdmin

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Preconditions API create apartment

            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentForAppOneTwoFiveSixSevenDeanStreet();
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions API create application

            var requestBodyapplication = CazamioNewProject.CreateApplicationApi.ApplicationCreation.RequestBodyCreateFirstAppForOneTwoFiveSixSevenDeanStreet();
            CazamioNewProject.CreateApplicationApi.ApplicationCreation.CreateFirstAppForOneTwoFiveSixSevenDeanStreet(responseMarketplaceAdmin.AuthData.Token, requestBodyapplication);

            #endregion

            #region Preconditions API Add applicants to application

            var requestBodyAddApplicants = CazamioNewProject.AddApplicantsApi.AddApplicants.RequestBodyAddOccupantGuarantorAppForOneTwoFiveSixSevenDeanStreet();
            CazamioNewProject.AddApplicantsApi.AddApplicants.AddOccupantGuarantorAppForOneTwoFiveSixSevenDeanStreet(responseMarketplaceAdmin.AuthData.Token, requestBodyAddApplicants);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchOneTwoFiveSixSevenDeanStreet()
                .SelectOneTwoFiveSixSevenDeanStreet();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.DeanStreet.NumberNameAddressStaticForSearch)
                .ClickTabApartments();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentDeanStreet();

            KeyBoardActions.ScrollToDown();
            Pages.BuildingApartmentsTbl
                .ClickRowByVacant();
            Pages.ApartmentView
                .VerifyTitleApartmentViewPage();
            Pages.ApartmentView
                .ClickTabApplications();
            KeyBoardActions.ScrollToDown();

            string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();

            Pages.ApartmentApplicationsTbl
                .ClickFirstRow();
            Pages.ApplicationDetail
                .VerifyTitleApplicationDetailPage();

            #endregion

            #region Test

            var (window, mainApplicantNewlyCreatedPartEmailOld, occupantPartEmailOld, guarantorPartEmailOld) =
            Pages.EditApplicationMdlWndw.EditFirstApplicationOneTwoFiveSixSevenDeanStreet();
            //Main applicant newly created who has been deleted from the application
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, mainApplicantNewlyCreatedPartEmailOld);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.MyAccount
                .VerifyYouHaveNoApplicationsYetRecord();
            Pages.HeaderTenants
                .LogOut();
            //Main applicant already created who has been added to the application
            Pages.LogInTenant
                .LogInAsCreatorWithoutCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string applicationIdFromAppTenant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, applicationIdFromAppTenant);
            Pages.HeaderTenants
                .LogOut();
            //Occupant newly created who has been deleted from the application
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, occupantPartEmailOld);

            string getSubjectFromEmailOccupant = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmailOccupant);
            Pages.EmailPutsBox
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.MyAccount
                .VerifyYouHaveNoApplicationsYetRecord();
            Pages.HeaderTenants
                .LogOut();
            //Guarantor newly created who has been deleted from the application
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, guarantorPartEmailOld);

            string getSubjectFromEmailGuarantor = Pages.EmailPutsBox.GetSubjectNotificationCommon();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmailGuarantor);
            Pages.EmailPutsBox
                .ClickButtonHtml();
            Pages.SwitchingBetweenBrowserTabsActions
                .SecondTabCloseThreeTimes();
            Pages.EmailPutsBox
                .ClickButtonStartYourApplicationNowForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
                .QuicklyPassTenantCreatorMySpace();
            Pages.MyAccount
                .VerifyYouHaveNoApplicationsYetRecord();
            Pages.HeaderTenants
                .LogOut();

            WaitUntil.WaitSomeInterval(1000);

            #endregion

            #region Postconditions

            Pages.SwitchingBetweenBrowserTabsActions
                .CloseSecondThirdFourthTabs();

            WaitUntil.WaitSomeInterval(100);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Positive critical scenarios for Broker role")]
        [AllureSubSuite("DemoAddApartment")]

        // Data Generation and Advanced Filtering Validation
        public void DemoVerifySearchAndFilteringByListOfApartmentsQuickEditMode()
        {
            #region SettingsForBuilding



            #endregion

            #region Test data



            #endregion

            #region Preconditions Test

            // Create a new Building via API 1 -2 seconds
            // Create apartment with agent via API 1 -2 seconds

            // Login via GUI
            // Open "List of apartemnts" page in the "Quick edit" mode via GUI

            #endregion

            #region Test

            // By default checked the box "Most recently updated"

            // Filter by Price
            // Filter by Fee
            // Filter by Availability
            // Filter by Status
            // Filter by Beds
            // Filter by Baths
            // Filter by Owners
            // Filter by Assigned Agent
            // Filter by Neighborhoods
            // Filter by Building Amenities
            // Filter by Apartment Amenities
            // Filter by Pet Policies
            // Verify AR with ER

            #endregion

            #region Postconditions

            // Delete building
            // Postconditions → очистка данных должна быть вынесена в finally, чтобы выполнялась всегда.

            #endregion
        }
    }
}