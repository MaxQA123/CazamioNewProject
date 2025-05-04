using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        #region Building view page

        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = ("//div[text() = 'Building view']"))]
        public IWebElement TitleBuildingViewPage;

        [FindsBy(How = How.XPath, Using = ("//div[@class = 'form-result-wrapper']/div/div[2]"))]
        public IWebElement ValueOfStringAddress;

        [FindsBy(How = How.XPath, Using = ("//building-view//form//div/div"))]
        public IWebElement ValueOfStringBuildingName;

        [FindsBy(How = How.XPath, Using = ("//building-view//div[@class = 'credit-screening-fee']//span[text() = ' edit ']"))]
        public IWebElement ButtonEditOfCreditScreeningFee;

        [FindsBy(How = How.XPath, Using = ("//building-view//div[@class = 'credit-screening-fee']//span[text() = ' save ']"))]
        public IWebElement ButtonSaveOfCreditScreeningFee;

        [FindsBy(How = How.XPath, Using = ("//building-view//div[@class = 'credit-screening-fee']//input"))]
        public IWebElement FieldInputCreditScreeningFee;

        #endregion

        #region TabsLine

        [FindsBy(How = How.XPath, Using = ("//a[text() = 'Apartments']"))]
        public IWebElement TabApartments;

        #endregion

        #region InTabApartments

        [FindsBy(How = How.XPath, Using = ("//app-building-apartments//span[text() = 'Add']"))]
        public IWebElement ButtonAddInTabApartments;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Clone']"))]
        public IWebElement ButtonCloneInTabApartments;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement ButtonUnitSortingInTabApartments;

        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr//td[text() = '1']"))]
        public IWebElement UnitFourInTabApartments;

        #endregion
    }
}
