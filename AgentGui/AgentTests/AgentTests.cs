using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace AgentGuiTests
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : AgentBase
    {
        //Amount order 3 next must be 4
        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test

            Pages.LogInLandlord
               .LogInAsAgentMySpace();

            #endregion
        }

        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            #region Preconditions

            Pages.LogInLandlord
               .LogInAsAgentMySpace();

            #endregion

            #region Test

            Pages.SidebarLandlord
                .ChangingImageUserOfAgent()
                .ClickingAllTabsOfAgent();
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
        [AllureSuite("Agent")]
        [AllureSubSuite("CreateApplicationForApartmenVacantFst")]

        public void CreateApplicationForApartmenVacantFst()
        {
            #region SettingsForBuilding

            //1 Washington square

            #endregion

            #region Test data

            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantGuarantorMySpace tenantGuarantorMySpace = TenantGuarantorMySpace.Generate();

            #endregion

            #region Test Data API

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentVacantFrstStatus();

            #endregion

            #region Preconditions API

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
               .LogInAsAgentMySpace();
            Pages.SidebarLandlord
                .ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();

            #endregion

            #region Test

            Pages.CreateApplicationMdlWndw
                .PassFirstStepCreatorWithoutCreditReportMySpace()
                .PassSecondStepOneWashingtonSquareAddress();

            string getEmailAr = Pages.CreateApplicationMdlWndw.GetFullEmail();

            Pages.CreateApplicationMdlWndw
                .VerifyEmailTenantCreatorWithoutCreditReport(getEmailAr)
                .PassThirdStepOneWashingtonSquareAddress()
                .VerifyTitleApplicationSuccessfullyCreated()
                .VerifyTextLinkAlreadyCopied()
                .ClickButtonAddApplicant();
            Pages.AddApplicantMdlWndw
                .AddOnlyAlreadyExistGuarantorWithoutCreditReport()
                .ClickBtnAdd();

            string applicationIdFromAppLandlord = Pages.ListOfApplicationsApplicationsTbl.GetApplicationIdFromFirstRow();
            string fullNameTenantMainApplicantFromAppAr = Pages.ListOfApplicationsApplicationsTbl.GetFullNameTenantMainApplicantFromFirstRow();
            string leasePriceFromApp = Pages.ListOfApplicationsApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ListOfApplicationsApplicationsTbl.GetDateCreatedFromFirstRow();
            string statusFromApp = Pages.ListOfApplicationsApplicationsTbl.GetVlLabelOfClmnDraftStatusWithoutAgentFrstRw().Text;
            string btnNameFromApp = Pages.ListOfApplicationsApplicationsTbl.GetVlLabelOfClmnCloseBtnWithoutAgentFrstRw().Text;

            Pages.ListOfApplicationsApplicationsTbl
                .VerifyDataWitoutAgentByApplicationTenantMain
                (tenantCreatorMySpace.CreatedWithoutCreditReport.ConstantFirstLastName, fullNameTenantMainApplicantFromAppAr,
                application.LeasePrice.FirstPriceStatic, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, btnNameFromApp);

            Pages.JScriptExecutor
              .OpenNewTabHomePageTenant();
            Pages.LogInTenant
                .LogInAsCreatorWithoutCreditReportMySpace();
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
                .LogInAsGuarantorWithoutCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();

            string appIdFromAppTenantOccupant = Pages.MyAccount.GetApplicationId();

            Pages.MyAccount
                .VerifyApplicationIdNumberTenantGuarantor(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent")]
        [AllureSubSuite("CreateApplicationForApartmenVacantFst")]

        public void CreateApplicationForApartmenVacantScnd()
        {
            #region SettingsForBuilding

            //1 Washington square

            #endregion

            #region Test data

            Apartment apartment = Apartment.Generate();
            Application application = Application.Generate();
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();
            TenantGuarantorMySpace tenantGuarantorMySpace = TenantGuarantorMySpace.Generate();

            #endregion

            #region Test Data API

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            var requestBodyApartment = CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.RequestBodyCreateApartmentVacantScndStatus();

            #endregion

            #region Preconditions API

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);
            CazamioNewProject.CreateApartmentMandatoryDataApi.ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion

            #region Preconditions Test

            Pages.LogInLandlord
               .LogInAsAgentMySpace();
            Pages.SidebarLandlord
                .ClickButtonBuildings();
            Pages.ListOfBuildings
                .SearchBuildingOneWashingtonSquare()
                .SelectOneWashingtonSquare();
            Pages.BuildingView
                .VerifyTitleBuildingViewPage();

            string getAddressBuildingViewActual = Pages.BuildingView.GetValueOfStringAddress();

            Pages.BuildingView
                .VerifyBuildingAddress(getAddressBuildingViewActual, apartment.BuildingShortAddress.OneWashingtonSquare)
                .ClickTabApartments();
            KeyBoardActions.ScrollToDown();

            string getSubjectEmailExpected = Pages.ApartmentView.GetSubjectWithoutAgentAlbermaleRd();

            Pages.BuildingApartmentsTbl
                .ClickRowByVacant();

            #endregion

            #region Test

            Pages.CreateApplicationMdlWndw
                .PassFirstStepCreatorWithoutCreditReportMySpace();

            string getEmailAr = Pages.CreateApplicationMdlWndw.GetFullEmail();

            Pages.CreateApplicationMdlWndw
                .VerifyEmailTenantCreatorWithoutCreditReport(getEmailAr)
                .PassThirdStepOneWashingtonSquareAddress()
                .VerifyTitleApplicationSuccessfullyCreated()
                .VerifyTextLinkAlreadyCopied()
                .ClickButtonAddApplicant();
            Pages.AddApplicantMdlWndw
                .AddOnCreatedOccupantWithoutCrdtRprtGuarantorWithCrdtRprt()
                .ClickBtnAdd();
            Pages.ApartmentView
                .ClickTabApplications();

            string applicationIdFromAppLandlord = Pages.ApartmentApplicationsTbl.GetApplicationIdFromFirstRow();
            string apartmentAddressFromApp = Pages.ApartmentApplicationsTbl.GetApartmentAddressFromFirstRow();
            string fullNameTenantMainApplicantFromAppAr = Pages.ApartmentApplicationsTbl.GetFullNameTenantMainApplicantFromFirstRow();
            string fullNameTenantOccupantFromAppAr = Pages.ApartmentApplicationsTbl.GetFirstLastNameTenantOccupantFromFirstRow();
            string leasePriceFromApp = Pages.ApartmentApplicationsTbl.GetPriceFromFirstRow();
            string dateCreatedFromApp = Pages.ApartmentApplicationsTbl.GetDateCreatedFromFirstRow();
            string statusFromApp = Pages.ApartmentApplicationsTbl.GetVlLabelOfClmnDraftStatusWithoutAgentFrstRw().Text;
            string closeBtnNameFromApp = Pages.ApartmentApplicationsTbl.GetCloseNameBtnWithoutAgentFrstRw().Text;

            Pages.ApartmentApplicationsTbl
                .VerifyDataWitoutAgentByApplicationCreatedTenantMainOccupant
                (apartment.BuildingShortAddress.OneWashingtonSquare, apartmentAddressFromApp,
                tenantCreatorMySpace.CreatedWithoutCreditReport.ConstantFirstLastName, fullNameTenantMainApplicantFromAppAr,
                tenantOccupantMySpace.CreatedWitoutCreditReport.ConstantFirstLastName, fullNameTenantOccupantFromAppAr,
                application.LeasePrice.FirstPriceStatic, leasePriceFromApp,
                application.BasicData.DateCurrent, dateCreatedFromApp,
                application.Statuses.Draft, statusFromApp,
                application.Buttons.Close, closeBtnNameFromApp);

            //Pages.JScriptExecutor
            //  .OpenNewTabHomePageTenant();
            //Pages.LogInTenant
            //    .LogInAsCreatorWithoutCreditReportMySpace();
            //Pages.HeaderTenants
            //    .ClickButtonMyApplications();

            //string appIdFromAppTenantCreator = Pages.MyAccount.GetApplicationId();

            //Pages.MyAccount
            //    .VerifyApplicationIdNumberTenantCreator(applicationIdFromAppLandlord, appIdFromAppTenantCreator);
            //Pages.HeaderTenants
            //    .LogOut();
            //Pages.JScriptExecutor
            //  .OpenNewTabHomePageTenant();
            //SelectThirdTabBrowser.Open();
            //Pages.LogInTenant
            //    .LogInAsGuarantorWithoutCreditReportMySpace();
            //Pages.HeaderTenants
            //    .ClickButtonMyApplications();

            //string appIdFromAppTenantOccupant = Pages.MyAccount.GetApplicationId();

            //Pages.MyAccount
            //    .VerifyApplicationIdNumberTenantGuarantor(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }
    }
}
