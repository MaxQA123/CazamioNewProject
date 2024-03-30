using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects.AdminPages.BuildingViewPage;
using CazamioNewProject.PageObjects.AdminPages.DashboardPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage;
using CazamioNewProject.PageObjects.AdminPages.ListOfTransactionsPage;
using CazamioNewProject.PageObjects.AdminPages.LogInPage;
using CazamioNewProject.PageObjects.AdminPages.MarketplacePage;
using CazamioNewProject.PageObjects.AdminPages.PaymentSettingsPage;
using CazamioNewProject.PageObjects.AdminPages.ReportsPage;
using CazamioNewProject.PageObjects.AdminPages.SidebarPage;
using CazamioNewProject.PageObjects.AdminPages.TemplatesPage;
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

        #region Landlord pages

        public static SuperAdmin SuperAdmin => GetPage<SuperAdmin>();
        public static MarketplaceAdmin MarketplaceAdmin => GetPage<MarketplaceAdmin>();
        public static Broker Broker => GetPage<Broker>();
        public static Agent Agent => GetPage<Agent>();
        public static AgentBroker AgentBroker => GetPage<AgentBroker>();
        public static Building Building => GetPage<Building>();
        public static Apartment Apartment => GetPage<Apartment>();
        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static Sidebar Sidebar => GetPage<Sidebar>();
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

        #endregion
    }
}
