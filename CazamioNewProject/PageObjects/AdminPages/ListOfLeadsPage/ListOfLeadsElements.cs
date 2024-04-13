using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage
{
    public partial class ListOfLeads
    {
        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement TitleLeads;
    }
}
