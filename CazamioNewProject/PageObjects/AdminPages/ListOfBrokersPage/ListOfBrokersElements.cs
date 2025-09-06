using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'List of brokers']"))]
        public IWebElement TitleListOfBrokers;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Create Broker']"))]
        public IWebElement ButtonCreateBroker;

        [FindsBy(How = How.XPath, Using = "//app-landlords-list//table//tbody//tr//td[4]")]
        public IWebElement FirstRecordEmailForFirstBrokerInList;
    }
}
