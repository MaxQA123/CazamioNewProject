using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBuildingsPage
{
    public partial class ListOfBuildings
    {
        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'List of buildings']")]
        public IWebElement TitleListOfBuildingsPage;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAdd;

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//tr")]
        public IWebElement ItemFirstBuildingOnPage;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'field-search']")]
        public IWebElement FieldInputSearch;
    }
}
