﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage;
using CazamioNewProject.PageObjects.AdminPages.AreYouSureLogOutMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls;
using CazamioNewProject.PageObjects.AdminPages.BuildingViewPage;
using CazamioNewProject.PageObjects.AdminPages.Create_ANewOwnerMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.DashboardPage;
using CazamioNewProject.PageObjects.AdminPages.DatePickerMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfMarketplaceAdminsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfTransactionsPage;
using CazamioNewProject.PageObjects.AdminPages.LogInPage;
using CazamioNewProject.PageObjects.AdminPages.MarketplacePage;
using CazamioNewProject.PageObjects.AdminPages.NewBuildingPage;
using CazamioNewProject.PageObjects.AdminPages.PaymentKeysMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.PaymentSettingsPage;
using CazamioNewProject.PageObjects.AdminPages.PetPoliciesMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.ReportsPage;
using CazamioNewProject.PageObjects.AdminPages.SelectorVideosMdlWndw;
using CazamioNewProject.PageObjects.AdminPages.SidebarPage;
using CazamioNewProject.PageObjects.AdminPages.TemplatesPage;
using CazamioNewProject.PageObjects.EmailPutsBoxPage;
using CazamioNewProject.PageObjects.TenantPages.Header;
using CazamioNewProject.PageObjects.TenantPages.LogInPage;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        #region Landlord objects

        public static SuperAdmin SuperAdmin => GetPage<SuperAdmin>();
        public static MarketplaceAdmin MarketplaceAdmin => GetPage<MarketplaceAdmin>();
        public static Broker Broker => GetPage<Broker>();
        public static Agent Agent => GetPage<Agent>();
        public static AgentBroker AgentBroker => GetPage<AgentBroker>();
        public static Building Building => GetPage<Building>();
        public static Apartment Apartment => GetPage<Apartment>();
        public static BuildingApartmentsTable BuildingApartmentsTable => GetPage<BuildingApartmentsTable>();
        public static Demo Demo => GetPage<Demo>();

        #endregion

        #region Landlord pages

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static SidebarLandlord SidebarLandlord => GetPage<SidebarLandlord>();
        public static Dashboard Dashboard => GetPage<Dashboard>();
        public static ListOfBuildings ListOfBuildings => GetPage<ListOfBuildings>();
        public static ListOfApartments ListOfApartments => GetPage<ListOfApartments>();
        public static ListOfApplications ListOfApplications => GetPage<ListOfApplications>();
        public static ListOfBrokers ListOfBrokers => GetPage<ListOfBrokers>();
        public static Templates Templates => GetPage<Templates>();
        public static PaymentSettings PaymentSettings => GetPage<PaymentSettings>();
        public static ListOfTransactions ListOfTransactions => GetPage<ListOfTransactions>();
        public static ListOfLeads ListOfLeads => GetPage<ListOfLeads>();
        public static ListOfCommissions ListOfCommissions => GetPage<ListOfCommissions>();
        public static ListOfAgents ListOfAgents => GetPage<ListOfAgents>();
        public static ListOfOwners ListOfOwners => GetPage<ListOfOwners>();
        public static Marketplace Marketplace => GetPage<Marketplace>();
        public static Reports Reports => GetPage<Reports>();
        public static BuildingView BuildingView => GetPage<BuildingView>();
        public static ListOfMarketplaceAdmins ListOfMarketplaceAdmins => GetPage<ListOfMarketplaceAdmins>();
        public static NewBuilding NewBuilding => GetPage<NewBuilding>();
        public static AddApartments AddApartments => GetPage<AddApartments>();

        #endregion

        #region Landlord tables

        public static BuildingApartments BuildingApartments => GetPage<BuildingApartments>();

        #endregion

        #region Landlord modal Windows

        public static CreateANewMarketplaceAdminMdlWindow CreateANewMarketplaceAdminMdlWindow => GetPage<CreateANewMarketplaceAdminMdlWindow>();
        public static AreYouSureLogOutLandlordMdlWndw AreYouSureLogOutLandlordMdlWndw => GetPage<AreYouSureLogOutLandlordMdlWndw>();
        public static CreateANewBrokerMdlWndw CreateANewBrokerMdlWndw => GetPage<CreateANewBrokerMdlWndw>();
        public static CreateNewAgentMdlWndw CreateNewAgentMdlWndw => GetPage<CreateNewAgentMdlWndw>();
        public static CreateANewOwnerMdlWndw CreateANewOwnerMdlWndw => GetPage<CreateANewOwnerMdlWndw>();
        public static PaymentKeysMdlWndw PaymentKeysMdlWndw => GetPage<PaymentKeysMdlWndw>();
        public static PaymentOptionsMdlWndw PaymentOptionsMdlWndw => GetPage<PaymentOptionsMdlWndw>();
        public static PetPoliciesMdlWndw PetPoliciesMdlWndw => GetPage<PetPoliciesMdlWndw>();
        public static SelectorVideosMdlWndw SelectorVideosMdlWndw => GetPage<SelectorVideosMdlWndw>();
        public static DatePicker DatePicker => GetPage<DatePicker>();

        #endregion

        public static EmailPutsBox EmailPutsBox => GetPage<EmailPutsBox>();
        public static EmailHelper EmailHelper => GetPage<EmailHelper>();

        public static JScriptExecutor JScriptExecutor => GetPage<JScriptExecutor>();

        #region Tanant pages

        public static Header Header => GetPage<Header>();
        public static LogInTenant LogInTenant => GetPage<LogInTenant>();

        #endregion
    }
}
