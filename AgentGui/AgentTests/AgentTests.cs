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
        //Amount order 2 next must be 3
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
        [Retry(1)]
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

            //Pages.JScriptExecutor
            //  .OpenNewTabHomePageTenant();
            //Pages.LogInTenant
            //    .LogInAsCreatorWithCreditReportMySpace();
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
            //    .LogInAsOccupantWithCreditReportMySpace();
            //Pages.HeaderTenants
            //    .ClickButtonMyApplications();

            //string appIdFromAppTenantOccupant = Pages.MyAccount.GetApplicationId();

            //Pages.MyAccount
            //    .VerifyApplicationIdNumberTenantOccupant(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);

            WaitUntil.WaitSomeInterval(5000);

            #endregion
        }
    }
}
