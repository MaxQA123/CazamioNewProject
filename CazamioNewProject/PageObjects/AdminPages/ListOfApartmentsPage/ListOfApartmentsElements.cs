using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'List of apartments']")]
        public IWebElement TitleListOfApartmentsPage;
    }
}
