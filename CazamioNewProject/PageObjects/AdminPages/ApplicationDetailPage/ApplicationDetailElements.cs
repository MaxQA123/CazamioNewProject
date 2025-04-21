using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Application detail']"))]
        public IWebElement TitleApplicationDetailPage;

        [FindsBy(How = How.XPath, Using = ("//app-application-detail//div[@class = 'application-buttons']//button[@title = 'Edit application']"))]
        public IWebElement EditApplicationBtn;
    }
}
