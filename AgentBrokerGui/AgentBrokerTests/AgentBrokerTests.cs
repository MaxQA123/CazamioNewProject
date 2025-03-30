using Allure.Commons;
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
        //Amount order 6 next must be 7
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
                .VerifyTitle();

            #endregion
        }

        [Test]
        [Order(3)]
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
        [Order(4)]
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

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing)
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
        [Order(5)]
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

            Apartment apartment = Apartment.Generate();

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();
            string getBuildingNameFromBuildingView = Pages.BuildingView.GetValueOfStringBuildingName();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing)
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
        [Order(6)]
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

            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();

            #endregion

            #region Test Data API

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentOffMarketStatus();

            #endregion

            #region Preconditions API

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
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
                application.BasicData.NotAssignetLabel, agentFromApp,
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
            Pages.JScriptExecutor
              .OpenNewTabHomePageTenant();
            SelectThirdTabBrowser.Open();
            Pages.LogInTenant
                .LogInAsOccupantWithCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string appIdFromAppTenantOccupant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantOccupant(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);

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
        [AllureSubSuite("CreateApplicationForApartmentSignedLease")]

        public void CreateApplicationForApartmentSignedLease()
        {
            #region SettingsForBuilding

            //111A East 51st Street Pedestrian Crossing

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            AgentBroker agentBroker = AgentBroker.Generate();

            #endregion

            #region Test Data API

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentSignedLeaseStatus();

            #endregion

            #region Preconditions API

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
                .LogInAsAgentBrokerMySpace();
            Pages.SidebarLandlord
               .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchOneOneOneAEastStPerestrian()
                .SelectOneOneOneAEastStPerestrian();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneOneOneAEastFiftyOneStStreetPedestrianCrossing)
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
                .VerifyCopiedTheLinkToApplication()
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

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }
    }
}