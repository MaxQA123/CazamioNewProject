using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsApplicationsTbls
{
    public partial class ListOfApplicationsApplicationsTbl
    {
        #region Elements from first row

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr"))]
        public IWebElement FirstRow;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[2]"))]
        public IWebElement VlOfClmnApartmentFirstRow;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td"))]
        public IWebElement VlIdOfClmnApplicationIdFrstRw;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[3]//div"))]
        public IWebElement VlMainApplicantOfClmnApplicantsFrstRw;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[3]//div[2]"))]
        public IWebElement VlOccupantOfClmnApplicantsFrstRw;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[4]"))]
        public IWebElement VlOfClmnPriceFrstRw;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[5]"))]
        public IWebElement VlOfClmnCreatedOnFrstRw;

        [FindsBy(How = How.XPath, Using = ("//application-list//table//tbody//tr//td[7]"))]
        public IWebElement VlOfClmnAgentFrstRw;

        public IWebElement GetVlLabelOfClmnDraftStatusFrstRw()
        {
            Application application = Application.Generate();

            var xpath = "//application-list//table//tbody//tr//td[10]//span[text() = '" + application.Statuses.Draft + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement GetVlLabelOfClmnCloseBtnFrstRw()
        {
            Application application = Application.Generate();

            var xpath = "//application-list//table//tbody//tr//td[10]//cazamio-button//span[text() = '" + application.Buttons.Close + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        #endregion
    }
}
