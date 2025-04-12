using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BrokersAgentsTable;
using CazamioNewProject.DbHelpers.OwnerCommissionsStructureTable;
using CazamioNewProject.DbHelpers.OwnerManagementsTable;
using CazamioNewProject.DbHelpers.OwnerPhoneNumbersTable;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace BrokerGuiTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : BrokerBase
    {
        //Amount order 9 next must be 10
        [Test]
        [Order(1)]
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
        [AllureSuite("Broker")]
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
                .VerifyTitle();

            WaitUntil.WaitSomeInterval(2000);

            #endregion
        }

        //[Test]
        //[AllureTag("Regression")]
        //[AllureOwner("Maksim Perevalov")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[Retry(2)]
        //[Author("Maksim", "maxqatesting390@gmail.com")]
        //[AllureSuite("Broker")]
        //[AllureSubSuite("CreateAgent")]

        //public void CreateAgent()
        //{
        //    #region Test Data

        //    int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

        //    #endregion

        //    #region Preconditions

        //    Pages.LogInLandlord
        //        .EnterEmailPasswordAsBroker()
        //        .ClickIconShow()
        //        .ClickButtonLetsGo();

        //    string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
        //    string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

        //    Pages.SidebarLandlord
        //        .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

        //    #endregion

        //    #region Test

        //    Pages.SidebarLandlord
        //         .ClickButtonAgents();
        //    Pages.ListOfAgents
        //        .ClickButtonCreateAgent();
        //    Pages.CreateNewAgentMdlWndw
        //        .EnterFirstLastNameEmailPhnNmbrCell()
        //        .EnterBrokerAgentCommission();

        //    string fullEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailFromMdlWndwCreateAgent();
        //    string partEmailPutsBox = Pages.CreateNewAgentMdlWndw.CopyEmailBeforeDogFromModalWindowCreateNewAgent();

        //    Pages.CreateNewAgentMdlWndw
        //        .ClickButtonSave()
        //        .VerifyMessageNewAgentCreatedSuccessfully();
        //    KeyBoardActions.ClickEscapeButton();
        //    Pages.AreYouSureLogOutLandlordMdlWndw
        //        .MakeLogOut();
        //    Pages.JScriptExecutor
        //        .OpenNewTab();
        //    Pages.EmailHelper
        //        .OpenPutsBox(Pages.EmailPutsBox.TitleLetterCreateAgentMySpace, partEmailPutsBox);
        //    Pages.EmailPutsBox
        //        .VerifyTitleLetterCreateAgent()
        //        .ClickButtonHtml();

        //    string getTextPasswordActual = Pages.EmailPutsBox.CopyPasswordFromEmailForCreateAdmin();

        //    Pages.EmailPutsBox
        //        .ClickButtonConfirmEmailForAdmin();

        //    Pages.LogInLandlord
        //        .PasteForEnterEmailFromEmailCreateAgent(fullEmailPutsBox)
        //        .PasteForEnterPsswrdFromEmailCreateAgent(getTextPasswordActual)
        //        .ClickIconShow()
        //        .ClickButtonLetsGo();

        //    string getUserNameRoleCompareAgent = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

        //    Pages.SidebarLandlord
        //       .VerifyAgentUserNameAndRoleCreating(getUserNameRoleCompareAgent);

        //    #endregion

        //    #region Postconditions

        //    WaitUntil.WaitSomeInterval(100);
        //    AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(fullEmailPutsBox, marketplaceId);
        //    Console.WriteLine($"{fullEmailPutsBox}");
        //    WaitUntil.WaitSomeInterval(100);
        //    BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(fullEmailPutsBox, marketplaceId);
        //    WaitUntil.WaitSomeInterval(100);
        //    AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(fullEmailPutsBox, marketplaceId);

        //    #endregion
        //}

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
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

            #endregion

            #region Postconditions

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(getOwnerEmailFromModalWndw, marketplaceId);

            #endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuildingAssignedBroker")]
        public void AddBuildingAssignedBroker()
        {
            #region SettingsForBuilding

            //Crown St

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();

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

            #endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddBuildingAssignedAgent")]

        public void AddBuildingAssignedAgent()
        {
            #region SettingsForBuilding

            //Albermale Rd

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();

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

            #endregion

        }

        [Test]
        [Order(6)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddApartmentAssignedBroker")]

        public void AddApartmentAssignedBroker()
        {
            #region SettingsForBuilding

            //30-39Crown St

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
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

            WaitUntil.WaitSomeInterval(5000);

            #endregion

        }

        [Test]
        [Order(7)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("AddApartmentAssignedAgent")]

        public void AddApartmentAssignedAgent()
        {
            #region SettingsForBuilding

            //9A Albermale Rd

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();

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

            WaitUntil.WaitSomeInterval(5000);

            #endregion

        }

        [Test]
        [Order(8)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("CreateApplicationForApartmentOccupied")]

        public void CreateApplicationForApartmentOccupied()
        {
            #region SettingsForBuilding

            //9A Albermale Rd

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchNineAAlbermaleRd()
                .SelectItemNineAAlbermaleRd();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.NineAAAlbermaleRd)
                .UpdateValueCreditScreeningFee()
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
                application.BasicData.NotAssignetLabel, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                application.Buttons.Close, closeNameBtnFromApp);
            //Main applicant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, partEmailPutsBoxMainApplicant);

            string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectLetterCreateTenantViaGetLink();

            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowlForTenant();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseChangeYourPasswordMdlWndw
                .QuicklyPass();
            Pages.PleaseTellUsYourNameMdlWndw
                .QuicklyPassForMainApplicant();
            Pages.LeasePriceAdjustmentMdlWndw
                .ClickBtnCancel();
            Pages.HeaderTenants
                .LogOut();
            //Occupant
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, partEmailPutsBoxOccupant);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowlForTenantSecond();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();

            Pages.PleaseChangeYourPasswordMdlWndw
                .QuicklyPass();
            Pages.PleaseTellUsYourNameMdlWndw
                .QuicklyPassForOccupant();
            Pages.HeaderTenants
                .LogOut();
            //Guarantor
            Pages.JScriptExecutor
               .OpenNewTab();
            Pages.EmailHelper
               .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, partEmailPutsBoxGuarantor);
            Pages.EmailPutsBox
                .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            Pages.EmailPutsBox
                .ClickButtonHtml()
                .ClickButtonStartYourApplicationNowlForTenantThird();
            Pages.ToasterMessagesTenants
                .VerifyMessageAccountWasSuccessfullyActivated();
            Pages.PleaseChangeYourPasswordMdlWndw
                .QuicklyPass();
            Pages.PleaseTellUsYourNameMdlWndw
                .QuicklyPassForGuarantor();
            Pages.HeaderTenants
                .LogOut();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(9)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("CreateApplicationForApartmentApplicationSubmitted")]

        public void CreateApplicationForApartmentApplicationSubmitted()
        {
            #region SettingsForBuilding

            //30-39Crown St

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            Agent agent = Agent.Generate();

            #endregion

            #region Test Data API

            Broker broker = Broker.Generate();
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentApplicationSubmitted();

            #endregion

            #region Preconditions API

            var responseBroker = LogInApiBroker.ExecuteLogIn();
            LogInApiBroker.VerifyUserData(responseBroker, broker);
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseBroker.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchThirtyDashThirtyNineCrownSt()
                .SelectThirtyDashThirtyNineCrownSt();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.ThirtyDashTrirtyNineCrownSt)
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
                .VerifyCopiedTheLinkToApplication()
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
                agent.CreatedAgentLulaMySpace.FullName, agentFromApp,
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

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(10)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
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
                .CreateNewTemplateWithBrokerSignUserMarketplaceAdmin();

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker")]
        [AllureSubSuite("DemoAddApartment")]

        public void DemoLogIn()
        {
            #region SettingsForBuilding

            //Saint Johnson Place

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            Building building = Building.Generate();
            ApartmentApplicationsTable apartmentApplicationsTable = ApartmentApplicationsTable.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsBrokerMySpace();
            //Pages.SidebarLandlord
            //    .ClickButtonBuildings();
            //Pages.ListOfBuildings
            //    .SearchNineNineNineEightSaintJohnsonPlace();
            //Pages.ListOfBuildings
            //    .SelectItemFirst();
            //Pages.BuildingView
            //    .VerifyTitleBuildingViewPage();

            //string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            //string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            //Pages.BuildingView
            //    .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.NineNineNineEightSaintJohnsonPlace)
            //    .ClickTabApartments();
            //KeyBoardActions.ScrollToDown();
            //Pages.BuildingApartmentsTbl
            //    .ClickRowByDepositReceived();

            #endregion

            //#region Test

            //Pages.ApartmentView
            //    .VerifyTitleApartmentViewPage();

            //string getUnitNumber = Pages.ApartmentView.GetSubjectExpected();

            //Pages.ApartmentView
            //    .EnterNewEmailFirstLastNames();

            //#endregion

            //WaitUntil.WaitSomeInterval(1000);
        }
    }
}