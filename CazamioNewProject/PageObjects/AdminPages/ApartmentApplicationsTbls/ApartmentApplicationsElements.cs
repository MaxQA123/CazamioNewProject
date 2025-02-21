using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        #region Elements from first row

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr"))]
        public IWebElement FirstRow;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[2]"))]
        public IWebElement VlOfClmnApartmentFirstRow;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[1]"))]
        public IWebElement VlIdOfClmnApplicationIdFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[3]//div"))]
        public IWebElement VlMainApplicantOfClmnApplicantsFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[3]//div[2]"))]
        public IWebElement VlOccupantOfClmnApplicantsFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[4]"))]
        public IWebElement VlOfClmnPriceFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[5]"))]
        public IWebElement VlOfClmnCreatedOnFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[7]"))]
        public IWebElement VlOfClmnAgentFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[10]//div[@class = 'statuses-wrapper']//span//span"))]
        public IWebElement VlLabelOfClmnStatusFrstRw;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[10]//div[@class = 'btn-wrapper']//cazamio-button[@text = 'Close']"))]
        public IWebElement CloseNameBtnOfClmnStatusFrstRw;

        #endregion
    }
}
