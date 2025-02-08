using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.VisitLogsPage
{
    public partial class VisitLogs
    {
        [FindsBy(How = How.XPath, Using = "//div[text() = 'Visit logs']")]
        public IWebElement TitleVisitLogsPg;
    }
}
