using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.DashboardPage
{
    public partial class Dashboard
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Dashboard']"))]
        public IWebElement TitleDashboardPage;
    }
}
