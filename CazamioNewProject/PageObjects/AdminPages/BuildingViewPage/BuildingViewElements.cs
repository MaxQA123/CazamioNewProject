using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Building view']"))]
        public IWebElement TitleBuildingViewPage;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'form-result-wrapper']/div/div[2]"))]
        public IWebElement FieldNotInputAddress;

        [FindsBy(How = How.XPath, Using = ("//building-view//form//div/div"))]
        public IWebElement FieldNotInputBuildingName;

        #region TabsLine

        [FindsBy(How = How.XPath, Using = ("//a[text() = 'Apartments']"))]
        public IWebElement TabApartments;

        #endregion

        #region InTabApartments

        [FindsBy(How = How.XPath, Using = ("//app-building-apartments//span[text() = 'Add']"))]
        public IWebElement ButtonAddInTabApartments;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Clone apartment']"))]
        public IWebElement ButtonCloneInTabApartments;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement ButtonUnitSortingInTabApartments;

        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr//td[text() = '1']"))]
        public IWebElement UnitFourInTabApartments;

        #endregion
    }
}
