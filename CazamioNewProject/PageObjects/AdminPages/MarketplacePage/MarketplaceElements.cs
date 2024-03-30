using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Marketplace']"))]
        public IWebElement TitleMarketplacePage;
    }
}
