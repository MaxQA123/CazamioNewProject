using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [FindsBy(How = How.XPath, Using = ("//div[text() = 'List of commissions']"))]
        public IWebElement TitleListOfCommissions;
    }
}
