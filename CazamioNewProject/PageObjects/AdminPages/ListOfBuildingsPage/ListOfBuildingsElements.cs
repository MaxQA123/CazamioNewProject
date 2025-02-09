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

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//td[text() = '1 Washington Square New York NY']")]
        public IWebElement ItemOneWashingtonSquare;

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//td[text() = '9998 Saint Johnson Place Brooklyn NY']")]
        public IWebElement ItemNineNineNineEightSaintJohnsonPlace;

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//td[text() = '30-39 Crown St Brooklyn NY']")]
        public IWebElement ItemThirtyDashThirtyNineCrownSt;

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//td[text() = '111A East 51st Street Pedestrian Crossing New York NY']")]
        public IWebElement ItemOneOneOneAEastStPerestrian;

        [FindsBy(How = How.XPath, Using = "//building-list//table//tbody//td[text() = '9A Albermale Rd Brooklyn NY']")]
        public IWebElement ItemNineAAlbermaleRd;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'field-search']")]
        public IWebElement FieldInputSearch;
    }
}
