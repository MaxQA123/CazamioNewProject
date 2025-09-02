using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AgentBrokerGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : AgentBrokerBase
    {
        //Amount order 8 next must be 9
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();

            #endregion

        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
                 .LogInAsAgentBrokerMySpace();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImageUserOfAgentBroker()
                .ClickingAllTabsOfAgentBroker();
            Pages.AreYouSureLogOutLandlordMdlWndw
                .MakeLogOut();
            Pages.LogInLandlord
                .VerifyTitleLogInPg();

            #endregion
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("AddGroupBuildingsViaApiBasicStatic")]

        public void AddGroupBuildingsViaApiBasicStatic()
        {

            //#region SettingsForBuilding

            ////111A East 51st Street Pedestrian Crossing

            //#endregion

            //#region Test Data

            //MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            //#endregion

            //#region Preconditions API LogIn as Marketplace Admin

            //var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            //LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            //#endregion

            //#region Preconditions API create the 111A East 51st Street Pedestrian Crossing building

            //var buildingRequestBodyEastStPedestrianCrossing = BuildingCreationMandatoryData.RequestBodyCreateBuildingOneOneOneAEastStPedestrianCrossing();
            //var responseBuildingEastStPedestrianCrossing = BuildingCreationMandatoryData.CreateBuildingOneOneOneAEastStPedestrianCrossing(responseMarketplaceAdmin.AuthData.Token, buildingRequestBodyEastStPedestrianCrossing);

            //WaitUntil.WaitSomeInterval(1000);

            //#endregion

        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("AddBuildingAssignedAgentBroker")]

        public void AddBuildingAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //East 51st Street Pedestrian Crossing

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();

            #endregion

            #region Test

            Pages.ListOfBuildings
                .ClickButtonAddBuilding();
            Pages.NewBuilding
                .VerifyTitleNewBuildingPg()
                .SelectOwnerTenantPaysCommissionAgent()
                .EnterBuildingDataEast51stStreetPedestrianCrossing()
                .ClickFieldInputInternalNotes();

            string getAddressNewBuildingActual = Pages.NewBuilding.GetValueFromFieldAddress();

            KeyBoardActions.ClickTab();

            string getValueScreeningFee = Pages.NewBuilding.GetValueFromFieldCreditScreeningFee();

            Pages.NewBuilding
                .VerifyValueByDefaulScreeningFee(getValueScreeningFee)
                .ClickBtnSelectPaymentMethodsForCreditScreeningFee();
            Pages.PaymentOptionsMdlWndw
                .SelectPaymentMethodAch();
            Pages.NewBuilding
                .ClickThreeTimesButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffInActive()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActiveWithoutName()
                //Add get value
                .ClickTabConcessions()
                .ClickButtonAddSpecials()
                .AddConcessionInActive()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                //Add get value
                //Add Assertions
                .ClickButtonGeneralNext()
                .UploadOneImages()
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
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("AddApartmentAssignedAgentBroker")]

        public void AddApartmentAssignedAgentBroker()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Building building = Building.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .EnterDataForOneOneOneAEastStPedestrianCrossing()
                .SelectStatusOffMarket()
                .SelectApartmentTypeLoft();
            Pages.AddApartments
                .ClickTabAmenities()
                .SelectThreeAmenitiesIncludedInMonthlyRent()
                .ClickTabAccess()
                .ClickButtonAddLock()
                .AddItemAccessTypeNote()
                .ClickTabSpecials()
                .ClickButtonAddSpecials()
                .AddConcessionIsActiveWithoutName()
                .ClickTabImages()
                .UploadFiveImages();
            Pages.AddApartments
                .ClickButtonSelectVideo()
                .UploadOneFileVideo()
                .ClickButtonSaveApartment();
            Pages.ToasterMessagesLandlord
                .VerifyMessageApartmentsWereSavedSuccessfully();
            Pages.ListOfApartments
               .VerifyTitleListOfApartments();

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(6)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("AddApartmentAssignedAgBr")]

        public void AddApartmentAssignedAgBr()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Building building = Building.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();
            Pages.BuildingView
                .ClickButtonAddInTabApartments();

            #endregion

            #region Test

            Pages.AddApartments
                .EnterFullDataForOneOneOneAEastStPedestrianCrossing()
                .SelectStatusSignedLease()
                .SelectCurrentDatePlusOneDayAvailableFrom()
                .SelectAgent()
                .SelectApartmentTypeLoft();
            JScriptExecutor.ScrollToDownWebPage();
            Pages.AddApartments
                .ClickButtonSetFromBuilding()
                .SetSomeItemsRentalTerms()
                .EnterShortDescriptionInternalNotes()
                .ClickTwiceButtonGeneralNext()
                .ClickButtonAddLock()
                .AddItemAccessTypePinCode()
                .ClickButtonGeneralNext()
                .ClickTabFreeStuff()
                .ClickButtonAddSpecials()
                .AddFreeStuffIsActiveWithoutName()
                .ClickButtonGeneralNext()
                .ClickButtonSelectVideo()
                .SetLinksYouTubeVimeo()
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
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("CreateApplicationForApartmentOffMarket")]

        public void CreateApplicationForApartmentOffMarket()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            AgentBroker agentBroker = AgentBroker.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            

            #endregion

            #region Preconditions API create apartment

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentOffMarketStatus();
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();

            #endregion

            #region Test

            Pages.CreateApplicationMdlWndw
                .PassFirstStepCreatorWithCreditReportMySpace()
                .PassSecondStepOneOneOneAEastStPedestrianCrossingAddress();

            string getEmailAr = Pages.CreateApplicationMdlWndw.GetFullEmail();

            Pages.CreateApplicationMdlWndw
                .VerifyEmailTenantCreatorWithCreditReport(getEmailAr)
                .PassThirdStepOneOneOneAEastStPedestrianCrossingAddress()
                .VerifyTitleApplicationSuccessfullyCreated()
                .VerifyTextLinkAlreadyCopied()
                .ClickButtonAddApplicant();
            Pages.AddApplicantMdlWndw
                .AddOneAlreadyExistOccupantWithCreditReport()
                .ClickBtnAdd();

            string applicationIdFromAppLandlord = Pages.ListOfApplicationsApplicationsTbl.GetApplicationIdFromFirstRow();
            string fullNameTenantMainApplicantFromAppAr = Pages.ListOfApplicationsApplicationsTbl.GetFullNameTenantMainApplicantFromFirstRow();
            string fullNameTenantOccupantFromAppAr = Pages.ListOfApplicationsApplicationsTbl.GetFullNameTenantOccupantFromFirstRow();
            string leasePriceFromApp = Pages.ListOfApplicationsApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ListOfApplicationsApplicationsTbl.GetDateCreatedFromFirstRow();
            string agentFromApp = Pages.ListOfApplicationsApplicationsTbl.GetAgentFromFrstRw();
            string statusFromApp = Pages.ListOfApplicationsApplicationsTbl.GetVlLabelOfClmnDraftStatusFrstRw().Text;
            string btnNameFromApp = Pages.ListOfApplicationsApplicationsTbl.GetVlLabelOfClmnCloseBtnFrstRw().Text;

            Pages.ListOfApplicationsApplicationsTbl
                .VerifyFullDataByApplicationTenantsMainOccupant
                (tenantCreatorMySpace.CreatedWithCreditReport.ConstantFirstLastName, fullNameTenantMainApplicantFromAppAr,
                tenantOccupantMySpace.CreatedWithCreditReport.ConstantFirstLastName, fullNameTenantOccupantFromAppAr,
                application.LeasePrice.FirstPriceStatic, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                agentBroker.CreatedAgentMySpace.FullName, agentFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, btnNameFromApp);

            Pages.JScriptExecutor
              .OpenNewTabHomePageTenant();
            Pages.LogInTenant
                .LogInAsCreatorWithCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string appIdFromAppTenantCreator = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, appIdFromAppTenantCreator);
            Pages.HeaderTenants
                .LogOut();
            Pages.LogInTenant
                .LogInAsOccupantWithCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string appIdFromAppTenantOccupant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantOccupant(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);

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
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("CreateApplicationForApartmentSignedLease")]

        public void CreateApplicationForApartmentSignedLease()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Building building = Building.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Preconditions API

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();
            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentSignedLeaseStatus();
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions GUI

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.ListOfApartments
                .WaitFirstRowInListOfApartments();
            Pages.SidebarLandlord
               .ClickButtonBuildings();
            Pages.ListOfBuildings
                .WaitItemFirstBuildingOnPage()
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentAlbermaleRd();

            Pages.BuildingApartmentsTbl
                .ClickRowBySignedLease();

            #endregion

            #region Test

            Pages.ApartmentView
                .VerifyTitleApartmentViewPage()
                .EnterExistEmailWithoutCreditReporGetApplicationLink();

            string leasePriceFromUnit = Pages.ApartmentView.GetLeasePriceValueOfString();

            Pages.ApartmentView
                .ClickButtonGetLink()
                .ClickTabApplications();
            KeyBoardActions.ScrollToDown();

            string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();
            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string fullNameTenantMainApplicantFromAppAr = Pages.ApartmentApplicationsTbl.GetFullNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApplication = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApplication = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string statusFromApplication = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusWithoutAgentFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyDataWitoutAgentByApplicationCreatedTenantMain
                (getAddressBuildingViewActual, apartmentAddressFromApp,
                tenantCreatorMySpace.CreatedWithoutCreditReport.ConstantFirstLastName, fullNameTenantMainApplicantFromAppAr,
                leasePriceFromUnit, leasePriceFromApplication,
                application.BasicData.DateCurrent, dateCreatedFromApplication,
                application.Statuses.Draft, statusFromApplication);
            Pages.JScriptExecutor
              .OpenNewTabHomePageTenant();
            Pages.LogInTenant
                .LogInAsCreatorWithoutCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string applicationIdFromAppTenant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, applicationIdFromAppTenant);

            WaitUntil.WaitSomeInterval(1000);

            #endregion
        }

        [Test]
        [Order(9)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent-Broker")]
        [AllureSubSuite("EditFirstApplicationOneTwoFiveSixSevenDeanStreet")]

        public void EditFirstApplicationOneTwoFiveSixSevenDeanStreet()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

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

            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentOffMarketStatus();
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions API create application

            var requestBodyapplication = CazamioNewProject.CreateApplicationApi.ApplicationCreation.RequestBodyCreateFirstAppForOneOneOneAEastStPerestrian();
            CazamioNewProject.CreateApplicationApi.ApplicationCreation.CreateFirstAppForOneOneOneAEastStPerestrian(responseMarketplaceAdmin.AuthData.Token, requestBodyapplication);

            #endregion

            #region Preconditions API Add applicants to application

            var requestBodyAddApplicants = CazamioNewProject.AddApplicantsApi.AddApplicants.RequestBodyAddOccupantAppForOneOneOneAEastStPerestrian();
            CazamioNewProject.AddApplicantsApi.AddApplicants.AddOccupantAppForOneOneOneAEastStPerestrian(responseMarketplaceAdmin.AuthData.Token, requestBodyAddApplicants);

            #endregion

            //#region Preconditions GUI

            //Pages.LogInLandlord
            //    .LogInAsAgentBrokerMySpace();
            //Pages.SidebarLandlord
            //    .ClickButtonBuildings();
            //Pages.ListOfBuildings
            //    .SearchOneOneOneAEastStPerestrian()
            //    .SelectOneOneOneAEastStPerestrian();
            //Pages.BuildingView
            //    .VerifyTitleBuildingViewPage();

            //string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            //Pages.BuildingView
            //    .VerifyBuildingAddress(getAddressBuildingViewActual, building.East51stStreetPedestrianCrossing.NumberNameAddressStaticForSearch)
            //    .ClickTabApartments();

            //string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentDeanStreet();

            //KeyBoardActions.ScrollToDown();
            //Pages.BuildingApartmentsTbl
            //    .ClickRowByOffMarket();
            //Pages.ApartmentView
            //    .VerifyTitleApartmentViewPage();
            //Pages.ApartmentView
            //    .ClickTabApplications();
            //KeyBoardActions.ScrollToDown();

            //string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();

            //Pages.ApartmentApplicationsTbl
            //    .ClickFirstRow();
            //Pages.ApplicationDetail
            //    .VerifyTitleApplicationDetailPage();

            //#endregion

            //#region Test

            //var (window, mainApplicantNewlyCreatedPartEmailOld, occupantPartEmailOld, guarantorPartEmailOld) =
            //Pages.EditApplicationMdlWndw.EditFirstApplicationOneTwoFiveSixSevenDeanStreet();
            ////Main applicant newly created who has been deleted from the application
            //Pages.JScriptExecutor
            //   .OpenNewTab();
            //Pages.EmailHelper
            //   .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, mainApplicantNewlyCreatedPartEmailOld);

            //string getSubjectFromEmail = Pages.EmailPutsBox.GetSubjectLetterCreateTenantViaGetLink();

            //Pages.EmailPutsBox
            //    .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmail);
            //Pages.EmailPutsBox
            //    .ClickButtonHtml()
            //    .ClickButtonStartYourApplicationNowForTenant();
            //Pages.ToasterMessagesTenants
            //    .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            //Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
            //    .QuicklyPassTenantCreatorMySpace();
            //Pages.MyAccount
            //    .VerifyYouHaveNoApplicationsYetRecord();
            //Pages.HeaderTenants
            //    .LogOut();
            ////Main applicant already created who has been added to the application
            //Pages.LogInTenant
            //    .LogInAsCreatorWithoutCreditReportMySpace();
            //Pages.HeaderTenants
            //    .ClickButtonMyApplications();

            //string applicationIdFromAppTenant = Pages.MyAccount.GetApplicationId();

            //Pages.MyAccount
            //    .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, applicationIdFromAppTenant);
            //Pages.HeaderTenants
            //    .LogOut();
            ////Occupant newly created who has been deleted from the application
            //Pages.JScriptExecutor
            //   .OpenNewTab();
            //Pages.EmailHelper
            //   .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, occupantPartEmailOld);

            //string getSubjectFromEmailOccupant = Pages.EmailPutsBox.GetSubjectLetterCreateTenantViaGetLink();

            //Pages.EmailPutsBox
            //    .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmailOccupant);
            //Pages.EmailPutsBox
            //    .ClickButtonHtml();
            //Pages.SwitchingBetweenBrowserTabsActions
            //    .SecondTabCloseThreeTimes();
            //Pages.EmailPutsBox
            //    .ClickButtonStartYourApplicationNowForTenant();
            //Pages.ToasterMessagesTenants
            //    .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            //Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
            //    .QuicklyPassTenantCreatorMySpace();
            //Pages.MyAccount
            //    .VerifyYouHaveNoApplicationsYetRecord();
            //Pages.HeaderTenants
            //    .LogOut();
            ////Guarantor newly created who has been deleted from the application
            //Pages.JScriptExecutor
            //   .OpenNewTab();
            //Pages.EmailHelper
            //   .OpenPutsBox(Pages.EmailPutsBox.SubjectLetterCreateTenantViaGetLink, guarantorPartEmailOld);

            //string getSubjectFromEmailGuarantor = Pages.EmailPutsBox.GetSubjectLetterCreateTenantViaGetLink();

            //Pages.EmailPutsBox
            //    .VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(getSubjectEmailExpected, getSubjectFromEmailGuarantor);
            //Pages.EmailPutsBox
            //    .ClickButtonHtml();
            //Pages.SwitchingBetweenBrowserTabsActions
            //    .SecondTabCloseThreeTimes();
            //Pages.EmailPutsBox
            //    .ClickButtonStartYourApplicationNowForTenant();
            //Pages.ToasterMessagesTenants
            //    .VerifyMessageAccountWasSuccessfullyActivatedWarningNoAccessToViewThisApplication();
            //Pages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
            //    .QuicklyPassTenantCreatorMySpace();
            //Pages.MyAccount
            //    .VerifyYouHaveNoApplicationsYetRecord();
            //Pages.HeaderTenants
            //    .LogOut();

            //WaitUntil.WaitSomeInterval(1000);

            //#endregion
        }
    }
}