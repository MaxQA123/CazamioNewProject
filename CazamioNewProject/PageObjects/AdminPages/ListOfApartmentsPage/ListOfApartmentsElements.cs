using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApartmentsPage
{
    public partial class ListOfApartments
    {
        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'List of apartments']")]
        public IWebElement TitleListOfApartmentsPage;

        [FindsBy(How = How.XPath, Using = "//app-apartment-card//div")]
        public IWebElement FirstRowInListOfApartments;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAdd;
    }
}
