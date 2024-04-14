using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage
{
    public partial class ListOfLeads
    {
        [FindsBy(How = How.XPath, Using = ("//div[@class = 'main-content']//div[text() = 'Leads']"))]
        public IWebElement TitleLeads;
    }
}
