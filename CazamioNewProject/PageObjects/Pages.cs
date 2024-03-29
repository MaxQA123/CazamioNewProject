using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects.AdminPages.LogInPage;
using CazamioNewProject.PageObjects.AdminPages.SidebarPage;
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

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
        public static Sidebar Sidebar => GetPage<Sidebar>();
        public static SuperAdmin SuperAdmin => GetPage<SuperAdmin>();
        public static MarketplaceAdmin MarketplaceAdmin => GetPage<MarketplaceAdmin>();
        public static Broker Broker => GetPage<Broker>();
        public static Agent Agent => GetPage<Agent>();
        public static AgentBroker AgentBroker => GetPage<AgentBroker>();
    }
}
